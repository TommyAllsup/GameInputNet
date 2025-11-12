// Include the Library.

using GameInputDotNet;
using GameInputDotNet.Interop.Enums;

// Instantiate GameInput object to interact with the GameInput system via the
// static GameInput.Create() method.  using ensures proper disposal.
using var gameInput = GameInput.Create();

gameInput.SetFocusPolicy(GameInputFocusPolicy.EnableBackgroundInput);

while (true)
{
    // Slow down the loop so we don't get super spammed.  This may result in
    // missing fast keypresses.  Use GetNextReading and track previous reading to
    // avoid missing any input changes.
    Thread.Sleep(100);

    // Create reading object
    GameInputReading? reading = null;
    try
    {
        // Get the current reading from the GameInput system. This allows us
        // to inquire at any time about the status of inputs.  You could also
        // use GetLastReading or GetNextReading.
        reading = gameInput.GetCurrentReading(GameInputKind.Keyboard | GameInputKind.Mouse);
    }
    catch (GameInputException)
    {
        // Sometimes the reading is not ready, or not generated so well just
        // catch and continue to the next reading.
        continue;
    }

    // If we got a null value we don't want to throw a null pointer exception.
    if (reading is null)
    {
        continue;
    }

    // This using ensures we properly dispose of the GameInputReading object
    // which implements IDisposable.
    //
    // Alternatively use a Try Finally with .Dispose()
    using (reading)
    {
        // Get the current state. 
        var state = reading.GetKeyboardState();
        var mouseState = reading.GetMouseState();

        // Write every mouse button that is pressed.
        if (mouseState != null)
        {
            if (mouseState.Buttons > 0)
            {
                foreach (GameInputMouseButtons button in Enum.GetValues(typeof(GameInputMouseButtons)))
                {
                    if (button == 0)
                    {
                        continue;
                    }

                    if (mouseState.Buttons.HasFlag(button))
                    {
                        Console.WriteLine($"{button.ToString()} pressed...");
                    }
                }
            }
        }

        if (state.Keys.Count == 0)
        {
            continue;
        }

        // Report each key that is currently pressed.
        Console.Write("Keys Pressed: ");
        // Print the name of the keys based on the virtual key byte.
        foreach (var key in state.Keys)
        {
            Console.Write($"{(ConsoleKey)key.VirtualKey} ");
        }

        Console.WriteLine();

        // We can also use this to end our program when the user hits Escape.
        if (state.Keys.Any(key => key.ScanCode == 1))
        {
            Console.WriteLine("Got ESCAPE key, ending program.");
            break;
        }
    }
}