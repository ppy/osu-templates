// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.EmptyNonScrolling.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.EmptyNonScrolling.Replays
{
    public class EmptyNonScrollingAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<EmptyNonScrollingHitObject> Beatmap => (Beatmap<EmptyNonScrollingHitObject>)base.Beatmap;

        public EmptyNonScrollingAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new EmptyNonScrollingReplayFrame());

            foreach (EmptyNonScrollingHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new EmptyNonScrollingReplayFrame
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
