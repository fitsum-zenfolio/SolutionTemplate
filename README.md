# Introduction

The purpose of this project is twofold:

1.  Provide a consistent starting point for greenfield DPL projects.
2.  Reduce the time spent on "plumbing" when spinning up a new project.

# Getting Started

1. Clone this repo.
2. Make sure you have the .NET Core 3.1 SDK installed.
3. Run either of the `installtemplates` scripts to install the template on your machine:
   - Powershell (Windows/MacOS/Linux): `./installtemplates.ps1`
   - Bash (WSL/MacOS/Linux): `./installtemplates.sh`
4. After the template installation has finished, you can run `dotnet new dplsln --name [Company].[Product]` to create a properly-namespaced, IDesign method style architecture, .NET Core Solution.

# Entity Framework DbContext

`[Solution Directory]/[Customer].[Product].Accessors.Shared/EntityFramework/partials/DatabaseContext.cs` is a partial class. This is to enable a developer to use EntityFramework Core scaffolding from a SQL Server database to generate Entity Framework models.

See this article for more information: https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding

# Contribute

You can contribute to this repository by cloning, and making updates to `[LocalRepoFolderName]/templates/dplsln/`.

Push your branch and make a PR!
