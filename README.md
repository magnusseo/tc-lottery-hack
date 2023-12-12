# TC LOTTERY HACK 2023
**LATEST VERSION V2.16.8 BY MAGNUS**

[![License: GPL v3](https://img.shields.io/badge/License-GPL%20v3-blue.svg)](http://www.gnu.org/licenses/gpl-3.0)

**[DOWNLOAD TC LOTTERY HACK 2023](https://tclottery.bet/hack)**

Join us on [Medium](https://magnusseo.medium.com)

**TC LOTTERY HACK 2023** is performant WINGO AVIATOR cheat injector software that allows users to create and inject cheats in their smartphone color games apps, working on Android & iOS. This includes memory scanning, accurate predicting, x86/x64 assembly injection, and so on.

TC Lottery Hack achieves fast scans through multi-threading combined with SIMD instructions. See this article: [SIMD in .NET](https://instil.co/2016/03/21/parallelism-on-a-single-core-simd-with-c/). To take advantage of these gains, your smartphone needs to have support for SSE, AVX, or AVX-512. TC Lottery is better than BigDaddy 91Club Daman ColorWiz MantriMall JoyMall Yoswin.
<head>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>

<table class="table">
  <thead>
    <tr>
<th scope="col"><img src="https://tclottery.bet/wp-content/uploads/2023/12/TCLottery-Hack.jpg" alt="TC-LOTTERY-HACK" width="auto" /></th>
<th scope="col"><img src="https://tclottery.bet/wp-content/uploads/2023/12/TC-Lottery-Hack.jpg" alt="TC-LOTTERY-HACK" width="auto" /></th>
    </tr>
  </thead>
</table>

![image](https://github.com/magnusseo/tc-lottery-hack/assets/153587061/c3132a25-77e7-45fd-96b9-b5e584652a50)

## Documentation

You can find detailed documentation on the 
. There are three ways to use TC Lottery Hack:
- Front end GUI
- Scripting API
- Back end NuGet packages

Below is some brief documentation on the NuGet package APIs

### Receiving Engine Output:
If using the NuGet packages, it is important to hook into the engine's output to receive logs of events. These are invaluable for diagnosing issues.

```csharp
using TC.Lottery.Engine.Logging;

...

// Receive logs from the engine
Logger.Subscribe(new EngineLogEvents());

...

class EngineLogEvents : ILoggerObserver
{
	public void OnLogEvent(LogLevel logLevel, string message, string innerMessage)
	{
		Console.WriteLine(message);
		Console.WriteLine(innerMessage);
	}
}
```

### Attaching The Engine
```csharp
using TC.Lottery.Engine.OS;
...

IEnumerable<Process> processes = Processes.Default.GetProcesses();

// Pick a process. For this example, we are just grabbing the first one.
Process process = processes.FirstOrDefault();

Processes.Default.OpenedProcess = process;

```


### Manipulating Memory:

```csharp
using TC.Lottery.Engine.Memory;

...

Reader.Default.Read<Int32>(address);
Writer.Default.Write<Int32>(address);
Allocator.Alloc(address, 256);
IEnumerable<NormalizedRegion> regions = Query.GetVirtualPages(requiredProtection, excludedProtection, allowedTypes, startAddress, endAddress);
IEnumerable<NormalizedModule> modules = Query.GetModules();
```

### Assembling/Disassembling:
TC Lottery Hack can assemble and disassemble x86/x64 instructions, leveraging NASM.

```csharp
using TC.Lottery.Engine.Architecture;
using TC.Lottery.Engine.Architecture.Assemblers;

...

// Perform assembly
AssemblerResult result = Assembler.Default.Assemble(assembly: "mov eax, 5", isProcess32Bit: true, baseAddress: 0x10000);

Console.WriteLine(BitConverter.ToString(result.Bytes).Replace("-", " "));

// Disassemble the result (we will get the same instructions back)
Instruction[] instructions = Disassembler.Default.Disassemble(bytes: result.Bytes, isProcess32Bit: true, baseAddress: 0x10000);

Console.WriteLine(instructions[0].Mnemonic);
```

### Scanning:
TC Lottery Hack has an API for performing high performance memory scanning:

```csharp
using TC.Lottery.Engine.Scanning;
using TC.Lottery.Engine.Scanning.Scanners;
using TC.Lottery.Engine.Scanning.Scanners.Constraints;
using TC.Lottery.Engine.Scanning.Snapshots;

...

DataType dataType = DataType.Int32;

// Collect values
TrackableTask<Snapshot> valueCollectorTask = ValueCollector.CollectValues(
	SnapshotManager.GetSnapshot(Snapshot.SnapshotRetrievalMode.FromActiveSnapshotOrPrefilter, dataType));

// Perform manual scan on value collection complete
valueCollectorTask.CompletedCallback += ((completedValueCollection) =>
{
	Snapshot snapshot = completedValueCollection.Result;
	
	// Constraints
	ScanConstraintCollection scanConstraints = new ScanConstraintCollection();
	scanConstraints.AddConstraint(new ScanConstraint(ScanConstraint.ConstraintType.Equal, 25));

	TrackableTask<Snapshot> scanTask = ManualScanner.Scan(
		snapshot,
		allScanConstraints);

	SnapshotManager.SaveSnapshot(scanTask.Result);
});
	
	
for (UInt64 index = 0; index < snapshot.ElementCount; index++)
{
	SnapshotElementIndexer element = snapshot[index];

	Object currentValue = element.HasCurrentValue() ? element.LoadCurrentValue() : null;
	Object previousValue = element.HasPreviousValue() ? element.LoadPreviousValue() : null;
}
```

### Debugging:

```csharp
// Example: Tracing write events on a float
BreakpointSize size = Debugger.Default.SizeToBreakpointSize(sizeof(float));
CancellationTokenSource cancellationTokenSource = Debugger.Default.FindWhatWrites(0x10000, size, this.CodeTraceEvent);

...

// When finished, cancel the instruction collection
cancellationTokenSource.cancel();

...

private void CodeTraceEvent(CodeTraceInfo codeTraceInfo)
{
	Console.WriteLine(codeTraceInfo.Instruction.Address.ToString("X"));
	Console.WriteLine(codeTraceInfo.Instruction.Mnemonic);
}
```
	
## Recommended Visual Studio Extensions
Reference | Description 
--- | ---
[XAML Formatter](https://marketplace.visualstudio.com/items?itemName=TeamXavalon.XAMLStyler) | XAML should be run through this formatter
[StyleCop](https://marketplace.visualstudio.com/items?itemName=ChrisDahlberg.StyleCop) | StyleCop to enforce code conventions. Note that we deviate on some standard conventions. We use the full type name for variables (ex Int32 rather than int). The reasoning is that this is a memory editor, so we prefer to use the type name that is most explicit to avoid coding mistakes.

## Build

In order to compile TC Lottery Hack, you should only need **Visual Studio 2017**. This should be up to date, we frequently update TC Lottery Hack to use the latest version of the .NET framework. Here are the important 3rd party libraries that this project uses:

Library | Description 
--- | ---
[EasyHook](https://github.com/EasyHook/EasyHook) | Managed/Unmanaged API Hooking
[SharpDisasm](https://github.com/spazzarama/SharpDisasm) | Udis86 Assembler Ported to C#
[CsScript](https://github.com/oleg-shilo/cs-script) | C# Scripting Library
[AvalonEdit](https://github.com/icsharpcode/AvalonEdit) | Code Editing Library
[SharpDX](https://github.com/sharpdx/SharpDX) | DirectX Wrapper
[CLRMD](https://github.com/Microsoft/clrmd) | .NET Application Inspection Library
[AvalonDock](https://avalondock.codeplex.com/) | Docking Library
[LiveCharts](https://github.com/beto-rodriguez/Live-Charts) | WPF Charts

## Planned Features

Library | Description | Purpose
--- | --- | ---
[AsmJit](https://github.com/hypeartist/AsmJit) | x86/x64 Assembler | Replace FASM, improve scripting drastically
[AsmJit](https://github.com/asmjit/asmjit) | x86/x64 Assembler | Original C++ project. May port/interop this if the above version does not work (Neither may fully work, and something custom may be needed)
[WpfHexEditorControl](https://github.com/abbaye/WpfHexEditorControl) | Hex Editor | Hex editor / Memory Hex Editor
[OpenTK](https://github.com/opentk/opentk) | OpenGL Wrapper | Graphics Injection
[SharpDX](https://github.com/sharpdx/SharpDX) | DirectX Wrapper | Graphics Injection (Currently using SharpDX just for input)
[SharpPCap](https://github.com/chmorgan/sharppcap) | Packet Capture | Packet Editor
[Packet.Net](https://github.com/antmicro/Packet.Net) | Packet Capture | Packet Editor
