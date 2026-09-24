# File Near By - documentation-only initialization

This is an instruction file for a coding agent. **Execute only repository organization and documentation setup. Do not implement the application.**

## 1. Assignment

Prepare a clear, recoverable repository skeleton for **File Near By**. Display name: `File Near By`. Folder, solution, and namespace identifier: `FileNearBy`. Windows application identifier: `FileNearBy.Host`. The Android package/application ID is not decided; do not invent an owner domain.

The planned stack is C#/.NET 10 LTS, WPF/MVVM, and embedded ASP.NET Core/Kestrel for Windows; Kotlin/Compose in Android Studio for Android. VS Code is the preferred Windows editor. These describe later implementation, not work to perform now.

Success means folders, Markdown instructions, placeholder files, and truthful task state are ready. Success does not mean a buildable app exists.

## 2. Read in this order

1. This file, then `AGENTS.md`.
2. `docs/PROJECT_BRIEF.md` and `docs/DECISIONS.md`.
3. `docs/REPOSITORY_LAYOUT.md` and `docs/CURRENT.md`.
4. `docs/tasks/P000.md` and the task board.
5. Relevant reference sections only if a conflict needs resolving.

Do not load all 96 implementation cards or both full reports into the conversation. Markdown is the source of implementation instructions; no PDF is required.

## 3. Scope boundary

Allowed in this task:

- Read-only inspection of the selected destination and Git status.
- Creation of missing directories, empty `.gitkeep` placeholders, Markdown documents, task-index JSON metadata, and the supplied `.gitignore`.
- Careful merging of supplied documentation into existing documents after reviewing differences.
- Recording actual environment facts if easily available through read-only checks; otherwise record `NOT_CHECKED`.
- Documentation/link/structure verification and a saved checkpoint.

Do not create or change any of the following in this task:

- C#, Kotlin, Java, XAML, Python, shell, or PowerShell application/helper source files.
- `.csproj`, `.sln`, `.slnx`, `global.json`, Gradle files, Android manifests, SDK locks, or generated project templates.
- Starter windows, hello-world screens, mock APIs, services, networking, authentication, databases, translation engines, or executable tests.
- Build/debug tasks, CI workflows, installers, signing keys, certificates, API keys, or dependency declarations.
- Package installations, SDK installations, dependency restores, model downloads, account creation, billing setup, or remote repository creation/pushes.

Do not run `dotnet new`, Android Studio's New Project wizard, `gradle init`, or any other application generator. Those commands create runnable scaffolding and belong to later implementation tasks.

Do not delete existing code to satisfy the no-code requirement. If code already exists, preserve it and report it as pre-existing; the requirement is that this task introduces no application code.

## 4. Destination and existing-work check

Use the workspace the user has selected. If it is an empty intended repository root, put the skeleton directly there. If it is only a general projects directory, use a single `FileNearBy` child directory. If the destination is genuinely ambiguous, ask before writing; do not initialize inside an unrelated repository.

The bundle already has a top-level `FileNearBy/` directory. Do not create `FileNearBy/FileNearBy/` accidentally. Open the inner directory that contains README.md, INITIALIZE.md, and AGENTS.md as the repository root.

Before writing:

- Record the absolute destination and whether it already contains project files or a Git repository.
- If Git exists, record branch, HEAD, status, and relevant diffs. Do not reset, clean, stash, stage, commit, switch branches, or alter remotes as part of initialization.
- If Git does not exist, write `Git: not initialized`. Creating version-control history is a separate choice; no remote is needed.
- Preserve existing AGENTS.md instructions, user edits, credentials, and unrelated files. Never blindly overwrite a matching filename.
- In a populated repository, inventory file paths and hashes where practical before changes so unchanged existing application files can be verified afterward.

Write a short starting checkpoint before the first edit. Keep the inspection scoped to this destination; do not search the entire laptop or read private file contents unnecessarily.

## 5. Apply the skeleton in four small steps

### P000a - Inventory

