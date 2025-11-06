namespace GameInputNet.Interop;

internal partial struct GameInputForceFeedbackParams
{
    // Constant
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

    // Ramp
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

    // SineWave
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

    // SquareWave
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

    // Triangle Wave
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

    // SawtoothUp Wave
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

    // SawtoothDown Wave
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

    // Spring
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

    // Friction
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

    // Damper
    public static GameInputForceFeedbackParams CreateDamper(GameInputForceFeedbackConditionParams payload)
    {
        return new GameInputForceFeedbackParams
        {
            Kind = GameInputForceFeedbackEffectKind.Damper,
            Data = new GameInputForceFeedbackData { Spring = payload }
        };
    }

    public GameInputForceFeedbackConditionParams GetDamper()
    {
        if (Kind != GameInputForceFeedbackEffectKind.Damper)
            throw new InvalidOperationException($"Kind {Kind} does not contain Damper payload.");
        return Data.Damper;
    }

    // Inertia
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