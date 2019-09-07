// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Game.Rulesets.UI;
using osuTK;

namespace osu.Game.Rulesets.EmptyNonScrolling.UI
{
    public class EmptyNonScrollingCursorContainer : GameplayCursorContainer
    {
        // todo: add gameplay cursor
        protected override Drawable CreateCursor() => null;
    }
}
