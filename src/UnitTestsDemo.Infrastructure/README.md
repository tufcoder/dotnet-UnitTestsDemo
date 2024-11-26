# Infrastructure Project

In Clean Architecture, Infrastructure concerns are kept separte from the core business rules (or domain model in DDD).

The only project that should have code concerned with EF, Files, Email, Web Services, Azure/AWS/GCP, etc is Infrastructure.

Infrastructure should depend on Core (and, optionally, Use Cases/Services) where abstractions (interfaces) exists.

Infrastructure classes implement interfaces found in Core (Use Cases/Services) project(s).

These implementations are wired up at startup using DI. In this case using `Microsoft.Extensions.DependencyInjection` and extension methods defined in each project.
