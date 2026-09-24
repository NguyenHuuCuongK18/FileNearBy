# Task board

Template statuses are unstarted. Preserve actual existing task histories. Complete P000 before starting the implementation roadmap; it is a global preparation gate, not a renumbering of P001-P096. Set READY only after dependencies and owner decisions are satisfied. Conditional translation-route dependencies are described in the playbook Section 16.1.

| ID | Task | Depends | Status | Owner |
| --- | --- | --- | --- | --- |
| P000 | Documentation-only initialization | Identified destination and source bundle | PASS | Leon (NguyenHuuCuongK18) |
| P001 | Freeze the implementation brief | None | PASS | Leon (NguyenHuuCuongK18) |
| P002 | Create restartable session state | P001 | PASS | Leon (NguyenHuuCuongK18) |
| P003 | Build the Windows shell | P002 | PASS | Leon (NguyenHuuCuongK18) |
| P004 | Build the Android shell | P002 | NOT_STARTED | Unassigned |
| P005 | Define the minimum shared protocol | P003, P004 | NOT_STARTED | Unassigned |
| P006 | Implement task verification dispatch | P003, P004, P005 | NOT_STARTED | Unassigned |
| P007 | Inventory the actual wireless hardware | P003, P006 | NOT_STARTED | Unassigned |
| P008 | Start and stop one test access point | P007 | NOT_STARTED | Unassigned |
| P009 | Prove operation with no upstream network | P008 | NOT_STARTED | Unassigned |
| P010 | Resolve the host endpoint dynamically | P008, P005 | NOT_STARTED | Unassigned |
| P011 | Join the hotspot from Android | P004, P009, P010 | NOT_STARTED | Unassigned |
| P012 | Bind one local client to that network | P011 | NOT_STARTED | Unassigned |
| P013 | Separate internet and local clients | P012 | NOT_STARTED | Unassigned |
| P014 | Handle one hotspot interruption at a time | P010, P012 | NOT_STARTED | Unassigned |
| P015 | Persist the host identity securely | P003, P006 | NOT_STARTED | Unassigned |
| P016 | Generate the phone's device key | P004, P006 | NOT_STARTED | Unassigned |
| P017 | Serve a TLS sentinel with host identity | P015, P010 | NOT_STARTED | Unassigned |
| P018 | Verify the host pin on Android | P017, P012 | NOT_STARTED | Unassigned |
| P019 | Create and validate a device CSR | P015, P016 | NOT_STARTED | Unassigned |
| P020 | Require a registered client certificate | P018, P019 | NOT_STARTED | Unassigned |
| P021 | Limit the enrollment window | P017, P019 | NOT_STARTED | Unassigned |
| P022 | Render the pairing QR locally | P021, P003 | NOT_STARTED | Unassigned |
| P023 | Scan and verify bootstrap identity | P022, P011, P018 | NOT_STARTED | Unassigned |
| P024 | Approve and commit one enrollment | P023, P019, P020 | NOT_STARTED | Unassigned |
| P025 | Revoke a device and its connections | P024 | NOT_STARTED | Unassigned |
| P026 | Handle changed or expired host trust | P024 | NOT_STARTED | Unassigned |
| P027 | Renew a certificate through trusted access | P024, P026 | NOT_STARTED | Unassigned |
| P028 | Implement the pure grant evaluator | P005, P006 | NOT_STARTED | Unassigned |
| P029 | Register one selected root by identity | P028, P003 | NOT_STARTED | Unassigned |
| P030 | Validate single-component names | P005, P006 | NOT_STARTED | Unassigned |
| P031 | Open a read-only child by verified handles | P029, P030 | NOT_STARTED | Unassigned |
| P032 | Reject reparse traversal | P031 | NOT_STARTED | Unassigned |
| P033 | Probe replacement races and hard links | P031, P032 | NOT_STARTED | Unassigned |
| P034 | Version an opened file consistently | P031 | NOT_STARTED | Unassigned |
| P035 | Expose authorized root metadata | P020, P028, P029 | NOT_STARTED | Unassigned |
| P036 | Paginate one authorized directory | P035, P031, P032, P034 | NOT_STARTED | Unassigned |
| P037 | Browse that directory on Android | P036, P024 | NOT_STARTED | Unassigned |
| P038 | Edit grants from the desktop | P028, P029, P035, P003 | NOT_STARTED | Unassigned |
| P039 | Journal one idempotent operation | P005, P028, P006 | NOT_STARTED | Unassigned |
| P040 | Create one folder safely | P033, P038, P039 | NOT_STARTED | Unassigned |
| P041 | Rename one file safely | P033, P034, P039 | NOT_STARTED | Unassigned |
| P042 | Move one file on the same volume | P041, P028 | NOT_STARTED | Unassigned |
| P043 | Copy one file through staging | P033, P034, P039 | NOT_STARTED | Unassigned |
| P044 | Move across two volumes | P042, P043 | NOT_STARTED | Unassigned |
| P045 | Delete into recovery storage | P033, P039, P001 | NOT_STARTED | Unassigned |
| P046 | Restore and purge from the host UI | P045 | NOT_STARTED | Unassigned |
| P047 | Handle mutation conflicts on the phone | P040, P041, P043, P045, P037 | NOT_STARTED | Unassigned |
| P048 | Stop pending work after policy removal | P025, P038, P039, P043 | NOT_STARTED | Unassigned |
| P049 | Create an upload staging session | P033, P039, P038 | NOT_STARTED | Unassigned |
| P050 | Accept one idempotent upload chunk | P049 | NOT_STARTED | Unassigned |
| P051 | Verify and publish an upload | P050, P034 | NOT_STARTED | Unassigned |
| P052 | Resume upload after a host restart | P050, P051, P039 | NOT_STARTED | Unassigned |
| P053 | Serve a versioned download range | P034, P035, P031 | NOT_STARTED | Unassigned |
| P054 | Select one phone upload source | P004 | NOT_STARTED | Unassigned |
| P055 | Upload the selected phone file | P054, P049, P050, P051, P012 | NOT_STARTED | Unassigned |
| P056 | Select a phone download destination | P004 | NOT_STARTED | Unassigned |
| P057 | Download and verify one file | P053, P056, P012 | NOT_STARTED | Unassigned |
| P058 | Resume an Android transfer | P052, P055, P057 | NOT_STARTED | Unassigned |
| P059 | Continue or pause background transfer | P058 | NOT_STARTED | Unassigned |
| P060 | Clean canceled and expired stages | P052, P058, P046 | NOT_STARTED | Unassigned |
| P061 | Decode a bounded preview in a worker | P031, P034 | NOT_STARTED | Unassigned |
| P062 | Restrict the media worker process | P061 | NOT_STARTED | Unassigned |
| P063 | Serve an authenticated thumbnail | P061, P062, P035 | NOT_STARTED | Unassigned |
| P064 | Render a virtualized gallery grid | P063, P037 | NOT_STARTED | Unassigned |
| P065 | Implement image viewport transforms | P064 | NOT_STARTED | Unassigned |
| P066 | Produce a versioned tile region | P061, P062 | NOT_STARTED | Unassigned |
| P067 | Render tiles in the viewer | P066, P065, P063 | NOT_STARTED | Unassigned |
| P068 | Add formats one fixture at a time | P061, P065 | NOT_STARTED | Unassigned |
| P069 | Enforce one shared preview budget | P064, P065, P067 | NOT_STARTED | Unassigned |
| P070 | Clear caches without late repopulation | P069, P025, P038 | NOT_STARTED | Unassigned |
| P071 | Verify preview storage and process death | P070, P060 | NOT_STARTED | Unassigned |
| P072 | Define a fake translation adapter | P005, P004 | NOT_STARTED | Unassigned |
| P073 | Recognize one bundled OCR script | P065, P072 | NOT_STARTED | Unassigned |
| P074 | Evaluate unknown or mixed scripts | P073, P001 | NOT_STARTED | Unassigned |
| P075 | Anchor synthetic text overlays | P065, P073 | NOT_STARTED | Unassigned |
| P076 | Fit translated strings accessibly | P075, P072 | NOT_STARTED | Unassigned |
| P077 | Prove one local translation without billing | P001, P072 | NOT_STARTED | Unassigned |
| P078 | Manage downloaded language models | P077 | NOT_STARTED | Unassigned |
| P079 | Identify and choose translation languages | P078, P073 | NOT_STARTED | Unassigned |
| P080 | Measure local quality and footprint | P079, P074 | NOT_STARTED | Unassigned |
| P081 | Verify manual Google image translation | P001, P055 | NOT_STARTED | Unassigned |
| P082 | Integrate the passing translation route | P076, P080, P081 | NOT_STARTED | Unassigned |
| P083 | Clear translation content and release models | P082, P070 | NOT_STARTED | Unassigned |
| P084 | Polish desktop controls consistently | P038, P047, P046 | NOT_STARTED | Unassigned |
| P085 | Finish phone connection and permissions UX | P024, P026, P037, P059 | NOT_STARTED | Unassigned |
| P086 | Present transfer and conflict state | P047, P055, P057, P058 | NOT_STARTED | Unassigned |
| P087 | Constrain the production listener/firewall | P020, P010, P025 | NOT_STARTED | Unassigned |
| P088 | Build and test an offline Windows package | P003, P087, P007 | NOT_STARTED | Unassigned |
| P089 | Build a signed Android release package | P004, P073, P085 | NOT_STARTED | Unassigned |
| P090 | Exercise one upgrade/reset path | P039, P052, P058, P088, P089 | NOT_STARTED | Unassigned |
| P091 | Run hostile network-client acceptance | P024, P025, P027, P035, P048, P087 | NOT_STARTED | Unassigned |
| P092 | Run filesystem containment acceptance | P033, P040, P041, P042, P043, P044, P045, P051, P063 | NOT_STARTED | Unassigned |
| P093 | Run the offline user journey | P009, P014, P037, P047, P059, P067, P088, P089 | NOT_STARTED | Unassigned |
| P094 | Audit cache and privacy retention | P071, P083, P089, P090 | NOT_STARTED | Unassigned |
| P095 | Accept the no-billing translation scope | P074, P080, P081, P082, P083 | NOT_STARTED | Unassigned |
| P096 | Assemble the release and next-work packet | P084, P085, P086, P090, P091, P092, P093, P094, P095 | NOT_STARTED | Unassigned |

Current scope (2026-09-24): Windows PC Host only; Android implementation deferred. P000-P003 PASS. P002 supplies recovery templates/rehearsal; P003 builds and opens a standalone shell with no network/file service. P004-P096 remain NOT_STARTED with dependencies unchanged. G1-G5 evidence/default decisions remain as recorded; x64 and USB Wi-Fi/phone-hotspot alternatives are confirmed. Project credits: Leon (NguyenHuuCuongK18); future sessions resolve the current user's identity through AGENTS.md. P000's non-task prerequisites were verified; its index dependency list is empty.

Next action: explicitly split/reconcile P005/P006 for host-only work. P004 remains deferred; P005 depends on P003/P004 and P006 on P003/P004/P005. Do not bypass these dependencies or pass mixed-platform acceptance from host-only checks. Alternative hotspot routes need documented route-specific gates. See [brief](PROJECT_BRIEF.md) and [decision register](DECISIONS.md).
