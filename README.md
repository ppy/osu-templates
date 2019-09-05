# osu-templates

Templates for use when creating osu! dependent projects. Create a fully-testable (and ready for git) custom ruleset in just two lines.

## Usage

```bash
# install (or update) templates package.
# this only needs to be done once
dotnet new -i ppy.osu.Game.Templates

# start a new empty ruleset...
dotnet new ruleset-scrolling -n MyCoolRuleset

# ..or start with a working sample game
dotnet new ruleset-scrolling-example -n MyCoolWorkingRuleset
```