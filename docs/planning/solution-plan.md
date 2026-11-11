# Solution plan

## The repository as found

mvcarchitecture is an ASP.NET MVC 5 store on .NET Framework 4.5.1: four
non-SDK projects (ToolsVersion 12.0) in Store.sln at the root — Store.Model
(entities), Store.Data (Entity Framework 6 repositories), Store.Service
(services over the repositories, such as `GadgetService`) and Store.Web
(controllers under Controllers\, views under Views\, the navigation in
Views\Shared\_Layout.cshtml) — restoring from `packages.config`, with the
restored packages now ignored as the `.gitignore` template intends. The
compile control in `dabbler.yaml` builds Store.sln with MSBuild. There are
no tests and no test suite. All of this is kept: no target, format,
package or folder changes.

## Change 1: an online calculator page, and the first tests

**What changes.** Store.Service gains `CalculatorService.cs` (add and
subtract two decimals), listed as a `Compile` item. Store.Web gains
Controllers\CalculatorController.cs (a GET `Index` showing the form and a
POST `Index` showing the sum and the difference, using the service) and
Views\Calculator\Index.cshtml, listed as `Compile` and `Content` items,
and a Calculator link in the layout. The repository's first tests are a
new non-SDK project, Store.Service.Tests\Store.Service.Tests.csproj, a
v4.5.1 class library in the same format as its siblings, listed in
Store.sln, with a project reference to Store.Service and MSTest's
`MSTest.TestFramework` and `MSTest.TestAdapter` from its `packages.config`;
`CalculatorServiceTests.cs` tests add and subtract. Session 3, which adds
the project, declares its suite in `dabbler.yaml`: vstest over the test
assembly, which the adapter makes discoverable.

**How it is shown to work.** The compile control's MSBuild build of
Store.sln, and `CalculatorServiceTests` passing under vstest.

## Change 2: documentation comments

**What changes.** XML documentation comments on `CalculatorService`, its
methods, `CalculatorController` and both `Index` actions, and a Razor
comment at the top of the view. No code, markup or project file changes.

**How it is shown to work.** The same build and test run, and a diff that
contains only comment lines.

## Out of scope

Retargeting, reformatting or upgrading any project or package; a release.
