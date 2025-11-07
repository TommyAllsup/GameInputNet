# Interop layout

- `Structs/`: blittable representations of native GameInput structures (`namespace GameInputNet.Interop.Structs`).
- `Enums/`: managed enum mirrors for the native constants (`namespace GameInputNet.Interop.Enums`).
- `Interfaces/`: COM interface definitions for the GameInput runtime (`namespace GameInputNet.Interop.Interfaces`).
- `Delegates/`: P/Invoke callback delegates declared with `StdCall`.
- `Handles/`: safe-handle wrappers and other lifetime helpers.

Every folder uses a one-type-per-file convention to keep partial helpers co-located with the underlying type.
