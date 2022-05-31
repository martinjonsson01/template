# .NET Template
A .NET solution template, with complete testing and CI-setup.

Uses:
- [SpecFlow Behavior-driven tests](https://specflow.org/)
- [Semantic versioning](https://semver.org/)
- Auto-generated changelogs
- [Conventional commit messages](https://www.conventionalcommits.org/en/v1.0.0/)

## Version management
The version format is `[MAJOR].[MINOR].[PATCH][-pre]`.

Each commit increments the PATCH. Whenever the MAJOR or MINOR versions are updated, the PATCH is reset to zero.

To update the MAJOR or MINOR version, update the values in [version.json](./version.json).