Inspect the destination and existing documentation. Record conflicts and existing source files without changing them. Save the planned next single action in CURRENT.

### P000b - Place documentation

Use the matching files supplied in this bundle. README is the human entry point, INITIALIZE is this task, and AGENTS defines ongoing agent behavior. Place reference reports only under `docs/reference/`; do not scatter duplicate copies at the root.

Use the exact paths in `docs/REPOSITORY_LAYOUT.md`. Merge existing task histories; never reset a completed card merely because the bundled template starts as NOT_STARTED. Preserve all stable P001-P096 IDs. P000 is an added preparation task, not a renumbering of the implementation roadmap.

If the full bundle is unavailable, create only the minimal documents whose content is established here: product name, stack, directory map, checkpoint, and initialization record. Mark missing specification/task sources as BLOCKED and request those files. Do not fabricate the detailed reports or claim the full handoff was installed.

### P000c - Reserve directories

Create the missing implementation directories listed in the layout document. Add empty `.gitkeep` files only to otherwise empty leaf directories. They are placeholders, not source files or tests. Do not generate projects merely to make a folder visible in an IDE.

Use the supplied `.gitignore` for a new repository. In an existing repository, merge only justified missing patterns and preserve existing exceptions. Do not ignore task documentation, contracts, future source files, or test fixtures.

### P000d - Verify and hand off

Check structure and documentation only. Save exact checks and observed results in `docs/evidence/P000/INITIALIZATION_REPORT.md`. Do not run a build or mark application tests successful when no projects exist.

Stop after this step. List P001 as a possible next task, but do not begin P001 or generate the Windows/Android shell without a later implementation assignment.

## 6. Required state documents

Use the supplied templates and fill only observed facts:

| File | Required result |
| --- | --- |
| `docs/CURRENT.md` | P000 state, destination, existing Git state, changed files, observed checks, blockers, next action |
| `docs/DECISIONS.md` | Display name, code identifier, current stack, no-code initialization boundary, unresolved hardware/sample/default decisions |
| `docs/TASKS.md` | P000 entry before existing P001-P096; no invented implementation completion |
| `docs/task-index.json` | Same IDs/dependencies/statuses as task board if present; retain existing history |
| `docs/INTEGRATION.md` | No integration has been verified by this task; preserve any previously evidenced results |
| `docs/evidence/P000/INITIALIZATION_REPORT.md` | Inventory, created/merged paths, checks, unchanged existing source, unresolved conflicts |

Document product limits accurately: local file features must work offline; laptop-side grants are authoritative; one paired phone initially; viewing is temporary; permanent transfers are explicit; no required billing/card service. The local translation trial and external Google image translation fallback remain future work. Do not assert hardware compatibility or translation quality.

## 7. Completion checklist

Mark P000 PASS only after checking all applicable items:

- One clearly identified repository root, with no accidental nested duplicate root.
- Display name is File Near By and code identifiers are FileNearBy in current instructions.
- Root entry points exist and link to the correct documents.
- Required reference files and P001-P096 cards are available, or P000 remains BLOCKED with an explicit missing-file list.
- Reserved directories match REPOSITORY_LAYOUT; empty placeholders contain no executable code.
- This task added no application source, project/build configuration, dependencies, credentials, or runnable examples.
- Existing application files and unrelated changes were preserved; any documentation conflicts are resolved or recorded as blocking.
- Task board/index agree, with no false PASS for implementation tasks.
- Application build, hardware, security, and translation tests are recorded as NOT_RUN by this task.
- CURRENT and INITIALIZATION_REPORT contain actual results and one next action.

If a check fails, record IN_PROGRESS or BLOCKED and the exact remedy. Do not weaken the checklist to obtain PASS. An interrupted session resumes from CURRENT and the evidence file; it does not restart the repository.

## 8. Final agent response

Report the destination, created/merged documentation, reserved folders, actual structural checks, any pre-existing code, and unresolved issues. State explicitly: "Documentation-only initialization; no application code generated." Give the checkpoint path and stop.
