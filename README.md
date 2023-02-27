[![.NET CI/CD Nuget](https://github.com/shadowlings/Timezoner/actions/workflows/dotnet-nuget.yml/badge.svg)](https://github.com/shadowlings/Timezoner/actions/workflows/dotnet-nuget.yml)
[![Azure Static Web Apps CI/CD](https://github.com/shadowlings/Timezoner/actions/workflows/azure-static-web-apps-zealous-island-09cfe4010.yml/badge.svg)](https://github.com/shadowlings/Timezoner/actions/workflows/azure-static-web-apps-zealous-island-09cfe4010.yml)

# Timezoner
A simple library to provide a list of time zones, providing an Id, Name, and Offset.

## Demo
See the TimeZoner in action: https://zealous-island-09cfe4010.azurestaticapps.net/. The demo is a Blazor app, but the libraries can be used in other 'non-web' applications as well.

Why this project exists: TimeZoneInfo provides timezones that are available for a particular system. That list could change from system to system. I noticed a difference in the lists when getting timezones in a Windows environment and a Linux environment. Thanks to the ability of .NET Core to run on multiple platforms, I created this library to provide my applications consitent timezone data across platforms.

Methods:
 - GetTimezones()
 - GetTimezoneById(string id)
 - GetOffsetAsTimeSpan(string id)
 - GetOffsetAsTimeSpan(Timezone zone)

Timezoner is available on Nuget: https://www.nuget.org/packages/Timezoner/
