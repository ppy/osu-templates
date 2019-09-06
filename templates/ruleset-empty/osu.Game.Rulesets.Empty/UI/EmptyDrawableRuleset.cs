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
using osu.Game.Rulesets.Empty.Objects;
using osu.Game.Rulesets.Empty.Objects.Drawables;
using osu.Game.Rulesets.Empty.Replays;
using osu.Game.Rulesets.Empty.Scoring;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Empty.UI
{
    [Cached]
    public class DrawableEmptyRuleset : DrawableRuleset<EmptyHitObject>
    {
        public DrawableEmptyRuleset(EmptyRuleset ruleset, IWorkingBeatmap beatmap, IReadOnlyList<Mod> mods)
            : base(ruleset, beatmap, mods)
        {
        }

        public override ScoreProcessor CreateScoreProcessor() => new EmptyScoreProcessor(this);

        protected override Playfield CreatePlayfield() => new EmptyPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new EmptyFramedReplayInputHandler(replay);

        public override DrawableHitObject<EmptyHitObject> CreateDrawableRepresentation(EmptyHitObject h) => new DrawableEmptyHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new EmptyInputManager(Ruleset?.RulesetInfo);
    }
}
