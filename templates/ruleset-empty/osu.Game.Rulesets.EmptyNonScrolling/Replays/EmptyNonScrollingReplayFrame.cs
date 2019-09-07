// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.EmptyNonScrolling.Replays
{
    public class EmptyNonScrollingReplayFrame : ReplayFrame
    {
        public List<EmptyNonScrollingAction> Actions = new List<EmptyNonScrollingAction>();

        public EmptyNonScrollingReplayFrame(EmptyNonScrollingAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
