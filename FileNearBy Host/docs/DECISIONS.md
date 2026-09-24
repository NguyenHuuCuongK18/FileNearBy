# Decision register

## Confirmed from the owner

- 2026-09-24, owner: current scope is Windows PC Host only; Android implementation is deferred. Complete only P000 documentation and empty folder setup, preserve existing files, verify, and stop. This supersedes broader current-scope wording in the bundled instructions; the long-term product plan is retained. Affected: P000 and future selection of P001-P096. Android and cross-device cards remain unstarted; their dependencies are not waived. No alternative scope was approved. A later P001 assignment should reconcile the host-only roadmap before implementation.

- Display name: File Near By. Code/folder identifier: FileNearBy.
- P000 assignment (completed): documentation and empty directories only; no application code or project generation. P001 is the separately assigned brief/decision-record task, also documentation only.
- Windows 11 and Android 16 initially; native Android preferred.
- Current Windows baseline from setup discussion: C#/.NET + WPF, embedded Kestrel; VS Code preferred. Android remains Kotlin/Compose.
- Direct laptop hotspot preferred, local file features offline.
- One phone initially; future multiple-device plan required.
- Allowed-directory enforcement; viewing temporary, transfers explicit.
- Clear/bound temporary caches.
- Normal Windows installer accepted; Docker can be omitted.
- English target by default; automatic source language with manual override.
- No required billing or payment cards; lightweight local translation now authorized.
- If unsuitable, external Google image translation is the authorized reduced scope.

## Unresolved - do not assume answers

- G1: laptop/adapter/driver/Windows build and offline topology evidence remain unknown. Owner confirmed x64 and accepts USB Wi-Fi or phone-hosted hotspot fallback during P001; see dated decision below.
- G2: measured ML Kit quality, device footprint, model preparation, SDK privacy; local or external route disposition. Billing is rejected, not an open question.
- G3: representative source scripts and OCR samples.
- G4: reviewed Windows handle-containment strategy and supported filesystems.
- G5: proposed cache budgets, delete recovery, broad-root exclusions, startup/background defaults, format scope.

## Proposed, not validated

- The older report describes framework selection as a proposal; current AGENTS.md and report Section 22 establish C#/.NET 10 LTS + WPF/MVVM + embedded Kestrel as the host baseline, with SQLite local state. Exact versions/installability are unverified. Kotlin/Compose and translation remain deferred Android work. QR + mTLS is the specified security direction; detailed implementation and independent review remain pending.
- ML Kit OCR/language-ID/Translation trial. If unsuitable, manual Google image translation; no Cloud/Azure API setup.
- Local builds and ADB testing, locally generated APK signing key; no paid Windows publisher certificate required for private development.

For each future decision, record date, owner, exact question, answer, alternatives considered, and affected cards/contracts. Never backfill a guessed approval.

## P001 scope and precedence — 2026-09-24

Owner instruction: continue with P001. This authorizes the requirements/decision-record task, not P002 or application generation. The previous Windows-PC-Host-only scope remains in force; Android is deferred. The dated P000-only instruction above is historical and was fulfilled.

The current brief separates confirmed behavior, the recorded host stack, proposed defaults and unverified evidence. Owner subsequently confirmed x64 and accepted USB Wi-Fi/phone-hosted hotspot alternatives; no particular adapter or working topology has been selected. Stack migration, different retention limits and cloud fallback have not been approved.

### Owner G1 decision — 2026-09-24

Question: target architecture and acceptable alternatives if the laptop hotspot is unsupported. Answer: Windows x64; a USB Wi-Fi adapter and/or phone-hosted hotspot is acceptable, provided a connection can be made between laptop and phone without relying on Bluetooth pairing. Owner supplied this answer during P001. Prefer the laptop-created hotspot as previously recorded, but permit either accepted alternative. No Bluetooth solution, hardware purchase, Android application implementation or internet dependency is authorized by this answer. Phone-hosted hotspot is a transport alternative; Android implementation remains deferred.

Affected: G1, architecture/packaging baseline, P007-P014 connectivity planning and P088/P093 acceptance. Supplied cards describe the preferred laptop AP route. Before executing an alternative, document its route-specific setup/pass gate and preserve offline requirements; do not report a laptop-AP-specific gate as passed from phone-hotspot evidence. Exact laptop/adapter/driver/Windows build and feasibility remain unknown. No hardware test performed.

Affected cards: P001 records the baseline; P002 then P003 are possible host-side follow-ups. P004 is deferred. P005/P006 still require P004 under the supplied dependency graph, and dependent host cards cannot silently bypass it. A separately assigned split/reconciliation must define host-only pass gates before that work; retain original task IDs and cross-device acceptance. No task dependency/status is waived to make the roadmap appear ready.

## P001 gate register

BLOCKED means required facts, decisions or evidence remain missing; it is not a claim that the P001 documentation itself cannot finish. Role names below assign responsibility, not a claim that a specific engineer/reviewer has been engaged.

