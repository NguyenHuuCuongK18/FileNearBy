# Restarting a work session

1. Read AGENTS.md, CURRENT.md, PROJECT_BRIEF.md, the assigned card and applicable DECISIONS.md entries. Use the task board/index to check prerequisites. Resolve project credit from the current user's identity using AGENTS.md; do not change Git settings.
2. Inspect `git status --short`, `git branch --show-current`, `git rev-parse HEAD` and relevant diffs. Include untracked files in inspection; a clean tracked diff alone is insufficient. Preserve incomplete work.
3. State the next single action, invariant and actual starting state. If the evidence disagrees with CURRENT, correct the checkpoint before proceeding. Recheck the smallest relevant recorded result; do not reinstall or regenerate existing work.
4. Write the starting checkpoint using the CURRENT template. Work one assigned card at a time; a batch assignment allows the next card only after its dependency passes.
5. Save changed paths before a long command. After each verification, immediately record the exact command, exit code, result and evidence location. Distinguish PASS, FAIL, NOT_RUN and BLOCKED. Update CURRENT, card, task board and index consistently.
6. Stop at the assigned boundary with a recoverable next action. Do not stage/commit/push unless authorized. Keep failed attempts and unresolved owner/evidence gates visible.

Templates: [checkpoint](templates/CURRENT.md), [task board](templates/TASKS.md), [task card](templates/TASK_CARD.md), [evidence](templates/WORKLOG.md). These are copyable patterns, not additional tasks. Existing prompts remain usable. Keep CURRENT under about 500 words; store details in per-task evidence.

Recovery rehearsal: [P002 stopped handoff](evidence/P002/STOPPED_HANDOFF.md) and [recorded rehearsal](evidence/P002/RESUME_REHEARSAL.md). This documents a repository-only walkthrough, not an independent reviewer or new-chat test. P006's later fresh-session gate remains unrun.
