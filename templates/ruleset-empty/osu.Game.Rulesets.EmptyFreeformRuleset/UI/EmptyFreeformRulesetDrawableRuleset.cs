// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.EmptyFreeformRuleset.Objects;
using osu.Game.Rulesets.EmptyFreeformRuleset.Objects.Drawables;
using osu.Game.Rulesets.EmptyFreeformRuleset.Replays;
using osu.Game.Rulesets.EmptyFreeformRuleset.Scoring;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.EmptyFreeformRuleset.UI
{
    [Cached]
    public class DrawableEmptyFreeformRulesetRuleset : DrawableRuleset<EmptyFreeformRulesetHitObject>
    {
        public DrawableEmptyFreeformRulesetRuleset(EmptyFreeformRulesetRuleset ruleset, IWorkingBeatmap beatmap, IReadOnlyList<Mod> mods)
            : base(ruleset, beatmap, mods)
        {
        }

        public override ScoreProcessor CreateScoreProcessor() => new EmptyFreeformRulesetScoreProcessor(this);

        protected override Playfield CreatePlayfield() => new EmptyFreeformRulesetPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new EmptyFreeformRulesetFramedReplayInputHandler(replay);

        public override DrawableHitObject<EmptyFreeformRulesetHitObject> CreateDrawableRepresentation(EmptyFreeformRulesetHitObject h) => new DrawableEmptyFreeformRulesetHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new EmptyFreeformRulesetInputManager(Ruleset?.RulesetInfo);
    }
}
