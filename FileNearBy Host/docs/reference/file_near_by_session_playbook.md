# File Near By: Session Playbook

## Small, testable phases for AI-assisted implementation

**Revision:** 1.3 - 24 September 2026  
**Companion:** file_near_by_implementation_plan.md, revision 1.4.  
**Preparation:** First complete root INITIALIZE.md / P000 for documentation and empty directories only. It does not generate .NET or Android projects or pass any implementation card. P001-P096 remain later work; no renumbering is required.

**Agent use:** This Markdown file is the executable work queue reference. Read one selected card and relevant specification sections. Earlier PDFs are historical human snapshots, not current agent instructions.

**Status:** implementation instructions and task templates, not implemented or executed software. Bundled task statuses are templates; inspect actual repository history before assigning or changing them. Hardware, translation feasibility, and owner decisions remain explicit gates.

This playbook divides the project into **96 initial task cards**. A card has one narrow outcome, named prerequisites, a limited work area, a concrete pass gate, and a durable checkpoint. Most cards are designed for a focused coding attempt rather than a whole feature. Difficult cards must be split further when their actual complexity becomes visible.

No chatbot rate limit or context window is predictable from elapsed time alone. A 10-20 minute work slice is a scope target, not a promise that a model can finish before throttling. The reliable property is that work can stop after any checkpoint and restart from files, tests, and Git state. One task may span several attempts; a failed test or unresolved security question must not be hidden to keep the schedule.

## 1. Working agreement for one person and one chatbot

### 1.1 Task size and stop rules

Start one ready card at a time. Aim for one observable behavior and one associated test or small test group. Usually touch one module and no more than three to six existing implementation files, excluding generated files. These are scope indicators, not limits that justify awkward design. If a card needs simultaneous network, UI, storage, and authentication changes, split it at an interface first.

Before any edits, write CURRENT with the starting state, next single action, and exact pass gate. Use 10-20 minute work slices: one edit or experiment, its focused verification, then a durable handoff. Update CURRENT after each meaningful result and before another long investigation; use about 5-10 minutes as a checkpoint reminder, not a guaranteed safe interval. Never wait for a rate-limit warning or rely on the final chat reply to save context. A card can take several slices.

After two failed attempts at the same diagnosis, stop making speculative changes. Write the smallest reproduction, exact failure, hypotheses already eliminated, and the next discriminating experiment. Create a bounded investigation child card. Security uncertainty is a reason to investigate or request expert review, never to disable verification or access checks.

Split rules: P031 becomes P031a, P031b, and so on if its handle-resolution strategy exceeds one session. Keep P031 in SPLIT status until every mandatory child passes. Downstream dependencies still refer to P031 and cannot proceed early. Each child inherits the parent invariant and has its own pass gate. Use the same rule for any other oversized card.

### 1.1a Recovery from an abrupt limit

Each slice starts with a checkpoint before implementation, so a stop halfway through still leaves an intended action. Persist research URLs and one-sentence findings as they are found; never leave the only copy in a tool transcript. After editing, record changed paths before running a potentially long build. After testing, save the command, exit code, and evidence path before starting another task.

Keep CURRENT short (preferably under 500 words). Append detailed experiments to evidence/Pxxx/WORKLOG.md with timestamps, not to an ever-growing conversation. Save one discriminating next action, not a list of vague possibilities. An interrupted session must be recoverable from CURRENT, Git state, the selected card, and the last evidence entry alone. P006 verifies this by starting a fresh chat with only that packet and asking it to identify the pending action without repeating completed work.

No architecture or task-sizing rule can prevent account rate limiting. The goal is bounded lost work and safe continuation. If blocked during an edit, mark that edit incomplete; do not infer that a tool finished from an assistant's intention.

### 1.2 Status and completion

Allowed statuses: NOT_STARTED, READY, IN_PROGRESS, BLOCKED, SPLIT, PASS, NOT_APPLICABLE, and REOPENED. READY means prerequisites and required decisions are satisfied. PASS requires the scoped behavior, real gate evidence, updated checkpoint, and reviewed diff. A mock-only pass never substitutes for an explicitly required real-device or live-provider pass.

A rate limit leaves a task IN_PROGRESS or BLOCKED; it does not make it PASS. The human saves the current worktree immediately if the agent cannot respond. If there is no buildable checkpoint, keep the unfinished changes on a clearly labeled local WIP branch with the known errors recorded. Never merge broken work just to preserve it. Never discard unrelated changes or force-push someone else's work.

### 1.3 Independent work without shared-state collisions

The cards are in a safe reading order, not a requirement for one person to do everything serially. Windows and Android contributors may work on ready cards in separate branches/worktrees once their shared contract is fixed. The table's Depends field is authoritative; do not infer readiness from the card number alone. Reserve ownership of a contract or schema change before editing it.

A task blocked by hardware or provider access can be left blocked while unrelated mock/UI work continues. Do not replace the owner's chosen transport, enable a paid account, introduce an unapproved engine, or change the confidentiality model to unblock a demo.

## 2. Durable context kept in the repository

| File or folder | Content / update rule |
| --- | --- |
| docs/PROJECT_BRIEF.md | One page: product purpose, confirmed requirements, exclusions, owners. Update when a decision changes. |
| docs/ARCHITECTURE.md | Component boundaries, security invariants, links to authoritative specifications. Summarize; do not paste an entire chat. |
| docs/DECISIONS.md | Accepted, rejected, and unresolved decisions with date and owner. No invented approval. |
| docs/TASKS.md | Card status, owner, dependencies, child cards, evidence location, review status. |
| docs/CURRENT.md | Small current-session handoff: exact next task and current state. Replace stale content each checkpoint. |
| docs/tasks/Pxxx.md | Selected card, any approved clarifications, fixtures, gate names, scope boundaries. |
| docs/evidence/Pxxx/ | Redacted test summaries, screenshots, device metadata, reproducible commands. Large/private captures stay outside Git. |
| docs/INTEGRATION.md | API/schema version, consumer/provider compatibility, pending integration changes. |
| contracts/ | Machine-readable protocol and fixtures used by both apps. |
| AGENTS.md | Concise contributor instructions if the chosen assistant supports this convention; otherwise attach the same rules manually. |

Persistent does not mean put everything in Git. Keep private keys, provider credentials, raw personal images, OCR text, and packet captures containing personal content out of shared context. Store generated test data and redacted evidence. Record secret references and setup instructions, not secret values.

The boot packet for a new conversation should be roughly 1,000-2,000 words plus the selected code files. It contains PROJECT_BRIEF, CURRENT, the selected task, applicable decisions, and the relevant contract excerpt. Add other files only when the task needs them. The full architecture report remains a reference rather than a mandatory paste on every session.

## 3. Copyable session prompts and checkpoint templates

### 3.1 Start a fresh implementation session

