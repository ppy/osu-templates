// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.EmptyFreeformRuleset.Objects;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.EmptyFreeformRuleset.Scoring
{
    public class EmptyFreeformRulesetScoreProcessor : ScoreProcessor<EmptyFreeformRulesetHitObject>
    {
        public EmptyFreeformRulesetScoreProcessor(DrawableRuleset<EmptyFreeformRulesetHitObject> ruleset)
            : base(ruleset)
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