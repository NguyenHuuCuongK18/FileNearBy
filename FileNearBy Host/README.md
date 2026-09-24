# File Near By

A Windows laptop host for private local file access, with an Android client planned later. **The Windows desktop shell now builds and opens; sharing, pairing and file operations are not implemented.**

Display name: **File Near By**. Folder/solution/namespace identifier: `FileNearBy`.

Current scope (owner instruction, 2026-09-24): **Windows PC Host only. Android implementation is deferred.** P000-P003 are complete. Existing Android placeholders and reference plans are retained for future use; they do not authorize Android work.

Project credit: **Leon (NguyenHuuCuongK18)**. See [Windows setup](docs/WINDOWS_SETUP.md) to build/run, [session workflow](docs/SESSION_WORKFLOW.md) to resume, and [CURRENT](docs/CURRENT.md) for the saved handoff.

## Begin here

1. Open `FileNearBy Host/` containing this README in VS Code. The existing Git root is its parent, `D:\Project\FileNearBy`; do not create another nested root.
2. For this initialized workspace, follow the Windows setup or current checkpoint; do not repeat P000 or regenerate the shell.
3. The initialization prompt below is retained only for preparing a new documentation bundle. Assign later work explicitly.

> Read INITIALIZE.md and AGENTS.md. Execute only P000: organize the documentation and empty project directories without generating application code, project templates, build files, or dependencies. Preserve existing work. Verify the structure, update CURRENT and the initialization report, then stop.

If merging into an existing repository, compare files first. Do not overwrite existing instructions, task statuses, or source code. Avoid nesting another FileNearBy folder inside the repository root.

## Where to find things

| Need | Read |
| --- | --- |
| Initialize the skeleton | [INITIALIZE.md](INITIALIZE.md) |
| Agent behavior and safety rules | [AGENTS.md](AGENTS.md) |
| Exact directories and ownership | [Repository layout](docs/REPOSITORY_LAYOUT.md) |
| Product purpose and constraints | [Project brief](docs/PROJECT_BRIEF.md) |
| Current work and next action | [Checkpoint](docs/CURRENT.md) |
| Accepted choices and open questions | [Decisions](docs/DECISIONS.md) |
| Task status and prerequisites | [Task board](docs/TASKS.md) |
| Detailed architecture | [Implementation plan](docs/reference/file_near_by_implementation_plan.md) |
| Small-task workflow | [Session playbook](docs/reference/file_near_by_session_playbook.md) |
| Restart after interruption | [Resume prompt](prompts/resume-session.txt) |

Use one selected task card from docs/tasks, not the entire backlog in every chat. Reference reports live only in docs/reference. Markdown is authoritative; older exported PDFs are optional historical reading.

## What comes later

Windows: C#/.NET 10 LTS, WPF/MVVM, embedded ASP.NET Core/Kestrel, SQLite, VS Code preferred. Android: Kotlin/Compose, Android Studio. Local encryption, pairing, filesystem grants, cache cleanup, and no-billing translation remain implementation/test work. Hardware capability and performance are unverified.

P000 prepares documents and directories. P001-P096 are the later implementation roadmap. Completing P000 does not mean the app builds or any product requirement has been tested.