```text
Work only on task <Pxxx> in this repository.
Read PROJECT_BRIEF, CURRENT, the task card, applicable DECISIONS,
and the smallest relevant contract/code files.
First inspect Git status and verify the recorded starting commit.
Do not overwrite unrelated work.
Restate the one outcome and the exact pass gate in a short paragraph.
If a required fact or approval is missing, mark that dependency blocked.
Implement the smallest complete change for this card.
Run the card's tests plus only directly affected regression checks.
Write CURRENT before editing; update it after each edit/test/experiment.
Persist research and evidence now, not only at the final response.
Save a checkpoint even if tests fail.
Do not implement the next card or broaden the task to fix unrelated issues.
Finish with changed files, real test results, remaining issues,
the current commit/worktree state, and the next exact action.
```

### 3.2 CURRENT.md template

```text
Task: Pxxx / title
Status: IN_PROGRESS | BLOCKED | PASS
Owner:
Branch:
Last known-good commit:
Current HEAD:
Uncommitted changes / saved patch location:
Environment: Windows build, adapter/driver, Android device, toolchain
Goal and invariant:
Changed files and why:
Last exact test command:
Observed result: exit code + concise failure/success summary
Evidence path:
What is unfinished:
Known blockers and who must decide:
Hypotheses already tried and rejected:
Next single action:
Rollback or recovery steps:
Files to read next:
```

### 3.3 Restart after the chatbot stops

```text
Resume task <Pxxx> using repository state as the source of truth.
The previous chatbot session stopped; do not assume it finished.
Read CURRENT and the task card, then inspect Git status and diff.
Verify the last recorded result with the smallest relevant test.
Continue from 'Next single action'.
Do not regenerate the project, repeat completed setup,
change the architecture, or mark unrun tests as passing.
```

### 3.4 Manual rescue when no AI response is available

Save editor buffers. Record Git status and the current commit. Save the current diff or a local WIP commit after reviewing it for secrets and unrelated files; an uncommitted worktree alone is not a portable checkpoint. Write the failing command and the last known-good state into CURRENT by hand. Record untracked files explicitly because a plain Git diff does not contain them. The next session receives this packet instead of relying on the previous chat transcript.

### 3.5 Task-card template for further splits

```text
ID / title:
Parent task:
Depends on:
Required owner decisions:
Read these files:
Allowed work area:
One behavior to implement:
Out of scope for this card:
Input fixture / reproduction:
Pass gate and expected observable result:
Evidence to save:
Stop / split trigger:
```

## 4. Test harness contract and safety rules

P006 creates a task-verification wrapper. Later cards extend its registry as their gates are implemented. The following commands are proposed project commands, not commands that exist in this deliverable:

```powershell
pwsh -File tools/verify.ps1 -Task P031 -Mode Fast
pwsh -File tools/verify.ps1 -Task P009 -Mode Device
pwsh -File tools/verify.ps1 -Task P077 -Mode Review
```

Fast maps to concrete C#, Kotlin, schema, or UI tests. Device requires the named real devices and writes build/device identifiers with results. Review checks that a human decision/review record exists and that required evidence fields are complete; it cannot automatically assert a human judgment. Unknown or unimplemented gates must return NOT_IMPLEMENTED and a nonzero result. A skipped device test cannot pass a device card.

Each gate records the command, exit status, time, commit, environment, and observed result under docs/evidence/Pxxx. The gate names in the cards specify what to register; P006 does not implement the future tests prematurely. Examples of underlying commands are cargo test, the project's Android Gradle test task, and an instrumentation test against a selected device. Pin the exact commands to the repository's actual module names in P006.

Use disposable fixture directories and synthetic test files for all destructive and adversarial tests. Early network spikes may expose only a fixed synthetic sentinel in an isolated test harness, never real file access or a public listener. A temporary plain transport probe is removed before integration; production file APIs start only after mTLS and authorization gates pass.

Test scope follows risk. Pure UI spacing does not need a new unit test. Permission changes need hostile-client tests. A release test matrix is spread across several cards; do not rerun every expensive suite after every cosmetic change. Never use trust-all TLS, disable the firewall, or bypass provider limits as a debugging shortcut.

## 5. Milestones and how to choose the next card

| Milestone | Cards | Observable result |
| --- | --- | --- |
| A - Reproducible baseline | P001-P006 | Both shells build; context and test harness exist |
| B - Actual local connectivity | P007-P014 | Offline laptop AP and Android routing demonstrated |
| C - Device trust | P015-P027 | QR enrollment, mTLS, revocation, renewal |
| D - Read-only shared folders | P028-P038 | Authenticated browsing inside verified roots |
| E - Safe remote edits | P039-P048 | Journaled, scoped file operations and recovery |
| F - Explicit transfers | P049-P060 | Verified uploads/downloads with interruption recovery |
| G - Gallery and cache lifecycle | P061-P071 | Bounded previews, tiles, viewer, cache evidence |
| H - OCR and no-billing translation | P072-P083 | Local overlays or documented external workflow |
| I - Product and installation | P084-P090 | Coherent controls, permission flows, offline packages |
| J - Release evidence | P091-P096 | Independent tests, owner decisions, handoff |

The first useful integrated demonstration is B + C + D: pair a real phone over the offline hotspot and list a disposable approved folder. Milestone A alone is not a secure file-sharing app. Overlay geometry can use fake text while local translation is evaluated. The authorized external route can replace built-in translation if the local trial fails.

Gates inherited from the architecture report: G1 actual adapter compatibility; G2 no-billing local/external translation acceptance; G3 representative OCR scripts; G4 filesystem containment; G5 owner approval of proposed defaults. P009 supplies G1 evidence; P077-P080 produce G2 evidence; P074 contributes G3 evidence; P033 and P092 contribute G4; P001 records G5 decisions. A result on one adapter does not establish universal hardware support.

Every card inherits the common checkpoint template. Its Checkpoint line names the additional evidence needed to avoid repeating investigation. The default next action is the next READY card whose prerequisites passed, not simply the next number. The listed work areas are module boundaries; they are not permission to edit unrelated files.

## 6. Milestone A - Reproducible baseline

### P001 - Freeze the implementation brief

**Depends:** None. **Work area:** docs/.

**Implement:** Extract confirmed requirements and unresolved decisions from report 1.4; record G1-G5 without inventing answers.

**Pass gate:** Review: owner can identify confirmed versus proposed behavior; unknown hardware/sample facts are BLOCKED.

**Checkpoint:** Save the approved brief or the exact unanswered questions and decision owner.

### P002 - Create restartable session state

**Depends:** P001. **Work area:** docs/, contributor instructions.

**Implement:** Create CURRENT, TASKS, task-card and evidence templates; write concise assistant instructions.

**Pass gate:** Review: a person with no chat history can name the next task, invariant, and starting state.

**Checkpoint:** Save a sample stopped-session handoff and a completed resume rehearsal.

### P003 - Build the Windows shell

**Depends:** P002. **Work area:** src/FileNearBy.Host/.

**Implement:** Inspect any existing WPF shell first; create or adapt FileNearBy.Host using C#/.NET 10 LTS, WPF/MVVM and local assets. Pin the SDK; document VS Code CLI commands. Do not recreate existing work.

