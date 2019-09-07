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
using osu.Game.Rulesets.EmptyNonScrolling.Objects;
using osu.Game.Rulesets.EmptyNonScrolling.Objects.Drawables;
using osu.Game.Rulesets.EmptyNonScrolling.Replays;
using osu.Game.Rulesets.EmptyNonScrolling.Scoring;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.EmptyNonScrolling.UI
{
    [Cached]
    public class DrawableEmptyNonScrollingRuleset : DrawableRuleset<EmptyNonScrollingHitObject>
    {
        public DrawableEmptyNonScrollingRuleset(EmptyNonScrollingRuleset ruleset, IWorkingBeatmap beatmap, IReadOnlyList<Mod> mods)
            : base(ruleset, beatmap, mods)
        {
        }

        public override ScoreProcessor CreateScoreProcessor() => new EmptyNonScrollingScoreProcessor(this);

        protected override Playfield CreatePlayfield() => new EmptyNonScrollingPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new EmptyNonScrollingFramedReplayInputHandler(replay);

        public override DrawableHitObject<EmptyNonScrollingHitObject> CreateDrawableRepresentation(EmptyNonScrollingHitObject h) => new DrawableEmptyNonScrollingHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new EmptyNonScrollingInputManager(Ruleset?.RulesetInfo);
    }
}
