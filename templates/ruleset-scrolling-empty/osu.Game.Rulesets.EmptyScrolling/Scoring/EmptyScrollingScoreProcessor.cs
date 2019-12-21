// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.EmptyScrolling.Scoring
{
    public class EmptyScrollingScoreProcessor : ScoreProcessor
    {
        public EmptyScrollingScoreProcessor(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void Reset(bool storeResults)
        {
            base.Reset(storeResults);

            Health.Value = 1;
            Accuracy.Value = 1;
        }
    }
}