**Pass gate:** Fast: clean checkout builds and opens the shell; no network service or real file access.

**Checkpoint:** Record exact setup/build/run commands and Windows architecture.

### P004 - Build the Android shell

**Depends:** P002. **Work area:** apps/android/.

**Implement:** Create a Kotlin/Compose app with one connection screen and pinned Gradle dependencies.

**Pass gate:** Device: install and launch on Android 16; screen rotation does not crash.

**Checkpoint:** Record Android device/build and exact Gradle/install commands.

### P005 - Define the minimum shared protocol

**Depends:** P003,P004. **Work area:** contracts/.

**Implement:** Specify session, root, item, error, and 64-bit size representations with synthetic fixtures.

**Pass gate:** Fast: both languages parse the same success/error fixtures without integer truncation.

**Checkpoint:** Save schema version and generated-type policy; no full endpoint implementation.

### P006 - Implement task verification dispatch

**Depends:** P003,P004,P005. **Work area:** tools/, test configuration.

**Implement:** Add verify.ps1 and a registry mapping task/mode to real commands; record evidence metadata.

**Pass gate:** Fast: known sample gate executes; unknown gate and skipped device gate fail explicitly.

**Checkpoint:** Save wrapper usage and the first evidence manifest; rehearse resuming in a fresh chat using only CURRENT, the card, Git state, and evidence.

## 7. Milestone B - Actual local connectivity

### P007 - Inventory the actual wireless hardware

**Depends:** P003,P006. **Work area:** Windows diagnostics spike.

**Implement:** Read adapter, driver, OS build, CPU architecture, and capability information without changing networking.

**Pass gate:** Device: actual values are reported; absent/unsupported hardware has a typed diagnostic.

**Checkpoint:** Save redacted hardware matrix; block device-dependent work if hardware is unavailable.

### P008 - Start and stop one test access point

**Depends:** P007. **Work area:** Windows hotspot wrapper.

**Implement:** Create and retain a Wi-Fi Direct legacy AP publisher with random test credentials; implement stop.

**Pass gate:** Device: SSID appears, a client can associate, and Stop removes it without leaked publisher state.

**Checkpoint:** Save lifecycle events and one reproducible start/stop command.

### P009 - Prove operation with no upstream network

**Depends:** P008. **Work area:** Hotspot device test.

**Implement:** Run the AP with Ethernet unplugged and upstream Wi-Fi disconnected; exchange only a synthetic sentinel.

**Pass gate:** Device: phone/laptop exchange sentinel with phone mobile data disabled and no router; otherwise G1 fails.

**Checkpoint:** Save the actual setup, device facts, and outcome; no guessed fallback transport.

### P010 - Resolve the host endpoint dynamically

**Depends:** P008,P005. **Work area:** Windows network adapter.

**Implement:** Map the AP session to its current interface/address and expose a typed endpoint object.

**Pass gate:** Device: no hard-coded subnet; restart/interface change refreshes the endpoint and retires stale state.

**Checkpoint:** Save observed address-change cases and endpoint fixture.

### P011 - Join the hotspot from Android

**Depends:** P004,P009,P010. **Work area:** Android connection module.

**Implement:** Use the system-mediated local Wi-Fi join request and retain the resulting Network object.

**Pass gate:** Device: user approval, denial, and cancellation produce distinct states; no internet capability is required.

**Checkpoint:** Save permission/prompt behavior on the actual phone.

### P012 - Bind one local client to that network

**Depends:** P011. **Work area:** Android networking.

**Implement:** Create a dedicated socket/DNS path for the local sentinel client; release it on network loss.

**Pass gate:** Device: sentinel still works while phone internet preference changes; old Network sockets fail safely.

**Checkpoint:** Save connection-pool ownership and disconnect reproduction.

### P013 - Separate internet and local clients

**Depends:** P012. **Work area:** Android networking tests.

**Implement:** Add an independent internet client and route test using non-private data only.

**Pass gate:** Device: local sentinel remains reachable while an allowed internet request succeeds or reports no internet honestly.

**Checkpoint:** Save cellular/hotspot coexistence results; do not assume every phone supports them.

### P014 - Handle one hotspot interruption at a time

**Depends:** P010,P012. **Work area:** Hotspot state machine.

**Implement:** Add typed AP-start conflict, radio-loss, and stop transitions; use one fixture per condition.

**Pass gate:** Device: each tested interruption stops stale serving and offers a recoverable state without competing hotspot loops.

**Checkpoint:** Save the tested error codes; split untested sleep/wake variants into child cards.

## 8. Milestone C - Device trust

### P015 - Persist the host identity securely

**Depends:** P003,P006. **Work area:** Host identity store.

**Implement:** Generate a local CA/server identity and protect private storage under the current Windows user.

**Pass gate:** Fast/Device: restart retains identity; another test user cannot read protected private bytes.

**Checkpoint:** Save storage paths as redacted references and key-reset behavior; never key values.

### P016 - Generate the phone's device key

**Depends:** P004,P006. **Work area:** Android identity module.

**Implement:** Generate a P-256 signing key in Android Keystore and report its actual protection level.

**Pass gate:** Device: sign/verify succeeds after restart; private-key export is unavailable through the app path.

**Checkpoint:** Save the key alias contract and hardware support result.

### P017 - Serve a TLS sentinel with host identity

**Depends:** P015,P010. **Work area:** Host TLS listener.

**Implement:** Replace the network spike with a TLS 1.3 sentinel and stable logical host identity; disable early data.

**Pass gate:** Fast/Device: supported TLS works; plaintext and obsolete-protocol attempts cannot read the sentinel.

**Checkpoint:** Save TLS test configuration and selected library versions.

### P018 - Verify the host pin on Android

**Depends:** P017,P012. **Work area:** Android TLS client.

**Implement:** Use a development-distributed exact trust anchor and logical hostname for the sentinel; no trust-all verifier.

**Pass gate:** Device: correct identity works; wrong key, wrong host name, and changed identity fail before credential submission.

**Checkpoint:** Save pin/hostname fixtures and trust-verifier review notes.

### P019 - Create and validate a device CSR

**Depends:** P015,P016. **Work area:** Enrollment crypto module.

**Implement:** Generate a phone CSR and validate signature/proof of possession on the host using standard libraries.

**Pass gate:** Fast/Device: valid CSR accepted by the test issuer; altered CSR or unsupported key rejected.

**Checkpoint:** Save public-only CSR fixtures and precise issuer validation rules.

### P020 - Require a registered client certificate

**Depends:** P018,P019. **Work area:** Host TLS authentication.

**Implement:** Issue a test client certificate and make the sentinel require mTLS plus an active test-device record.

**Pass gate:** Device: enrolled key succeeds; absent, unknown, and unrelated app keys cannot read the sentinel.

**Checkpoint:** Save hostile TLS client commands; production file APIs still disabled.

### P021 - Limit the enrollment window

**Depends:** P017,P019. **Work area:** Host pairing state.

