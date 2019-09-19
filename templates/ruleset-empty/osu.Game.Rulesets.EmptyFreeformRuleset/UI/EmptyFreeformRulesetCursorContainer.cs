// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.EmptyFreeformRuleset.UI
{
    public class EmptyFreeformRulesetCursorContainer : GameplayCursorContainer
    {
        // todo: add gameplay cursor
        protected override Drawable CreateCursor() => null;
    }
}
