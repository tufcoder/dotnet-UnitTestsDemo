# 🆕 UnitTestsDemo

After reading about unit testing in the official Microsoft documentation, I
wanted to create a small project where I could test the tools and test patterns.

## ❓ What is My Project?

This project is a model for using **Clean Architecture** with **Unit Tests**
using the **`xUnit`** library.

This way I think I can scale the project up to something bigger in the future.

## ⚡ Getting Started

It's easy to start, just clone this project

```sh
git clone git@github.com:tufcoder/dotnet-UnitTestsDemo.git UnitTestsDemo
```

You will see the project structure following the **Clean Architecture**.
It's just a simple template.

```text
UnitTestsDemo/
  src/
    UnitTestsDemo.Core/
    UnitTestsDemo.Infrastructure/
    UnitTestsDemo.Web/
  tests/
    UnitTestsDemo.UnitTests/
  UnitTestsDemo.sln
```

### UnitTestsDemo.Core

That's the **Domain Model** project. This project should contain all of your
Entities, Value Objects, and business logic.

### UnitTestsDemo.Infrastructure

This project **should depend** on Core project. In this project we have the **Use
Cases or Services** and the place where the abstractions lives.

### UnitTestsDemo.Web

It's the **Presentation** project built by **Razor Pages**. Here we can use any
framework to serve as the **UI layer**. You can use ASP.NET Core MVC, Blazor,
React, or other framework you prefer.

### UnitTestsDemo.UnitTests

It's the **Unit Tests** project, here I use the **`xUnit`** library with other
libraries like **Bogus** to create mocks of my tests.

Basically this project uses 3 patterns:

- [Factory Method](https://refactoring.guru/design-patterns/factory-method)
  >[!quote] Refactoring Guru
  > Is a **creational design pattern** that provides an interface for creating
  > objects...
- [Object Mother](https://martinfowler.com/bliki/ObjectMother.html)
  >[!quote] Martin Fowler
  > An object mother is a kind of class used in **testing** to help create **example
  > objects** that you use for testing...
- [Builder](https://refactoring.guru/design-patterns/builder)
  >[!quote] Refactoring Guru
  > Is a **creational design pattern** that lets you construct complex objects
  > step by step. The pattern allows you to produce different types and
  > representations of an object using the same construction code.

### IMPORTANT => Settings

Here are some `NuGet` packages that this project needs:

```sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
# if you're using a relational database
dotnet add package Microsoft.EntityFrameworkCore.Relational
# Database providers & scaffolding
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
# dotnet ef
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
```

With all installed the project is ready to run!

```sh
dotnet test
dotnet run --project src/UnitTestsDemo.Web
```

## 🔧 Building and Running

In VS 2022 just:

- Run the migrations:
    ```sh
    dotnet ef database update --startup-project .\src\UnitTestsDemo.Web\ --project .\src\UnitTestsDemo.Infrastructure\ --context AppDbContext
    ```
- Use/Select the `http` profile to avoid https warnings
- Ensure the ****`UnitTestsDemo.Web`**** is the Startup project.
- Menu Build > Build Solution
- Menu Debug > Start Debugging or type **`F5`**

Using the **dotnet cli**:

```sh
dotnet build
dotnet run --project src/UnitTestsDemo.Web
```

### 🔨 Build the Project

The steps bellow follows these guidelines:

- [Atomic commits](https://www.freshconsulting.com/insights/blog/atomic-commits/)
  >[!quote] Sean Patterson
  > An "atomic" change revolves around **one task or one fix**.
- [The 50/72 Rule of Git](https://deviq.com/practices/50-72-rule)
  >[!quote] DevIQ
  > The 50/72 rule **is a guideline** for **writing clear and concise Git commit
  > messages**.
- [How to Write a Git Commit Message](https://cbea.ms/git-commit/)
  >[!quote] CBEAMS
  > A well-crafted **Git commit message** is the best way to **communicate** *context*
  > about a change to fellow developers (and indeed to their future selves).
  > **A diff will tell you *what* changed, but only the commit message can
  > properly tell you *why***.

```sh
mkdir UnitTestsDemo
cd UnitTestsDemo
git init
dotnet new gitignore
git add .
git commit -m 'Initial commit'
dotnet new sln
git add .
git commit -m 'Add solution project file'
dotnet new editorconfig
git add .
git commit -m 'Add editorconfig file'
dotnet new readme
git add .
git commit -m 'Add README.md file'
mkdir src tests
dotnet new classlib -o src/UnitTestsDemo.Core
dotnet sln add src/UnitTestsDemo.Core/UnitTestsDemo.Core.csproj
git add .
git commit -m 'Add Core classlib project'
dotnet new classlib -o src/UnitTestsDemo.Infrastructure
dotnet sln add src/UnitTestsDemo.Infrastructure/UnitTestsDemo.Infrastructure.csproj
git add .
git commit -m 'Add Infrastructure classlib project'
dotnet new razor -o src/UnitTestsDemo.Web
dotnet sln add src/UnitTestsDemo.Web/UnitTestsDemo.Web.csproj
git add .
git commit -m 'Add Razor Pages project'
dotnet new xunit -o tests/UnitTestsDemo.UnitTests
dotnet sln add tests/UnitTestsDemo.UnitTests/UnitTestsDemo.UnitTests.csproj
git add .
git commit -m 'Add xUnit unit tests project'
```

## 🤝 Collaborate with My Project

Open a Issue if you want to discuss something 😄.

Feel free to Fork this project to add your ideas and send me a Pull Request
to be reviewed and merged.

## 🆘 Useful links

https://stackoverflow.com/questions/76964714/how-to-create-ef-core-migrations-while-using-clean-architecture-if-it-needs-to