**Implement:** Create high-entropy, expiring, one-use tokens and an enrollment-only temporary listener.

**Pass gate:** Fast: expired/reused tokens and closed windows fail; no file routes exist on the listener.

**Checkpoint:** Save deterministic clock/token fixtures and rate-limit behavior.

### P022 - Render the pairing QR locally

**Depends:** P021,P003. **Work area:** Windows pairing UI.

**Implement:** Encode version, current endpoint, identity fingerprint, token, and join data; show expiry/regenerate.

**Pass gate:** Fast/UI: decode the displayed QR to the exact payload; expired QR cannot remain active after regeneration.

**Checkpoint:** Save the QR schema and non-secret UI screenshot.

### P023 - Scan and verify bootstrap identity

**Depends:** P022,P011,P018. **Work area:** Android pairing UI.

**Implement:** Scan the QR, join through system flow, and establish pinned bootstrap TLS before sending its token.

**Pass gate:** Device: correct QR reaches pending enrollment; a changed fingerprint never submits the token.

**Checkpoint:** Save the bootstrap sequence and camera-denial behavior.

### P024 - Approve and commit one enrollment

**Depends:** P023,P019,P020. **Work area:** Pairing coordinator.

**Implement:** Show a transcript comparison code and owner approval; atomically save one active device and invalidate token.

**Pass gate:** Device: approval permits mTLS reconnect; rejection and concurrent second enrollment leave no active extra device.

**Checkpoint:** Save the enrollment state transition log with all secrets redacted.

### P025 - Revoke a device and its connections

**Depends:** P024. **Work area:** Host session registry.

**Implement:** Mark a device revoked and close its active sentinel sessions; prevent subsequent authentication.

**Pass gate:** Device: existing output stops and a fresh request is rejected; another app installation gains no access.

**Checkpoint:** Save revocation timing and in-flight-byte limitation.

### P026 - Handle changed or expired host trust

**Depends:** P024. **Work area:** Android connection state.

**Implement:** Surface identity change, expiry, and clock-error states with local re-pair recovery instead of bypasses.

**Pass gate:** Fast/Device: all three fixtures fail closed and preserve the original trusted identity until explicit recovery.

**Checkpoint:** Save exact recovery UX and certificate fixtures.

### P027 - Renew a certificate through trusted access

**Depends:** P024,P026. **Work area:** Identity renewal handler.

**Implement:** Renew near-expiry credentials only through an already authenticated session; keep failure atomic.

**Pass gate:** Fast/Device: successful renewal reconnects; failed renewal preserves valid old state and rejects untrusted replacement.

**Checkpoint:** Save renewal boundary tests and recovery steps; no online CA dependency.

## 9. Milestone D - Read-only shared folders

### P028 - Implement the pure grant evaluator

**Depends:** P005,P006. **Work area:** Host policy module.

**Implement:** Represent device/root/capability/policy version; deny missing or revoked grants.

**Pass gate:** Fast: a table of authorized and unauthorized actions passes, including source/destination checks.

**Checkpoint:** Save the policy test matrix for future endpoints to reuse.

### P029 - Register one selected root by identity

**Depends:** P028,P003. **Work area:** Windows root registry.

**Implement:** Use the native picker; record canonical root/volume identity and protected internal exclusions.

**Pass gate:** Device: chosen folder reopens by identity; replacing/removing the volume is detected.

**Checkpoint:** Save synthetic root fixtures and display-label mapping.

### P030 - Validate single-component names

**Depends:** P005,P006. **Work area:** File-engine name parser.

**Implement:** Reject traversal, separators, ADS/device/reserved-name aliases, NULs, and ambiguous trailing forms.

**Pass gate:** Fast: the specified hostile-name corpus rejects without creating/opening files; valid Unicode names survive.

**Checkpoint:** Save the corpus and the exact normalization contract.

### P031 - Open a read-only child by verified handles

**Depends:** P029,P030. **Work area:** Windows file-engine resolver.

**Implement:** Implement one directory-to-regular-file resolution path under held root/parent handles; return an authorized handle.

**Pass gate:** Fast/Device: a normal child opens; outside-root and wrong-volume objects cannot be returned.

**Checkpoint:** Save the chosen native-handle strategy and unresolved race questions; split if the strategy is not proven.

### P032 - Reject reparse traversal

**Depends:** P031. **Work area:** File-engine resolver tests.

**Implement:** Add explicit rejection for symlink, junction, mount-point, and placeholder fixtures along the path.

**Pass gate:** Device: every listed fixture is rejected before reading target bytes, including preview access paths.

**Checkpoint:** Save links/placeholder setup commands and expected error categories.

### P033 - Probe replacement races and hard links

**Depends:** P031,P032. **Work area:** File-engine adversarial harness.

**Implement:** Exercise repeated parent replacement and multiply linked-file cases; enforce the reviewed conservative policy.

**Pass gate:** Device/Review: no out-of-root bytes across the fixed stress corpus; unresolved races block G4 and all write cards.

**Checkpoint:** Save reproduction, run counts, findings, and reviewer disposition; never treat one quiet run as a proof.

### P034 - Version an opened file consistently

**Depends:** P031. **Work area:** File-engine metadata.

**Implement:** Return stable identity and a version token; invalidate on external changes using rechecks, not watcher trust alone.

**Pass gate:** Fast/Device: rename/content replacement and edits invalidate the applicable old token.

**Checkpoint:** Save metadata/version fixtures and precise stale-source rules.

### P035 - Expose authorized root metadata

**Depends:** P020,P028,P029. **Work area:** Host API roots/session routes.

**Implement:** Implement session and root-list endpoints using current device policy; omit ungranted root details.

**Pass gate:** Fast/Device: two test grants produce different root lists; guessed IDs disclose no unauthorized roots.

**Checkpoint:** Save API fixtures and policy-version behavior.

### P036 - Paginate one authorized directory

**Depends:** P035,P031,P032,P034. **Work area:** Host directory endpoint.

**Implement:** Return a bounded page, cursor, item IDs, sort, and current-directory filter through the same resolver.

**Pass gate:** Fast/Device: large fixture directory paginates; inaccessible entries and forged cursors do not escape scope.

**Checkpoint:** Save pagination consistency contract and mutation-during-listing result.

### P037 - Browse that directory on Android

**Depends:** P036,P024. **Work area:** Android files UI.

**Implement:** Render roots, one directory page, breadcrumbs, loading/error states, and refresh; no mutations.

**Pass gate:** Device/UI: navigating synthetic nested folders works; disconnect hides stale remote content.

**Checkpoint:** Save a small UI state fixture set and request trace without names from real data.

### P038 - Edit grants from the desktop

**Depends:** P028,P029,P035,P003. **Work area:** Windows shared-locations UI.

**Implement:** Add read-only/edit capability controls and root removal; increment policy version locally.

**Pass gate:** Device/UI: phone cannot edit grants; owner change affects the next API request and invalidates listing state.

**Checkpoint:** Save effective-permission examples and broad-root exclusions for owner review.

