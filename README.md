# ParallelProgramming

Course samples for Parallel .NET Programming

## Updated for .NET 8

This repository has been updated to target .NET 8 with modern C# language features:

### Project Structure

**Console Applications:**
- All console applications now use modern SDK-style projects targeting .NET 8
- Features modern C# syntax including:
  - File-scoped namespaces
  - Value tuples instead of System.Tuple
  - Nullable reference types enabled
  - ImplicitUsings for cleaner code
  - Latest C# language version

**Projects included:**
- TaskSamples - Task parallel library examples
- ParallelSamples - Parallel programming patterns  
- ThreadingIssues - Threading problems and solutions
- AsyncSamples/Foundations - Async/await fundamentals
- AsyncSamples/ErrorHandling - Async error handling
- AsyncSamples/AsyncLib - Shared library for async samples
- AsyncDelegate, BarrierSample, CancellationSamples, DataFlowSample, EventSample, EventSampleWithCountdownEvent, ReaderWriterLockSample, SemaphoreSample, SynchronizatonSamples, TimersSample, SimpleDataFlowSample

**WPF Applications:**
- WPF projects require .NET 8 with Windows Desktop workload:
  - SingletonWPF - Singleton pattern with WPF
  - AsyncSamples/AsyncPatternsWPF - Async patterns in WPF
  - WinAppTimer - Windows App (UWP) timer example

### Building the Projects

Ensure you have .NET 8 SDK installed:
```bash
dotnet --version
```

Build individual projects:
```bash
dotnet build TaskSamples/TaskSamples.csproj
dotnet build ParallelSamples/ParallelSamples.csproj
```

Run projects:
```bash
dotnet run --project TaskSamples -- -r
dotnet run --project ParallelSamples -- pf
```

### Modern C# Features Used

- **File-scoped namespaces** - cleaner syntax
- **Value tuples** - replaced System.Tuple with (int, int) syntax
- **Nullable reference types** - improved null safety
- **ImplicitUsings** - common using statements included automatically
- **Target-typed new expressions** - cleaner object creation
- **Expression-bodied members** - concise property and method syntax

### Original Legacy Support

The original project files targeted:
- .NET Core 1.0 (console applications)
- .NET Framework 4.6 (WPF applications)
- Portable Class Library (shared libraries)

These have been modernized to .NET 8 while maintaining the same functionality.
