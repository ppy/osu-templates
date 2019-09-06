// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Empty.Replays
{
    public class EmptyReplayFrame : ReplayFrame
    {
        public List<EmptyAction> Actions = new List<EmptyAction>();

        public EmptyReplayFrame(EmptyAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