## 10. Milestone E - Safe remote edits

### P039 - Journal one idempotent operation

**Depends:** P005,P028,P006. **Work area:** Host operation journal.

**Implement:** Persist operation ID, request digest, state, and result; retry identical requests safely.

**Pass gate:** Fast: duplicate ID returns prior state/result; same ID with different payload conflicts; restart reconciles state.

**Checkpoint:** Save migration and crash-point fixtures using synthetic no-op operations.

### P040 - Create one folder safely

**Depends:** P033,P038,P039. **Work area:** File-engine create operation.

**Implement:** Create a single directory in a verified allowed parent with current CREATE_DIRECTORY permission.

**Pass gate:** Device: allowed create succeeds; collision, revoked permission, and parent replacement fail without outside writes.

**Checkpoint:** Save the create gate and its disposable fixture path.

### P041 - Rename one file safely

**Depends:** P033,P034,P039. **Work area:** File-engine rename operation.

**Implement:** Rename a regular fixture file within one parent with an expected version and no implicit overwrite.

**Pass gate:** Device: result appears once; stale version/name collision and unauthorized rename fail.

**Checkpoint:** Save old/new identity expectations and locked-file result.

### P042 - Move one file on the same volume

**Depends:** P041,P028. **Work area:** File-engine move operation.

**Implement:** Move using reviewed handles while checking both source and destination grants.

**Pass gate:** Device: allowed move preserves bytes; ungranted destination and ancestor races cannot mutate outside scope.

**Checkpoint:** Save source/destination policy cases and commit boundary.

### P043 - Copy one file through staging

**Depends:** P033,P034,P039. **Work area:** File-engine copy operation.

**Implement:** Copy to a private destination-stage file, verify bytes, then publish only at the safe commit point.

**Pass gate:** Device: hash matches; disk-full or cancellation before commit leaves no corrupt final destination.

**Checkpoint:** Save the stage lifecycle and cleanup behavior.

### P044 - Move across two volumes

**Depends:** P042,P043. **Work area:** File-engine cross-volume coordinator.

**Implement:** Compose copy/verify/publish with source deletion only after verified destination commit.

**Pass gate:** Device: induced failure after publish reports source retained; original is never deleted before verification.

**Checkpoint:** Save each interruption boundary and its observable outcome.

### P045 - Delete into recovery storage

**Depends:** P033,P039,P001. **Work area:** File-engine delete operation.

**Implement:** Implement the approved same-volume quarantine policy for one file, including excluded recovery namespace.

**Pass gate:** Device: delete can be recovered; cap/unavailable recovery refuses or asks for explicit permanent choice.

**Checkpoint:** Save the owner-approved retention decision; stay blocked if G5 is unanswered.

### P046 - Restore and purge from the host UI

**Depends:** P045. **Work area:** Local recovery controls.

**Implement:** Add local-only restore of one item and explicit purge with conflict handling.

**Pass gate:** Device/UI: restore preserves bytes; phone cannot invoke local recovery management; source files survive clear-cache.

**Checkpoint:** Save recovery manifest format and one quota/expiry fixture.

### P047 - Handle mutation conflicts on the phone

**Depends:** P040,P041,P043,P045,P037. **Work area:** Android file-action UI.

**Implement:** Wire existing operations to explicit actions and a reusable conflict/confirmation sheet.

**Pass gate:** Device/UI: cancel causes no mutation; Ask/Skip/Keep-both/confirmed Replace map to documented server policy.

**Checkpoint:** Save action-to-capability mapping; split any missing server conflict rule before wiring it.

### P048 - Stop pending work after policy removal

**Depends:** P025,P038,P039,P043. **Work area:** Host job authorization.

**Implement:** Recheck grants before commit and between bounded copy units; record already-committed outcomes honestly.

**Pass gate:** Device: revoke/root removal stops future work; completed commit is reported, not silently replayed or reversed.

**Checkpoint:** Save timing and commit-point observations.

## 11. Milestone F - Explicit transfers

### P049 - Create an upload staging session

**Depends:** P033,P039,P038. **Work area:** Host upload session.

**Implement:** Allocate transfer ID, authorized destination, size budget, expiry, and a private stage handle.

**Pass gate:** Fast/Device: unauthorized/oversized/no-space cases allocate no usable transfer; stage is hidden from listing.

**Checkpoint:** Save upload-state schema and quota checks.

### P050 - Accept one idempotent upload chunk

**Depends:** P049. **Work area:** Host chunk route.

**Implement:** Validate offset, length, hash, and accepted range before writing one chunk.

**Pass gate:** Fast/Device: identical retry is harmless; wrong hash, overlap conflict, and oversized chunk are rejected.

**Checkpoint:** Save chunk fixtures and accepted-range rules.

### P051 - Verify and publish an upload

**Depends:** P050,P034. **Work area:** Host transfer commit.

**Implement:** Check final size/hash/current grant and atomically publish using the reviewed destination strategy.

**Pass gate:** Device: complete upload matches hash; corrupt/incomplete/revoked commit never exposes a final file.

**Checkpoint:** Save commit failure fixtures and result schema.

### P052 - Resume upload after a host restart

**Depends:** P050,P051,P039. **Work area:** Host transfer recovery.

**Implement:** Persist accepted ranges and reconnect authorization; reconcile unfinished commit state.

**Pass gate:** Device: resume sends only valid missing ranges; changed destination policy blocks recovery.

**Checkpoint:** Save crash-point matrix and no-double-commit evidence.

### P053 - Serve a versioned download range

**Depends:** P034,P035,P031. **Work area:** Host content route.

**Implement:** Stream byte ranges from a verified handle with size/version metadata and backpressure.

**Pass gate:** Fast/Device: requested ranges match source; stale version and out-of-bounds requests fail without mixed bytes.

**Checkpoint:** Save range cases, source-change behavior, and peak memory.

### P054 - Select one phone upload source

**Depends:** P004. **Work area:** Android local-source adapter.

**Implement:** Use Storage Access Framework to select a URI and expose stream/size/seek capabilities.

**Pass gate:** Device: granted file can be read; revoked permission and non-seekable provider are handled; no all-files permission.

**Checkpoint:** Save actual content-provider capability results.

### P055 - Upload the selected phone file

**Depends:** P054,P049,P050,P051,P012. **Work area:** Android upload worker.

**Implement:** Stream one explicit upload through the existing protocol with progress and bounded memory.

**Pass gate:** Device: host bytes equal source hash; cancel stops sending; retry does not duplicate output.

**Checkpoint:** Save transfer trace, byte count, and memory measurement.

### P056 - Select a phone download destination

**Depends:** P004. **Work area:** Android destination adapter.

**Implement:** Use the system save flow; define stage/publish capabilities for the selected provider.

**Pass gate:** Device: canceled picker saves nothing; seek/rename limitations are reported before unsafe resume.

**Checkpoint:** Save provider-specific limitations and approved staging path.

### P057 - Download and verify one file

**Depends:** P053,P056,P012. **Work area:** Android download worker.

