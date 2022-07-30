[![Coverage Status](https://coveralls.io/repos/github/martinjonsson01/template/badge.svg?branch=master)](https://coveralls.io/github/martinjonsson01/template?branch=master)

# .NET Template
A .NET solution template, with complete testing and CI-setup.

Uses:
- [SpecFlow Behavior-driven tests](https://specflow.org/)
- [Semantic versioning](https://semver.org/)
- Auto-generated changelogs
- [Conventional commit messages](https://www.conventionalcommits.org/en/v1.0.0/)

To-do:
- [Docker containers for test databases](https://github.com/testcontainers/testcontainers-dotnet)

## Version management
The version format is `[MAJOR].[MINOR].[PATCH][-pre]`.

Each commit increments the PATCH. Whenever the MAJOR or MINOR versions are updated, the PATCH is reset to zero.

To update the MAJOR or MINOR version, update the values in [version.json](./version.json).
