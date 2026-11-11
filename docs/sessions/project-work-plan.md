# Project work plan — sessions

**Written by `dabbler` as a fold of `activity-log.json`.**
Hand edits are overwritten by the next append. The record is the log;
this page is one view of it.

---

## Sessions

The numbered sessions are declared from `session-plan.md`; each one's task is what its own plan step declared.

| # | Session | Releasable | Declared |
| ---: | --- | --- | --- |
| 1 | Author or import the change plan | no | 2026-11-10 |
| 2 | Break the change plan into numbered sessions | no | 2026-11-10 |
| 3 | The calculator page and the first tests | no | 2026-11-10 |
| 4 | Documentation comments on the calculator | — | not declared |

### Session 1 — Author or import the change plan

**Releasable: no.**

Session 1 writes docs/planning/solution-plan.md from docs/planning/brief.md and nothing else: one paragraph on the repository as found -- an ASP.NET MVC 5 store on .NET Framework 4.5.1, four non-SDK projects in Store.sln at the root (Store.Model, Store.Data, Store.Service, Store.Web) restoring from packages.config, built by the compile control's MSBuild, and no tests or test suite -- and one section per change: the calculator page (CalculatorService in Store.Service, CalculatorController and Views/Calculator/Index.cshtml in Store.Web, a navigation link, every new file listed in its .csproj, and the repository's first tests, a non-SDK MSTest project Store.Service.Tests at v4.5.1 in Store.sln with MSTest's framework and adapter from packages.config, run by vstest, whose suite the same session declares in dabbler.yaml) and the documentation comments on what it added.

### Session 2 — Break the change plan into numbered sessions

**Releasable: no.**

Session 2 appends two numbered sessions to docs/sessions/session-plan.md from docs/planning/solution-plan.md and writes nothing else: Session 3, the calculator page and the repository's first tests -- CalculatorService in Store.Service, CalculatorController and its view in Store.Web, a navigation link, the non-SDK MSTest project Store.Service.Tests at v4.5.1 listed in Store.sln, and its vstest suite declared in dabbler.yaml -- and Session 4, XML documentation comments on what session 3 added and a Razor comment atop its view. Every new file is listed in its project's .csproj. No release session is planned, because the brief names none.

### Session 3 — The calculator page and the first tests

**Releasable: no.**

Session 3 adds an online calculator page and the repository's first tests to mvcarchitecture inside its existing shape, at .NET Framework 4.5.1: Store.Service/CalculatorService.cs (ICalculatorService and CalculatorService with Add and Subtract, registered by the existing *Service convention), Store.Web/Controllers/CalculatorController.cs (GET and POST Index through the service) and Store.Web/Views/Calculator/Index.cshtml, each listed in its .csproj, a Calculator link in the layout; the non-SDK MSTest project Store.Service.Tests (ToolsVersion 12.0 like its siblings, v4.5.1, packages.config with MSTest.TestFramework and MSTest.TestAdapter 2.2.10, a project reference to Store.Service) with CalculatorServiceTests.cs, listed in Store.sln; and its dotnet-framework suite in dabbler.yaml, vstest over the test assembly with a TestCaseFilter select. Each step is shown by the compile control's own MSBuild command, and the tests by vstest.