**Implement:** Stream to the explicit destination/stage and verify final content before reporting completion.

**Pass gate:** Device: matching hash yields success; interruption/hash failure yields incomplete state, not a completed download.

**Checkpoint:** Save destination lifecycle and an integrity failure fixture.

### P058 - Resume an Android transfer

**Depends:** P052,P055,P057. **Work area:** Android transfer journal.

**Implement:** Save explicit-transfer checkpoints and reauthorize on resume; support restart where provider cannot seek.

**Pass gate:** Device: process death preserves resumable progress or an honest restart option; viewed images are never journaled.

**Checkpoint:** Save the restart test and journal fields without private filenames.

### P059 - Continue or pause background transfer

**Depends:** P058. **Work area:** Android lifecycle adapter.

**Implement:** Implement the selected Android 16 user-initiated/connected-device mechanism with visible progress.

**Pass gate:** Device: background, screen lock, permission denial, and OS stop never corrupt final bytes; unsupported continuation pauses.

**Checkpoint:** Save manifest requirements and real-device lifecycle observations.

### P060 - Clean canceled and expired stages

**Depends:** P052,P058,P046. **Work area:** Transfer cleanup policy.

**Implement:** Add cancellation/24-hour proposed expiry cleanup for both ends, separate from downloads and recovery files.

**Pass gate:** Fast/Device: expired stages disappear after restart; completed downloads and recoverable deletes remain intact.

**Checkpoint:** Save before/after storage inventory and owner-approved retention value.

## 12. Milestone G - Gallery and cache lifecycle

### P061 - Decode a bounded preview in a worker

**Depends:** P031,P034. **Work area:** Media-worker prototype.

**Implement:** Decode synthetic JPEG/PNG into an orientation-normalized bounded preview using pinned libraries.

**Pass gate:** Fast: known dimensions/orientation match fixtures; excessive dimensions/time budget produce typed rejection.

**Checkpoint:** Save decoder versions and output metadata fixture; no network endpoint yet.

### P062 - Restrict the media worker process

**Depends:** P061. **Work area:** Windows worker launcher.

**Implement:** Pass only the required file handle and constrain worker resources/privileges; prevent network access.

**Pass gate:** Device/Review: a test worker cannot open unrelated paths or reach the network; limit breach terminates the job.

**Checkpoint:** Save restriction evidence and remaining OS sandbox gaps; block untrusted decode if unproven.

### P063 - Serve an authenticated thumbnail

**Depends:** P061,P062,P035. **Work area:** Host preview route.

**Implement:** Connect the existing worker to a versioned, size-limited thumbnail endpoint with no-store semantics.

**Pass gate:** Device: allowed fixture previews; ungranted/changed file fails; response strips unneeded metadata.

**Checkpoint:** Save authorization and derivative-metadata checks.

### P064 - Render a virtualized gallery grid

**Depends:** P063,P037. **Work area:** Android gallery UI.

**Implement:** Use visible-item thumbnail requests with disk caching disabled; support list/gallery switching.

**Pass gate:** Device/UI: large fixture folder scrolls without original downloads or unbounded request fan-out.

**Checkpoint:** Save request-count and app-storage observations.

### P065 - Implement image viewport transforms

**Depends:** P064. **Work area:** Android image viewer.

**Implement:** Add fit, pan, pinch zoom, display rotation, and next/previous using a tested transform model.

**Pass gate:** Fast/UI: known image points map correctly after transforms; navigation cancels obsolete requests.

**Checkpoint:** Save transform fixtures and baseline viewer screenshots.

### P066 - Produce a versioned tile region

**Depends:** P061,P062. **Work area:** Media-worker tile code.

**Implement:** Decode or derive one bounded tile level/region and return full-image coordinate metadata.

**Pass gate:** Fast: tile origin/scale reconstructs a synthetic grid; out-of-range requests and oversized work fail.

**Checkpoint:** Save geometry contract and decoder limitations.

### P067 - Render tiles in the viewer

**Depends:** P066,P065,P063. **Work area:** Tile route and Android tile adapter.

**Implement:** Expose the tile contract and fetch only visible tiles within existing authorization and memory limits.

**Pass gate:** Device/UI: zooming a large fixture remains aligned; stale-version tiles are not mixed after edits.

**Checkpoint:** Save a high-resolution grid screenshot and request/memory trace.

### P068 - Add formats one fixture at a time

**Depends:** P061,P065. **Work area:** Decoder/viewer format adapters.

**Implement:** Add WebP/GIF and animated-frame selection only as tested child slices of this card.

**Pass gate:** Fast/Device: each claimed format has decode/orientation/frame tests; unsupported variants retain explicit download.

**Checkpoint:** Save the supported-format matrix; split each additional codec into its own child if needed.

### P069 - Enforce one shared preview budget

**Depends:** P064,P065,P067. **Work area:** Android/host cache controllers.

**Implement:** Count decoded images, tiles, in-flight buffers, and animation resources against explicit limits.

**Pass gate:** Fast/Device: repeated image navigation reaches a stable bounded footprint; LRU evicts inactive entries.

**Checkpoint:** Save configured budgets and measured memory accounting.

### P070 - Clear caches without late repopulation

**Depends:** P069,P025,P038. **Work area:** Cache lifecycle coordinator.

**Implement:** Cancel pending work then clear on disconnect/revoke/viewer close; include content-version invalidation.

**Pass gate:** Fast/Device: delayed responses cannot repopulate a cleared session; edited files invalidate old previews.

**Checkpoint:** Save delayed-response race fixture and clear-event matrix.

### P071 - Verify preview storage and process death

**Depends:** P070,P060. **Work area:** Gallery retention test.

**Implement:** Inspect storage after a fixed browse/zoom/kill/restart cycle and verify downloaded files remain.

**Pass gate:** Device: default preview disk bytes remain zero; memory settles and stale stages follow their own policy.

**Checkpoint:** Save measurements and any decoder temporary-file exception requiring review.

## 13. Milestone H - OCR and no-billing translation

### P072 - Define a fake translation adapter

**Depends:** P005,P004. **Work area:** Android translation contract.

**Implement:** Define block IDs, text inputs/results, target language, cancellation, and typed errors with fake responses.

**Pass gate:** Fast: reordered/missing results are rejected or correctly mapped; no provider network call can occur.

**Checkpoint:** Save fixtures for success, model absent, engine failure, cancellation, and unsupported language.

### P073 - Recognize one bundled OCR script

**Depends:** P065,P072. **Work area:** Android OCR adapter.

**Implement:** Use a bundled recognizer on an in-memory synthetic image and return text blocks/polygons.

**Pass gate:** Device: known text and boxes are returned without online OCR or a model download.

**Checkpoint:** Save model/version and recognition fixture; no real private images in Git.

### P074 - Evaluate unknown or mixed scripts

**Depends:** P073,P001. **Work area:** OCR routing and sample review.

**Implement:** Run candidate script recognizers with bounded work and manual override; evaluate owner-supplied scripts.

