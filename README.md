# Power Fx - Test Engine Module

This repository provides a proof of concept implementation of unit testing for Power Fx expressions making use of extensions to the Power Apps Test Engine.

Key concepts demonstrated by this sample:

- How to unit test Power Fx expressions

- Test Power Fx expressions in Power Apps yaml using local loop testing

## Prerequisites for building module

1. Install [.NET Core 6.0.x SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

2. Ensure that your `MSBuildSDKsPath` environment variable is pointing to [.NET Core 6.0.x SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

## Getting Started

1. Clone the PowerFx repo and submodules

```bash
git clone --recurse-submodules https://github.com/Grant-Archibald-MS/PowerFx-TestEngineModule.git
```

2. Build the module

```bash
cd PowerFx-TestEngineModule\src
dotnet build
```

3. Run sample test

```bash
cd ..\samples\basic
dotnet ..\..\PowerApps-TestEngine\bin\Debug\PowerAppsTestEngine\PowerAppsTestEngine.dll -i testPlan.fx.yaml -t 00000000-0000-0000-0000-000000000000 -e 00000000-0000-0000-0000-000000000000 -p powerfx -u local
```
