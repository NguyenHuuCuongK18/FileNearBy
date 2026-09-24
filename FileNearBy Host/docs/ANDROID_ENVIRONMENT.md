# Android development environment

Project credit: Leon (NguyenHuuCuongK18). Owner assignment: install Android Studio, SDKs and an emulator; emulator only. Environment preparation, not P004 Android implementation. P003 Windows shell already passed; Android source remains deferred.

Status: IN_PROGRESS, 2026-09-24.

Baseline: Windows x64, Intel i5-12450HX, about 16 GB RAM. Existing SDK: C:\Users\Leon\AppData\Local\Android\Sdk, containing platform android-37.0, Build Tools 36.0.0, platform-tools and emulator. Preserve existing packages. No registered Android Studio or AVD found. Emulator -accel-check reports WHPX installed and usable; no OS feature/BIOS changes needed.

Plan: stable Studio with bundled Java, API 36 platform, stable 36.x build tools, command-line tools, platform-tools/emulator and one Android 16 Google APIs x86_64 AVD. No app generation, standalone Gradle, NDK or account setup.

Official sources checked 2026-09-24:

- https://developer.android.com/studio — stable Studio and command-line downloads/checksums.
- https://developer.android.com/about/versions/16/setup-sdk — Android 16 uses API 36 and Build Tools 36.x.
- https://developer.android.com/studio/run/emulator-acceleration — WHPX recommended on Windows.

Checks: winget list Google.AndroidStudio found no installation; SDK folder inventory; emulator -accel-check PASS (WHPX installed/usable); -list-avds returned none. Initial sandbox hardware checks denied, approved read-only retry succeeded.

Started: winget install --id Google.AndroidStudio --exact --source winget --silent --accept-package-agreements --accept-source-agreements --disable-interactivity. Source resolved stable 2026.1.4.7; installation pending.

Next: finish installation, add missing SDK packages, create AVD and verify adb/boot. Emulator checks cannot pass real-phone hotspot/security/translation gates.
