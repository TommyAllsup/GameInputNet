using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace GameInputDotNet.Interop.Tests.Infrastructure;

internal sealed class GameInputHeaderManifest
{
    private GameInputHeaderManifest(
        IReadOnlyList<GameInputFunction> functions,
        IReadOnlyList<GameInputCallback> callbacks,
        string headerPath)
    {
        ExportedFunctions = functions;
        CallbackTypedefs = callbacks;
        HeaderPath = headerPath;
    }

    public IReadOnlyList<GameInputFunction> ExportedFunctions { get; }

    public IReadOnlyList<GameInputCallback> CallbackTypedefs { get; }

    public string HeaderPath { get; }

    public static GameInputHeaderManifest Load()
    {
        var headerPath = ResolveHeaderPath();
        if (!File.Exists(headerPath))
        {
            throw new FileNotFoundException($"GameInput header not found at '{headerPath}'.", headerPath);
        }

        var headerText = File.ReadAllText(headerPath);
        var functions = ParseFunctions(headerText);
        var callbacks = ParseCallbacks(headerText);

        return new GameInputHeaderManifest(functions, callbacks, headerPath);
    }

    public GameInputFunction FindFunction(string name)
    {
        return ExportedFunctions.FirstOrDefault(function =>
                   string.Equals(function.Name, name, StringComparison.Ordinal))
               ?? throw new InvalidOperationException($"GameInput.h does not declare a function named '{name}'.");
    }

    public GameInputCallback FindCallback(string name)
    {
        return CallbackTypedefs.FirstOrDefault(callback =>
                   string.Equals(callback.Name, name, StringComparison.Ordinal))
               ?? throw new InvalidOperationException($"GameInput.h does not declare a callback named '{name}'.");
    }

    private static string ResolveHeaderPath()
    {
        // Test binaries live under GameInput.Net.Interop.Tests/bin/<Configuration>/<TargetFramework>.
        var outputDirectory = AppContext.BaseDirectory;
        var projectRoot = Path.GetFullPath(Path.Combine(outputDirectory, "..", "..", ".."));
        var solutionRoot = Directory.GetParent(projectRoot)?.FullName
                           ?? throw new DirectoryNotFoundException($"Could not locate solution root from '{projectRoot}'.");

        return Path.Combine(solutionRoot, "GameInput.Net", "GameInput.h");
    }

    private static IReadOnlyList<GameInputFunction> ParseFunctions(string headerText)
    {
        var matches = FunctionRegex.Matches(headerText);
        var functions = new List<GameInputFunction>(matches.Count);

        foreach (Match match in matches)
        {
            var name = match.Groups["name"].Value;
            var parameterBlock = match.Groups["params"].Value;
            var normalizedParameters = NormalizeWhitespace(parameterBlock);
            functions.Add(new GameInputFunction(name, normalizedParameters));
        }

        return functions;
    }

    private static IReadOnlyList<GameInputCallback> ParseCallbacks(string headerText)
    {
        var matches = CallbackRegex.Matches(headerText);
        var callbacks = new List<GameInputCallback>(matches.Count);

        foreach (Match match in matches)
        {
            var name = match.Groups["name"].Value;
            var callConv = match.Groups["callconv"].Value;
            var parameterBlock = match.Groups["params"].Value;
            var normalizedParameters = NormalizeWhitespace(parameterBlock);
            callbacks.Add(new GameInputCallback(name, callConv, normalizedParameters));
        }

        return callbacks;
    }

    private static string NormalizeWhitespace(string value) =>
        WhitespaceRegex.Replace(value, " ").Trim();

    private static readonly Regex FunctionRegex = new(
        @"(?ms)^\s*(?:inline\s+)?(?:HRESULT|STDAPI)\s+(?<name>GameInput\w+)\s*\((?<params>[^)]*)\)",
        RegexOptions.Compiled);

    private static readonly Regex CallbackRegex = new(
        @"typedef\s+\w+(?:\s+\w+)*\s*\(\s*(?<callconv>[A-Z_][A-Z0-9_]*)\s*\*\s*(?<name>GameInput\w+)\s*\)\s*\((?<params>[^;]*)\);",
        RegexOptions.Compiled | RegexOptions.Multiline);

    private static readonly Regex WhitespaceRegex = new(@"\s+", RegexOptions.Compiled);
}

public sealed record GameInputFunction(string Name, string ParameterSignature);

public sealed record GameInputCallback(string Name, string CallingConventionToken, string ParameterSignature);
