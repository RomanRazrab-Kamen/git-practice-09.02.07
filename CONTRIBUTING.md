# Contributing

Thank you for contributing to this project!

## Development workflow

1. Check existing Issues or create a new Issue describing the task.
2. Create a separate branch for your changes.
3. Implement the changes and verify that the application builds.
4. Use Conventional Commits for all commit messages.
5. Push the branch to GitHub and create a Pull Request to `main`.
6. Ensure that all CI checks pass.
7. Ask another team member to review the changes.
8. Merge the Pull Request only after approval.
9. Do not push changes directly to `main`.

## Branch naming

Use the following prefixes:

- `feature/` — new functionality.
- `fix/` — bug fixes.
- `docs/` — documentation changes.
- `test/` — test changes.

Examples:

- `feature/add-subtraction`
- `fix/calculator-error`
- `docs/release-1.1.0`

## Commit message format

Use the following format:

`<type>[optional scope]: <description>`

Allowed types:

- `feat` — add new functionality.
- `fix` — fix a bug.
- `docs` — documentation changes.
- `test` — add or update tests.
- `refactor` — restructure code without changing its behavior.
- `chore` — routine maintenance.
- `ci` — CI/CD configuration changes.
- `build` — build system or dependency changes.

Examples:

- `feat: add subtraction operation`
- `fix: handle division by zero`
- `docs: add changelog and contributing guide`
- `ci: update build workflow`

## Code review

- Keep changes focused on one task.
- Explain the purpose of the changes in the Pull Request.
- Address review comments before merging.
- Verify that CI checks pass after the final changes.