| Gate | State and exact unanswered question | Decision/evidence owner | Evidence needed and affected work |
| --- | --- | --- | --- |
| G1 — offline hotspot | BLOCKED (evidence): x64 confirmed; USB Wi-Fi or phone-hotspot accepted. What laptop/Wi-Fi adapter, driver and Windows build are targeted? Which accepted topology works without internet/upstream router? For laptop AP, can it start with upstream Wi-Fi disconnected and Ethernet unplugged? | Owner identifies target; Windows engineer measures capability and documents topology. | P007 inventory, P008/P009 hardware/offline evidence or explicitly scoped alternative gate. Architecture resolved; compatibility claims pending. No capability inferred from development environment. |
| G2 — translation route | BLOCKED (Android deferred): Which target phone/RAM and quality/footprint criteria apply? Does the small local trial meet no-billing, privacy, offline model, resource and quality requirements? | Owner + future Android engineer. | P077-P080 measurements and local/external disposition. Authorized manual Google fallback remains available if trial unsuitable; billing is rejected, not an open decision. |
| G3 — OCR samples | BLOCKED (Android deferred): Which scripts/languages and representative image samples define required coverage? | Owner supplies representative samples; future Android engineer evaluates them. | P074 and subsequent OCR/translation evidence. No source language or universal coverage assumption; no private samples requested for this host task. |
| G4 — filesystem security | BLOCKED: Which filesystems/volume types are supported, and what reviewed handle strategy safely handles containment, concurrent replacement, reparse points, hard links and namespace aliases? | Windows engineer designs; independent security reviewer evaluates; owner agrees supported scope. | Design plus adversarial evidence from P031-P033/P092 and related name/operation gates. Exact strategy remains unverified; no production write-safety claim. |
| G5 — product defaults | BLOCKED: Approve or amend the host defaults below, including exclusions, formats, resource budgets, recovery and startup behavior. | Product owner; Windows engineer supplies feasibility/measurement evidence. | Record decisions before dependent cache/recovery/grant/UI/package behavior is committed. Host-related P003, P022, P029, P038-P039, P044, P047-P048, P061-P063, P084-P088 and acceptance work as applicable; exact card gate still governs. |

G1 architecture/fallback clarification was received and recorded above; remaining hardware evidence is BLOCKED. G2/G3 questions are saved for the deferred Android phase. No answer for G5 defaults recorded; silence is not approval.

## P001 G5 proposed host defaults

All rows below are **PROPOSED / BLOCKED pending owner decision**, not accepted configuration. Values come from report Sections 8-10, 19.3 and 22; no new numerical defaults are introduced here.

| Decision question | Report proposal | Remaining evidence/choice |
| --- | --- | --- |
| Startup/window close | Manual sharing start; optional tray continuation after clear user choice; no unattended elevated service. | Approve startup/close/background semantics. |
| New root access | Read-only until owner enables writes. | Approve initial capability set. |
| Broad roots/exclusions | Explicit local roots; exclude app keys/identity, journals, staging and recovery metadata; do not automatically expose new drives. | Confirm supported roots and visible exclusions; G4 still governs safe access. |
| Reparse/cloud/hard links | Do not traverse symlinks/junctions/mount reparse points/cloud placeholders; reject multiply linked content/mutation until reviewed. | Confirm conservative behavior and unsupported-entry presentation; no unexpected cloud hydration. |
| Enrollment duration | QR + host approval; two-minute enrollment window. | Confirm timeout/renewal UX; review trust design separately. |
| Host previews | Memory only, 256 MiB cap, LRU eviction, clear on sharing stop; separately measured worker limit. | Approve budget and measure full decoded/in-flight resources; worker numerical cap is unspecified. |
| Delete recovery | Seven days / 5 GiB per shared volume; no silent permanent fallback; local restore/purge controls. | Approve limits and explicit behavior when recovery is unavailable/full. |
| Transfer staging | Visible quota; expire abandoned transfers after 24 hours. | Approve expiry; numerical quota remains unspecified. |
| Operation audit | 30 days or 20 MiB, redacted metadata. | Approve limits/retention behavior; no filenames/content/secrets in shared diagnostics. |
| Transfer scheduling | 4 MiB chunks, one active large transfer. | Approve initial tuning subject to measurements. |
| Conflicts | Ask; offer Skip, Keep both or explicit Replace with recovery where possible. | Approve conflict UX; silent overwrite remains prohibited. |
| Image preview formats | JPEG, PNG, WebP, GIF; animation only with verified decoder support. | Confirm mandatory formats; HEIF/HEIC, AVIF, TIFF, RAW, SVG, archives, PDF/video need separate decisions. |
| Performance | Idle desktop process tree under 200 MiB; first directory page p95 under 500 ms; transfer at least 70% of encrypted sequential-copy baseline; stop/revoke target under one second. | Approve targets and measurement conditions from Section 19.3. These are not measured results; deferred phone metrics stay deferred. |

Host baseline stack selection is already recorded; this register does not reopen it as an unanswered default. Android cache budgets, model footprints and OCR/translation acceptance stay with G2/G3 and the future Android scope.

Installer target architecture: **x64 CONFIRMED** by the P001 owner answer, removed from unresolved G5 defaults. Packaging compatibility still requires P088 evidence.


## P002/P003 assignment and credits — 2026-09-24

Owner explicitly assigned P002 then P003 and requested all project credits use Leon (NguyenHuuCuongK18). Existing assistant credits and root LICENSE attribution corrected; unassigned future owners remain unassigned. AGENTS.md now tells future sessions to use the current user's verified hosting login when available, with an explicitly labeled local Git-author fallback, never an assistant default. Current display identity is owner-supplied; local Git author NGUYEN HUU CUONG observed; no remote login verification or Git configuration change.

P002 recovery workflow/templates and repository-only rehearsal passed. P003 uses observed installed SDK 10.0.400 pinned exactly, WPF/MVVM net10.0-windows/x64 with no third-party packages or services. Build/open/navigation pass does not approve G5 defaults or G1/G4 feasibility. An isolated source-only build checks reproducibility without committing existing untracked work. User stopped Computer Use before final close verification; UI automation stopped immediately. P004 remains deferred; reconcile/split P005/P006 before further host implementation.
