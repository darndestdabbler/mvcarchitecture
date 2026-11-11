# Brief

Two changes to mvcarchitecture, each its own session, inside the
repository's existing shape: an ASP.NET MVC 5 store on .NET Framework
4.5.1, four non-SDK projects in Store.sln at the root (Store.Model,
Store.Data, Store.Service, Store.Web), `packages.config` restore, and no
tests today.

1. **An online calculator page.** A page that takes two numbers and shows
   their sum and their difference (add and subtract): the arithmetic as a
   `CalculatorService` in Store.Service beside the other services, a
   `CalculatorController` and its `Index` view in Store.Web, reached by the
   default route, and a navigation link. Its tests are the repository's
   first: a new non-SDK MSTest project, Store.Service.Tests, targeting
   v4.5.1 like the rest, listed in Store.sln, referencing Store.Service,
   with MSTest's framework and adapter from `packages.config`, run by
   vstest; the session that adds it declares its suite in `dabbler.yaml`.
   Every new file is listed in its project's `.csproj`.
2. **Documentation comments.** XML documentation comments on the types and
   public members the calculator change added, and a Razor comment at the
   top of its view. Nothing else changes: no code, no markup, no project
   file.

Out of scope: retargeting, reformatting or upgrading any project or
package; a release. The machine has no 4.5.1 targeting pack installed, and
builds against Microsoft's Microsoft.NETFramework.ReferenceAssemblies.net451
package through TargetFrameworkRootPath.
