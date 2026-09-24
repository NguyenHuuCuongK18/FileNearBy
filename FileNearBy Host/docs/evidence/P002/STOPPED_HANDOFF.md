# Sample stopped-session handoff

Task / status: P002 IN_PROGRESS; P003 explicitly assigned but not started.
Project credit: Leon (NguyenHuuCuongK18), explicit owner instruction; local Git author NGUYEN HUU CUONG. Remote login not independently verified.
Destination: D:\Project\FileNearBy\FileNearBy Host; Git root is its parent.
Branch / HEAD: main / 0a5a62556f592eac96bbf3ad51e1c4957474593b. No known-good application commit.
Starting state: P000/P001 PASS; host bundle untracked; no application project/source exists. .NET SDK 10.0.400, Windows x64 build 26200, desktop runtime 10.0.12 observed.
Goal/invariant: complete restartable records first, then P003 shell only. Windows host scope; Android deferred. P003 must not start network services or perform real file access.
Changed paths: AGENTS.md, prompts/start-session.txt, prompts/resume-session.txt, prompts/checkpoint-template.txt, docs/SESSION_WORKFLOW.md, docs/templates/, docs/evidence/README.md; owner credits in P000/P001 cards/evidence/board/index and root LICENSE.
Last checks: inspected current Git identity, .NET toolchain and existing placeholders. No build attempted.
Remaining work: verify templates and this recovery packet, save rehearsal evidence, mark P002 PASS, then checkpoint P003 before source creation.
Next single action: read this packet with the P002/P003 cards and verify the templates are present; identify the baseline, invariant and next action without consulting chat history.
Resume files: AGENTS.md; docs/SESSION_WORKFLOW.md; docs/templates/; docs/tasks/P002.md; docs/tasks/P003.md; docs/DECISIONS.md.
Recovery: no reset/clean; preserve pre-existing untracked docs. P003 may create the authorized shell only after P002 passes. G1/G4/G5 later-feature decisions remain pending; nothing in this handoff approves defaults or Android implementation.
