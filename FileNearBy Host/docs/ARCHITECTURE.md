# Architecture loading map

The authoritative planning report is reference/file_near_by_implementation_plan.md, revision 1.4. Requirements and engineering proposals are separated there. Do not treat untested recommendations as observed capabilities.

- Networking: report Section 5; task cards P007-P014.
- Pairing and identities: Sections 6-7; P015-P027.
- Authorization and Windows containment: Section 8; P028-P038.
- Mutations and transfer integrity: Sections 9, 14-15; P039-P060.
- Cache/gallery geometry: Sections 10-12; P061-P071.
- OCR and local/external translation decision: Section 13; P072-P083.
- Installation and acceptance: Sections 17-20; P084-P096.

Invariants: no unauthenticated file/metadata endpoints; no phone-side grant authority; no network observation decryption; no unverified path reopening after a containment check; no partial file published as complete; no persistent viewing cache by default; no unrequested original upload; no billed service or automatic external image disclosure; no keys/private content in shared logs/context.

Keep transport, authorization, file engine, UI, OCR geometry, and provider adapters separated. Share contracts before cross-platform integration. Reuse standard cryptographic protocols/libraries and obtain independent review of trust and filesystem boundaries.
