# osu-templates

Templates for use when creating osu! dependent projects. Create a fully-testable (and ready for git) custom ruleset in just two lines.

## Usage

```bash
# install (or update) templates package.
dotnet new -i ppy.osu.Game.Templates

# start empty
dotnet new ruleset-scrolling -n MyCoolRuleset

# or start with a working sample game
dotnet new ruleset-scrolling-example -n MyCoolWorkingRuleset
```