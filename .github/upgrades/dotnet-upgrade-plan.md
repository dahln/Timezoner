# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade Demo\Demo.csproj
4. Upgrade Timezoner\Timezoner.csproj

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                          | Current Version | New Version | Description                                   |
|:------------------------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.AspNetCore.Components.WebAssembly           | 9.0.1           | 10.0.0      | Recommended for .NET 10.0                     |
| Microsoft.AspNetCore.Components.WebAssembly.DevServer | 9.0.1           | 10.0.0      | Recommended for .NET 10.0                     |

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### Demo\Demo.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - Microsoft.AspNetCore.Components.WebAssembly should be updated from `9.0.1` to `10.0.0` (*recommended for .NET 10.0*)
  - Microsoft.AspNetCore.Components.WebAssembly.DevServer should be updated from `9.0.1` to `10.0.0` (*recommended for .NET 10.0*)

#### Timezoner\Timezoner.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net9.0;net8.0` to `net9.0;net8.0;net10.0`
