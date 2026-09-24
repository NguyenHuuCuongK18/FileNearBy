# Windows shell setup

Project credit: **Leon (NguyenHuuCuongK18)**. Scope: Windows PC Host only; Android deferred.

Prerequisites: Windows x64 and .NET SDK **10.0.400**, pinned in global.json with roll-forward disabled. The SDK was already installed on the development machine. WPF reference/runtime components ship with the Windows .NET SDK; no third-party NuGet package or external asset is required by this shell. VS Code is the preferred editor; Visual Studio is optional.

Run from the `FileNearBy Host` directory in the VS Code terminal or PowerShell:

```powershell
dotnet --version
dotnet build FileNearBy.slnx -c Release --nologo
dotnet run --project src/FileNearBy.Host/FileNearBy.Host.csproj -c Release --no-build
```

Or open `src/FileNearBy.Host/bin/Release/net10.0-windows/FileNearBy.Host.exe` after building. This is a framework-dependent x64 app; it needs the .NET 10 Windows Desktop runtime. A standalone installer is later work.

The shell opens Overview. Select the left navigation entries with the mouse or keyboard; Home/End and arrow keys work when the navigation list has focus. Closing the window exits the app. Sharing, pairing, file access and storage management are not implemented, and empty states say so. No network service runs.

No generation step is needed to resume development. If the exact SDK is missing, install the documented version through an approved setup task; do not silently change global.json. A sandbox may need approval to access the SDK's user cache. On first use, the CLI can perform its standard .NET setup (including a development HTTPS certificate); the shell does not use it. No certificate trust command is required.

For an offline-source build with installed reference packs, `dotnet build FileNearBy.slnx -c Release --nologo --source .` avoids remote package feeds. This was verified from a new source-only staging folder without bin/obj. No Git commit was made, so this is clean-source build evidence, not a literal committed-checkout test.

Validation and environment: [P003 worklog](evidence/P003/WORKLOG.md). Future identity/credit handling: AGENTS.md. SDK policy reference: [Microsoft global.json documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/global-json).
