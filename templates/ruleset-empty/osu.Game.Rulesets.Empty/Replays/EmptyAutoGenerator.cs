// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.Empty.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Empty.Replays
{
    public class EmptyAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<EmptyHitObject> Beatmap => (Beatmap<EmptyHitObject>)base.Beatmap;

        public EmptyAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new EmptyReplayFrame());

            foreach (EmptyHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new EmptyReplayFrame
                {
                    Time = hitObject.StartTime,
                    // todo: add required inputs and extra frames.
                });
            }

            return Replay;
        }
    }
}