**Pass gate:** Device/Review: unsupported or uncertain text is identified honestly; agreed sample matrix establishes G3 scope.

**Checkpoint:** Save script coverage/quality results; each extra script can be a child card.

### P075 - Anchor synthetic text overlays

**Depends:** P065,P073. **Work area:** Android overlay geometry.

**Implement:** Map OCR crop coordinates into normalized full-image coordinates and the existing viewport matrix.

**Pass gate:** Fast/UI: test polygons stay within a stated pixel tolerance under crop, zoom, rotation, and pan.

**Checkpoint:** Save numeric geometry fixtures; translation can remain fake.

### P076 - Fit translated strings accessibly

**Depends:** P075,P072. **Work area:** Android overlay layout.

**Implement:** Wrap translated strings, keep readable minimum size, and use anchored overflow callouts.

**Pass gate:** UI: short/long/mixed-script results remain readable and do not modify source bytes.

**Checkpoint:** Save reference screenshots and source-hash evidence.

### P077 - Prove one local translation without billing

**Depends:** P001,P072. **Work area:** Android isolated ML Kit spike.

**Implement:** Add only the traditional translation SDK; translate one known string with a downloaded model on the actual phone. No key or Cloud project.

**Pass gate:** Device: clean setup requires no card or billing account; the same string translates offline after model download; record failure honestly.

**Checkpoint:** Save dependency version, setup steps, device result, and exact next experiment.

### P078 - Manage downloaded language models

**Depends:** P077. **Work area:** Android model repository.

**Implement:** List, download, and delete selected models; expose missing/downloading/ready/failed states. Keep models separate from preview cache.

**Pass gate:** Device: missing offline model fails clearly; downloaded model works offline; deleting it removes readiness without affecting files.

**Checkpoint:** Save model inventory, storage delta, SDK download behavior on offline hotspot, and deletion result.

### P079 - Identify and choose translation languages

**Depends:** P078,P073. **Work area:** Android language selection.

**Implement:** Use bundled language identification on OCR text; map supported tags, allow source correction, and default target to English.

**Pass gate:** Fast/Device: known, ambiguous, unsupported, and mixed-text fixtures show honest states; no bulk model download or online detection.

**Checkpoint:** Save fixture tags/confidence and manual-override behavior.

### P080 - Measure local quality and footprint

**Depends:** P079,P074. **Work area:** Android trial and decision record.

**Implement:** Run a small representative corpus with corrected source text and OCR output; measure cold/warm latency, PSS, model storage, and repeated lifecycle behavior.

**Pass gate:** Device/Review: record measured quality/resources and select local integration or the authorized external route; failure is valid evidence, not a fake success.

**Checkpoint:** Save redacted results, limits accepted or failed, and the G2 local-or-external disposition. Split measurement families into child cards if needed.

### P081 - Verify manual Google image translation

**Depends:** P001,P055. **Work area:** Android external workflow and help.

**Implement:** Provide explicit download guidance, then Google Translate Camera / All Images with English target. No undocumented intent assumption or automatic image upload.

**Pass gate:** Device: user can save a selected image and manually import it; original hash unchanged; app absence/cancel leaves files usable.

**Checkpoint:** Save tested consumer-app version and workflow. Optional FileProvider shortcut is a separate child card with lease/cleanup tests.

### P082 - Integrate the passing translation route

**Depends:** P076,P080,P081. **Work area:** Android viewer coordinator.

**Implement:** For a passing local trial, wire OCR to the local engine and overlay with required attribution. Otherwise expose the external workflow and omit claims of built-in translation.

**Pass gate:** Device: chosen route works as documented; local route rejects stale image results; external route requires explicit disclosure/copy; originals unchanged.

**Checkpoint:** Save chosen route, scoped tests, attribution if local, and any unsupported languages. No billed adapter is added.

### P083 - Clear translation content and release models

**Depends:** P082,P070. **Work area:** Translation lifecycle.

**Implement:** Clear OCR/results/geometry and close active engine resources on viewer exit or disconnect; retain only intentionally downloaded language assets.

**Pass gate:** Device/Fast: late callbacks cannot restore overlays; no content history/logs; Clear temporary data preserves models and user downloads; separate Delete models works.

**Checkpoint:** Save storage/log inspection and cancel race result. If a share shortcut exists, also verify expired staging and URI grant cleanup.

## 14. Milestone I - Product and installation

### P084 - Polish desktop controls consistently

**Depends:** P038,P047,P046. **Work area:** Windows UI design tokens.

**Implement:** Apply a coherent modern layout to Overview, locations, device, activity, and storage using existing operations.

**Pass gate:** UI: keyboard navigation, scaling, contrast, and actual Start/Stop status pass the agreed review checklist.

**Checkpoint:** Save screenshots and remaining accessibility issues; no behavior redesign in this card.

### P085 - Finish phone connection and permissions UX

**Depends:** P024,P026,P037,P059. **Work area:** Android connection/settings UI.

**Implement:** Unify join, denied permission, disconnected, revoked, and forget-device states with clear recovery actions.

**Pass gate:** Device/UI: each state has an accurate action and never forces internet for local files.

**Checkpoint:** Save permission-state screenshots and tested recovery steps.

### P086 - Present transfer and conflict state

**Depends:** P047,P055,P057,P058. **Work area:** Android/desktop activity UI.

**Implement:** Render operation progress, destination, pause/cancel, and partial-result messages from the existing journal.

**Pass gate:** UI/Device: cross-volume partial failure and canceled transfers are not shown as completed moves/downloads.

**Checkpoint:** Save job-state-to-message mapping and a recorded fixture walkthrough.

### P087 - Constrain the production listener/firewall

**Depends:** P020,P010,P025. **Work area:** Windows listener/install integration.

**Implement:** Bind only intended local interface/address and install/remove a narrow firewall rule through reviewed setup.

**Pass gate:** Device: allowed interface works; other interfaces/IPv6 paths are not accidentally exposed; denied elevation is recoverable.

**Checkpoint:** Save actual socket/rule inventory and uninstall cleanup test.

### P088 - Build and test an offline Windows package

**Depends:** P003,P087,P007. **Work area:** packaging/windows.

**Implement:** Package a self-contained .NET publish with all WPF/Kestrel/SQLite/worker assets for the verified CPU architecture; choose an installer with no billing prerequisite.

**Pass gate:** Device: clean Windows install offline opens and serves the secure test flow without development tools.

**Checkpoint:** Save installer hash/build recipe; signing remains explicit, never claimed if unavailable.

### P089 - Build a signed Android release package

**Depends:** P004,P073,P085. **Work area:** Android release configuration.

**Implement:** Generate a release build with intended models/permissions, backup exclusions, and controlled signing references.

**Pass gate:** Device: signed APK installs on Android 16 and recognizes the bundled fixture offline; no debug trust bypasses.

**Checkpoint:** Save signing fingerprint/build recipe, dependency inventory, and backup-rule review.

### P090 - Exercise one upgrade/reset path

**Depends:** P039,P052,P058,P088,P089. **Work area:** Migrations and local recovery.

