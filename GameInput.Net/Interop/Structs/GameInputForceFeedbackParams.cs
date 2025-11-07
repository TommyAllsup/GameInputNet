using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public partial struct GameInputForceFeedbackParams
{
    public GameInputForceFeedbackEffectKind Kind;
    public GameInputForceFeedbackData Data;

    [StructLayout(LayoutKind.Explicit)]
    public struct GameInputForceFeedbackData
    {
        [FieldOffset(0)] public GameInputForceFeedbackConstantParams Constant;
        [FieldOffset(0)] public GameInputForceFeedbackRampParams Ramp;
        [FieldOffset(0)] public GameInputForceFeedbackPeriodicParams SineWave;
        [FieldOffset(0)] public GameInputForceFeedbackPeriodicParams SquareWave;
        [FieldOffset(0)] public GameInputForceFeedbackPeriodicParams TriangleWave;
        [FieldOffset(0)] public GameInputForceFeedbackPeriodicParams SawtoothUpWave;
        [FieldOffset(0)] public GameInputForceFeedbackPeriodicParams SawtoothDownWave;
        [FieldOffset(0)] public GameInputForceFeedbackConditionParams Spring;
        [FieldOffset(0)] public GameInputForceFeedbackConditionParams Friction;
        [FieldOffset(0)] public GameInputForceFeedbackConditionParams Damper;
        [FieldOffset(0)] public GameInputForceFeedbackConditionParams Inertia;
    }
}

public partial struct GameInputForceFeedbackParams
{
    public static GameInputForceFeedbackParams CreateConstant(GameInputForceFeedbackConstantParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Constant,
            Data = new GameInputForceFeedbackData { Constant = payload }
        };
    }

    public GameInputForceFeedbackConstantParams GetConstant()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Constant)
            throw new InvalidOperationException($"Kind {Kind} does not contain a Constant payload.");

        return Data.Constant;
    }

    public static GameInputForceFeedbackParams CreateRamp(GameInputForceFeedbackRampParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Ramp,
            Data = new GameInputForceFeedbackData { Ramp = payload }
        };
    }

    public GameInputForceFeedbackRampParams GetRamp()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Ramp)
            throw new InvalidOperationException($"Kind {Kind} does not contain a Ramp payload.");

        return Data.Ramp;
    }

    public static GameInputForceFeedbackParams CreateSineWave(GameInputForceFeedbackPeriodicParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.SineWave,
            Data = new GameInputForceFeedbackData { SineWave = payload }
        };
    }

    public GameInputForceFeedbackPeriodicParams GetSineWave()
    {
        if (Kind != GameInputForceFeedbackEffectKind.SineWave)
            throw new InvalidOperationException($"Kind {Kind} does not contain SineWave payload.");

        return Data.SineWave;
    }

    public static GameInputForceFeedbackParams CreateSquareWave(GameInputForceFeedbackPeriodicParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.SquareWave,
            Data = new GameInputForceFeedbackData { SquareWave = payload }
        };
    }

    public GameInputForceFeedbackPeriodicParams GetSquareWave()
    {
        if (Kind != GameInputForceFeedbackEffectKind.SquareWave)
            throw new InvalidOperationException($"Kind {Kind} does not contain SquareWave payload.");

        return Data.SquareWave;
    }

    public static GameInputForceFeedbackParams CreateTriangleWave(GameInputForceFeedbackPeriodicParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.TriangleWave,
            Data = new GameInputForceFeedbackData { TriangleWave = payload }
        };
    }

    public GameInputForceFeedbackPeriodicParams GetTriangleWave()
    {
        if (Kind != GameInputForceFeedbackEffectKind.TriangleWave)
            throw new InvalidOperationException($"Kind {Kind} does not contain TriangleWave payload.");

        return Data.TriangleWave;
    }

    public static GameInputForceFeedbackParams CreateSawtoothUpWave(GameInputForceFeedbackPeriodicParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.SawtoothUpWave,
            Data = new GameInputForceFeedbackData { SawtoothUpWave = payload }
        };
    }

    public GameInputForceFeedbackPeriodicParams GetSawtoothUpWave()
    {
        if (Kind != GameInputForceFeedbackEffectKind.SawtoothUpWave)
            throw new InvalidOperationException($"Kind {Kind} does not contain SawtoothUpWave payload.");

        return Data.SawtoothUpWave;
    }

    public static GameInputForceFeedbackParams CreateSawtoothDownWave(GameInputForceFeedbackPeriodicParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.SawtoothDownWave,
            Data = new GameInputForceFeedbackData { SawtoothDownWave = payload }
        };
    }

    public GameInputForceFeedbackPeriodicParams GetSawtoothDownWave()
    {
        if (Kind != GameInputForceFeedbackEffectKind.SawtoothDownWave)
            throw new InvalidOperationException($"Kind {Kind} does not contain SawtoothDownWave payload.");

        return Data.SawtoothDownWave;
    }

    public static GameInputForceFeedbackParams CreateSpring(GameInputForceFeedbackConditionParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Spring,
            Data = new GameInputForceFeedbackData { Spring = payload }
        };
    }

    public GameInputForceFeedbackConditionParams GetSpring()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Spring)
            throw new InvalidOperationException($"Kind {Kind} does not contain Spring payload.");

        return Data.Spring;
    }

    public static GameInputForceFeedbackParams CreateFriction(GameInputForceFeedbackConditionParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Friction,
            Data = new GameInputForceFeedbackData { Friction = payload }
        };
    }

    public GameInputForceFeedbackConditionParams GetFriction()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Friction)
            throw new InvalidOperationException($"Kind {Kind} does not contain Friction payload.");

        return Data.Friction;
    }

    public static GameInputForceFeedbackParams CreateDamper(GameInputForceFeedbackConditionParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Damper,
            Data = new GameInputForceFeedbackData { Damper = payload }
        };
    }

    public GameInputForceFeedbackConditionParams GetDamper()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Damper)
            throw new InvalidOperationException($"Kind {Kind} does not contain Damper payload.");

        return Data.Damper;
    }

    public static GameInputForceFeedbackParams CreateInertia(GameInputForceFeedbackConditionParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Inertia,
            Data = new GameInputForceFeedbackData { Inertia = payload }
        };
    }

    public GameInputForceFeedbackConditionParams GetInertia()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Inertia)
            throw new InvalidOperationException($"Kind {Kind} does not contain Inertia payload.");

        return Data.Inertia;
    }
}