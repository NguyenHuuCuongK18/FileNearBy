# Repository layout

All paths below are relative to the host documentation root `D:\Project\FileNearBy\FileNearBy Host`. The existing Git repository root is `D:\Project\FileNearBy`; `FileNearBy Android App/` is a pre-existing sibling left untouched. Do not create a nested `FileNearBy/` root.

Current scope (2026-09-24): Windows PC Host only; Android implementation is deferred. P003 added the WPF shell in src/FileNearBy.Host, global.json and FileNearBy.slnx at the host root. Other implementation locations remain placeholders; existing placeholders are preserved. The table retains the future responsibility map.

## Documentation and workflow

| Path | Purpose / authority |
| --- | --- |
| `README.md` | Human entry point and short launch prompt |
| `INITIALIZE.md` | P000 instructions; documentation and empty directories only |
| `AGENTS.md` | Behavior rules for coding agents |
| `docs/PROJECT_BRIEF.md` | Concise product constraints |
| `docs/REPOSITORY_LAYOUT.md` | This directory ownership map |
| `docs/ARCHITECTURE.md` | Map to relevant sections of the detailed plan |
| `docs/DECISIONS.md` | Accepted choices, open facts, and change history |
| `docs/CURRENT.md` | Short current task checkpoint; update while working |
| `docs/TASKS.md` | Status/owner/dependencies for P000 and P001-P096 |
| `docs/task-index.json` | Machine-readable task index; mirror the task board |
| `docs/tasks/P000.md` | Documentation-only preparation task |
| `docs/tasks/P001.md` through `P096.md` | Individual later implementation cards |
| `docs/INTEGRATION.md` | Actual integration state and contract compatibility |
| `docs/evidence/P000/INITIALIZATION_REPORT.md` | Structural initialization evidence only |
| `docs/evidence/Pxxx/` | Per-task redacted commands, results, and research |
| `docs/reference/file_near_by_implementation_plan.md` | Complete architecture specification, revision 1.4 |
| `docs/reference/file_near_by_session_playbook.md` | Implementation workflow, revision 1.3 |
| `prompts/initialize-session.txt` | Assign P000 to an agent |
| `prompts/start-session.txt` | Assign one later implementation card |
| `prompts/resume-session.txt` | Resume saved work |
| `prompts/checkpoint-template.txt` | Checkpoint format |
| `prompts/task-split-template.txt` | Split an oversized implementation card |
| `.gitignore` | Ignore local output/secrets; preserve documentation/source |
| `SHA256SUMS.txt` | Integrity of the distributed template; not a live repository lockfile |

## Reserved implementation locations

P000 creates these directories with empty `.gitkeep` placeholders. It does not create projects, executable source, API schemas, test code, or dependency files.

| Directory | Intended future responsibility |
| --- | --- |
| `src/FileNearBy.Host/Views/` | Future WPF views; no XAML during P000. |
| `src/FileNearBy.Host/ViewModels/` | Future presentation state and commands. |
| `src/FileNearBy.Host/Resources/Styles/` | Future WPF themes and design tokens. |
| `src/FileNearBy.Core/` | Future shared host policy, jobs, and business rules. |
| `src/FileNearBy.Api/` | Future embedded Kestrel endpoints and certificate configuration. |
| `src/FileNearBy.Windows/` | Future Windows hotspot, protected key, and handle interop. |
| `src/FileNearBy.FileEngine/` | Future authorized file operations and transfers. |
| `src/FileNearBy.MediaWorker/` | Future isolated image decoding worker. |
| `apps/android/` | Future Android Studio project; package ID remains undecided. |
| `contracts/openapi/` | Future wire protocol definitions. |
| `contracts/schemas/` | Future shared JSON schemas. |
| `contracts/fixtures/` | Future synthetic protocol samples. |
| `tests/windows/` | Future .NET tests. |
| `tests/android/` | Future cross-module Android test assets; module instrumentation stays with the app. |
| `tests/security-fixtures/` | Future synthetic adversarial filesystem/network cases. |
| `tests/end-to-end/` | Future real Windows/Android scenario runners. |
| `assets/branding/` | Future icons and branding assets. |
| `assets/design/` | Future design references. |
| `packaging/windows/` | Future installer configuration. |
| `packaging/android/` | Future APK distribution notes/configuration; private signing material stays outside Git. |
| `tools/` | Future verification tooling; no fake verify.ps1 now. |

## Module boundaries after initialization

The future FileNearBy.Host WPF application is the composition root. Views/view models delegate to core services. FileNearBy.Api exposes authenticated transport; it does not independently decide filesystem access. FileNearBy.Core owns policy, with platform and file-engine implementations behind reviewed boundaries. MediaWorker is the planned isolated decoder. Detailed dependency direction must be fixed during the relevant contract tasks; folder names are not proof of isolation.

The bundled apps/android placeholder remains reserved and deferred. Before any separately assigned Android task, reconcile its location with the existing sibling FileNearBy Android App directory and record application ID and SDK choices. P000 does not choose or migrate the future Android project location. Do not create a second Android project under src.

P003 now provides FileNearBy.slnx, global.json (SDK 10.0.400) and src/FileNearBy.Host/FileNearBy.Host.csproj (net10.0-windows, x64). App.xaml starts Views/MainWindow.xaml; ViewModels/ShellViewModel.cs manages local navigation; Resources/Styles/Shell.xaml supplies local styles. No other module project, Gradle file or Android manifest exists. Android package ID and device-specific paths remain undecided. Build/run commands are in docs/WINDOWS_SETUP.md; reusable documentation templates are in docs/templates/ and session instructions in docs/SESSION_WORKFLOW.md.

## Rules for existing repositories

Preserve existing source and working project layouts during P000. Record a layout mismatch as a proposed migration; do not move code or rewrite namespaces just to match this table. Merge documentation after reviewing differences. Resolve duplicate documentation authority explicitly, keeping current approved content and task evidence. Do not delete old files automatically.

Placeholder files may be removed once a later task adds actual files to that directory. No application build/test is expected before project creation. The bundle checksum file verifies the delivered template before edits; it will naturally become stale after normal development.
