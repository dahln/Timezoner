[![.NET CI/CD Nuget](https://github.com/dahln/Timezoner/actions/workflows/dotnet-nuget.yml/badge.svg)](https://github.com/dahln/Timezoner/actions/workflows/dotnet-nuget.yml)
[![Azure Static Web Apps CI/CD](https://github.com/dahln/Timezoner/actions/workflows/azure-static-web-apps-zealous-island-09cfe4010.yml/badge.svg)](https://github.com/dahln/Timezoner/actions/workflows/azure-static-web-apps-zealous-island-09cfe4010.yml)

# Timezoner

A simple .NET library to provide a consistent list of time zones with Id, Name, and Offset across all platforms.

[![NuGet](https://img.shields.io/nuget/v/Timezoner.svg)](https://www.nuget.org/packages/Timezoner/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Timezoner.svg)](https://www.nuget.org/packages/Timezoner/)

## Why Timezoner?

TimeZoneInfo provides timezones that are available for a particular system, but that list can vary from system to system. This library provides consistent timezone data across Windows, Linux, and macOS platforms.

## Installation

```bash
dotnet add package Timezoner
```

Or via Package Manager:
```powershell
Install-Package Timezoner
```

## Features

- ✅ Consistent timezone data across all platforms (Windows, Linux, macOS)
- ✅ Simple and lightweight
- ✅ Provides timezone Id, Name, and Offset
- ✅ Built for .NET 10.0
- ✅ Zero dependencies

## Methods

- `GetTimezones()` - Returns a list of all available timezones
- `GetTimezoneById(string id)` - Returns a specific timezone by its Id
- `GetOffsetAsTimeSpan(string id)` - Returns the UTC offset for a timezone by its Id
- `GetOffsetAsTimeSpan(Timezone zone)` - Returns the UTC offset for a timezone object

## Usage

```csharp
// Get all timezones
var timezones = Timezoner.GetTimezones();

// Get a specific timezone by Id
var timezone = Timezoner.GetTimezoneById("Eastern Standard Time");

// Get offset as TimeSpan by Id
var offset = Timezoner.GetOffsetAsTimeSpan("Eastern Standard Time");

// Get offset as TimeSpan from Timezone object
var offset = Timezoner.GetOffsetAsTimeSpan(timezone);
```

## Demo

See Timezoner in action: [Live Demo](https://zealous-island-09cfe4010.azurestaticapps.net/)

The demo is a Blazor WebAssembly app, but the library can be used in any .NET application (Console, Web API, Desktop, etc.).

> **Note:** The demo site currently runs on .NET 9 and references Timezoner v1.7.1 until Azure Static Web Apps natively supports .NET 10 in their build pipeline. We prefer to wait for official support rather than implement workarounds.

## Requirements

- **Latest version (2.x)**: .NET 10.0 or later
- **Previous versions (1.x)**: .NET 8.0 and .NET 9.0 (available on NuGet)

## Links

- [NuGet Package](https://www.nuget.org/packages/Timezoner/)
- [GitHub Repository](https://github.com/dahln/timezoner)
- [Report Issues](https://github.com/dahln/timezoner/issues)
- [Live Demo](https://zealous-island-09cfe4010.azurestaticapps.net/)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

Copyright (c) 2025 Dahln Farnes - [MIT License](LICENSE)
