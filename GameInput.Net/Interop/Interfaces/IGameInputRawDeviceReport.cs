using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Structs;

namespace GameInputDotNet.Interop.Interfaces;

[ComImport]
[Guid("05A42D89-2CB6-45A3-874D-E635723587AB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputRawDeviceReport
{
    [PreserveSig]
    void GetDevice(out IGameInputDevice? device);

    [PreserveSig]
    void GetReportInfo(out GameInputRawDeviceReportInfo reportInfo);

    [PreserveSig]
    nuint GetRawDataSize();

    [PreserveSig]
    unsafe nuint GetRawData(nuint bufferSize, void* buffer);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool SetRawData(nuint bufferSize, void* buffer);
}