**Implement:** Upgrade a seeded prior schema, reconcile jobs, and implement explicit reset/re-pair without deleting user files.

**Pass gate:** Device/Fast: failed migration preserves recovery state; reset clears identity only as disclosed; downloads survive.

**Checkpoint:** Save upgrade/recovery fixture and one-version compatibility policy.

## 15. Milestone J - Release evidence

### P091 - Run hostile network-client acceptance

**Depends:** P024,P025,P027,P035,P048,P087. **Work area:** Security test suite.

**Implement:** Run fixed unpaired/wrong-host/replay/revoked/oversized-request cases against the packaged integration build.

**Pass gate:** Device/Review: every case has actual results; no metadata/file leak or authentication bypass remains unresolved.

**Checkpoint:** Save packet-capture conclusions and reviewer disposition; split new findings into fix cards.

### P092 - Run filesystem containment acceptance

**Depends:** P033,P040,P041,P042,P043,P044,P045,P051,P063. **Work area:** Windows security suite.

**Implement:** Run the documented adversarial namespace/race corpus across reads, previews, and writes on supported storage.

**Pass gate:** Device/Review: no escape or unsafe commit; each supported filesystem has evidence; unresolved critical issue blocks release.

**Checkpoint:** Save G4 review and explicit unsupported filesystem cases; remediation is separate work.

### P093 - Run the offline user journey

**Depends:** P009,P014,P037,P047,P059,P067,P088,P089. **Work area:** Real-device end-to-end test.

**Implement:** Pair offline, browse, preview, modify fixtures, and upload/download; interrupt local radio and restore it.

**Pass gate:** Device: no internet/account dependency for file features; hashes match after supported recovery and policy changes.

**Checkpoint:** Save hardware-specific walkthrough and matrix; this is not a universal adapter claim.

### P094 - Audit cache and privacy retention

**Depends:** P071,P083,P089,P090. **Work area:** Privacy acceptance tests.

**Implement:** Run the fixed browse/translate/clear/crash cycle and inspect app storage, backups, logs, and recent-app exposure.

**Pass gate:** Device/Review: bounded retained categories match the report; downloads and recovery are not mistaken for previews.

**Checkpoint:** Save before/after inventories and any accepted retention exception.

### P095 - Accept the no-billing translation scope

**Depends:** P074,P080,P081,P082,P083. **Work area:** Owner acceptance record.

**Implement:** Review local quality/resources or documented external fallback, script coverage, privacy, and a clean no-card setup path.

**Pass gate:** Review: chosen local or external scope matches the latest instruction; no blanket never-refuses claim; no paid account needed.

**Checkpoint:** Save G2/G3 disposition and accurate feature labels; external-only translation can satisfy the revised scope.

### P096 - Assemble the release and next-work packet

**Depends:** P084,P085,P086,P090,P091,P092,P093,P094,P095. **Work area:** docs/, release manifest.

**Implement:** Collect signed/verified artifacts, actual test evidence, decisions, runbooks, open issues, and future multi-device notes.

**Pass gate:** Review: another implementer can build, install, test, recover, and identify limitations without chat history.

**Checkpoint:** Save tagged commit, artifact hashes, handoff checklist, and the next explicitly scoped task.

## 16. Integration, translation routes, and release boundaries

### 16.1 Conditional translation branch

The owner's latest instruction rejects required billing/payment-card enrollment and permits lightweight local translation. P077-P080 evaluate ML Kit's conventional on-device engine. Google Cloud/Azure keys, billing setup, and usage-ledger tasks from playbook 1.0 are superseded. Do not implement those old cards.

P080 passes when it produces a trustworthy measured decision, even if the local engine is unsuitable. Record LOCAL or EXTERNAL. P081 supplies the manual Google image workflow. P082/P083 implement and verify only the chosen scope. Local-only subchecks are marked NOT_APPLICABLE with that decision, never falsely PASS. The external workflow is not an API and does not return an in-app overlay. Do not add a different engine without a separate bounded scope decision.

If P077 cannot run the SDK at all, record the attempted setup and reason; mark it BLOCKED and close the local-only P078/P079 branch as NOT_APPLICABLE only through an explicit external-route disposition in DECISIONS. P080 may then document that feasibility failure and select EXTERNAL; update dependency overrides in TASKS/task-index. Without this recorded override, dependencies remain blocking. Preserve failed evidence.

### 16.2 Reviews are not coding marathons

P091-P095 are bounded execution/review cards against suites assembled earlier. If a finding requires changes, open a new fix card with its own reproduction and regression gate. Keep the acceptance card BLOCKED until the fix is verified. Do not try to investigate, redesign, patch, and rerun an entire security review inside the remaining few messages of one chat session.

P096 requires all gates for the selected scope. A documented external-only translation route is permitted by the revised requirement; clearly label that the app itself does not translate images. A demo with neither local translation nor the external workflow remains incomplete.

### 16.3 Future multiple-device work stays separate

The v1 data model retains per-device grants and distinct keys. Actual multi-phone operation should become a new backlog: independent enrollment limits; per-device quotas; conflicting edit tests; scheduler fairness; revocation isolation; AP client-capacity validation; then additional platforms. Keep cloud relay/storage and remote-access work in separate owner-approved architecture decisions. Do not consume current sessions on speculative infrastructure.

## 17. Worked example: resuming a difficult filesystem card

Suppose P031 opens a regular child correctly, but the assistant reaches its limit while investigating parent replacement. The correct saved state is IN_PROGRESS, with the working read-only test recorded and write operations still blocked. CURRENT names the resolver file, the exact failing race fixture, the last commit, and the next experiment. It must not say 'filesystem security complete'.

At the next session, the new assistant inspects the diff, reruns the named reproduction, and opens P031a for handle-lifetime analysis and P031b for the selected mitigation. P031 remains SPLIT until both pass. P032 and all dependent write cards wait. An Android contributor can still work on P037's fake UI data or another independently ready card without pretending the real resolver is ready.

The same pattern applies to a model-download failure: save the SDK version, network state, exact error, and completed experiments; stop repeated downloads and continue fake-adapter tests. The next session should perform the recorded discriminating experiment, not repeat the setup. A persistent failure can select the authorized external route.

## 18. Final handoff checklist for every session

- The task status describes reality: PASS only after its actual gate; otherwise IN_PROGRESS, BLOCKED, or SPLIT.
- Changed files and the current commit/worktree state are saved, including untracked files.
- Exact test commands, outcomes, environment, and redacted evidence are recorded.
- Decisions and unresolved questions are separated; no new requirement is silently assumed.
- CURRENT states the next single action, not an open-ended 'continue implementation'.
- No secrets, raw private image/text content, or misleading test claims enter the context packet.
- The next chatbot can resume using files alone; the previous conversation is optional background.

This workflow reduces the cost of interruptions. It cannot guarantee a chatbot's availability, unlimited context, completion time, or correctness. Durable state, small testable changes, and independent review of critical boundaries remain the continuity mechanism.
