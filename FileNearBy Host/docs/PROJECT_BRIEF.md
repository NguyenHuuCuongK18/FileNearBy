# File Near By - project brief

P001 baseline, 2026-09-24. Display name: **File Near By**. Code identifier: **FileNearBy**; Windows application: **FileNearBy.Host**.

Current scope: **Windows PC Host only; Android implementation deferred.** P000/P001 documentation is complete. The owner subsequently assigned P002/P003: recoverable session records and a WPF/MVVM desktop shell. Shell navigation/build checks do not approve product defaults or prove sharing/file access. Source: implementation plan revision 1.4, especially Sections 1-4, 8-12, 19 and 22, plus latest owner instructions. See [decisions](DECISIONS.md) for precedence and gate owners.

## Confirmed requirements

| Area | Required host behavior / boundary |
| --- | --- |
| Platform and delivery | Windows 11 x64 host with a clear, lightweight desktop UI. Owner confirmed x64 during P001. Normal Windows installer accepted; Docker unnecessary. No ARM64 target currently requested. |
| Local connectivity | Prefer a laptop-created hotspot. Owner accepts a compatible USB Wi-Fi adapter or phone-hosted hotspot, provided laptop and phone connect without relying on Bluetooth pairing. Local file features must still work without internet or an existing router. Actual adapter/driver and chosen topology require G1 evidence; fallback acceptance is not proof it works. |
| Owner authority | The laptop owner chooses explicit folders, drives or broader accessible local roots and grants capabilities. Every file, metadata, preview and operation request must respect current host-side grants and Windows permissions. Broad access never implies administrator access. |
| Identity and confidentiality | Initially one paired phone; preserve distinct device identities/grants for future expansion. App possession, a Wi-Fi password or observed traffic grants no file access. Encrypted authenticated access and effective revocation are required. |
| Viewing and transfers | Viewing is temporary and bounded. Permanent Upload/Download requires explicit action. Laptop-side copy/move/rename/delete remains within grants. No automatic synchronization or upload; no silent overwrite or source deletion from a transfer. |
| Integrity and retention | Never publish partial transfers as complete. Cross-volume moves preserve the source until verified destination commit. Keep previews, explicit transfer staging, completed user files, delete recovery, identity and settings in separate retention categories. Clear temporary previews must not erase user files or identity. |
| Cost and privacy | No required billing/card enrollment, paid API, hosted database, cloud relay, subscription or account for file hosting. No automatic external image disclosure. Redact secrets and private content from diagnostics. |
| Expansion | Cloud access, other operating systems, Bluetooth and multiple simultaneous devices require future scope decisions. No current implementation authorization. |
| Handoff | Markdown is authoritative; keep task state and evidence recoverable without chat history or PDFs. |

These requirements retain the longer-term phone interaction contract; host-only development does not demonstrate a complete Windows/Android user journey.

## Recorded host stack and engineering baseline

Current project instructions establish C#/.NET 10 LTS, WPF/MVVM, embedded ASP.NET Core/Kestrel, SQLite local host state and VS Code as the preferred editor. This is the recorded baseline, not a claim that SDKs are installed or versions/APIs have been verified. Package choices, exact versions and build configuration belong to separately assigned implementation tasks.

Retain the planned boundaries: Host composes desktop services; Core owns policy/jobs; Api exposes authenticated transport; Windows isolates platform interop; FileEngine performs authorized operations; MediaWorker isolates untrusted image decoding. Views/view models do not decide authorization.

The specified security direction is QR-pinned enrollment, mutual TLS, standard cryptography and Windows handle-based containment. Exact enrollment details, supported filesystems and safe handling of races/reparse points/hard links remain subject to design review and G4 evidence. String-prefix containment and disabled TLS validation are unacceptable substitutes.

## Proposed behavior — pending G5 approval and measurements

The report proposes manual sharing startup with optional tray continuation; initially read-only grants; explicit broad roots with internal storage exclusions; a two-minute enrollment window; JPEG/PNG/WebP/GIF previews; bounded memory-only host previews; recoverable deletion; and bounded transfer/audit retention. Exact values and decision owners are in [G5](DECISIONS.md#p001-g5-proposed-host-defaults).

Proposed desktop screens are Overview, Shared locations, Device, Activity, Storage and Settings/diagnostics (report Section 12.1). Layout, visual tokens and performance targets are proposals, not reviewed UI or benchmark results. Unsupported preview formats must not prevent explicit opaque-file transfers. Decoder support still requires feasibility checks.

No host hardware capability, filesystem safety, performance, installability or runtime integration has been verified.

## Deferred Android work

Android shell/UI, network routing, gallery/zoom, OCR, translation, model management, APK distribution and cross-device acceptance are deferred. Preserve Kotlin/Compose as the future baseline and retain the supplied task cards/placeholders. Phone model/RAM, source scripts and representative samples are unknown; G2/G3 remain BLOCKED (deferred), not passed or waived.

Retained future requirements: image translation leaves originals unchanged; English default with source detection/manual correction; evaluate lightweight local translation before using the authorized explicit manual Google image-translation fallback. No app-level adult-content classifier or universal provider/quality guarantee. No translation SDK, model download or external service work is part of host P001.

## Host-only task sequence and completion boundary

P001 completed the requirements/decision record. P002/P003 subsequently passed the recovery-record and Windows-shell build/open gates. P004 remains deferred. P005 depends on P003 and P004; P006 depends on P003, P004 and P005. Consequently the original roadmap cannot be treated as a ready host-only implementation sequence beyond P003.

Before selecting those mixed-platform tasks, explicitly split their host deliverables and preserve Android integration/acceptance as pending. No dependency is removed, no mock substitutes for device evidence, and no P002-P096 task is started or passed by P001. See [task board](TASKS.md).

G1-G5 disposition and exact unanswered questions are recorded in [DECISIONS.md](DECISIONS.md). BLOCKED evidence/defaults prevent dependent claims or implementation choices; they do not block this documentation record. P001 PASS means this distinction and the handoff were checked, not that unknown facts or proposed defaults were approved.

