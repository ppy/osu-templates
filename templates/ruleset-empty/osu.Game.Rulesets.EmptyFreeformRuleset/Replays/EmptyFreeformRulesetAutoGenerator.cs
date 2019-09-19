// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.EmptyFreeformRuleset.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.EmptyFreeformRuleset.Replays
{
    public class EmptyFreeformRulesetAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<EmptyFreeformRulesetHitObject> Beatmap => (Beatmap<EmptyFreeformRulesetHitObject>)base.Beatmap;

        public EmptyFreeformRulesetAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new EmptyFreeformRulesetReplayFrame());

            foreach (EmptyFreeformRulesetHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new EmptyFreeformRulesetReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }

            return Replay;
        }
    }
}
