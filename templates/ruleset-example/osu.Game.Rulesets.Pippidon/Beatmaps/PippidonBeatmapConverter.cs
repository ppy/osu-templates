// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using System.Linq;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using osu.Game.Rulesets.Pippidon.Objects;
using osuTK;

namespace osu.Game.Rulesets.Pippidon.Beatmaps
{
    public class PippidonBeatmapConverter : BeatmapConverter<PippidonHitObject>
    {
        public override bool CanConvert() => Beatmap.HitObjects.All(h => h is IHasPosition);

        public PippidonBeatmapConverter(IBeatmap beatmap, Ruleset ruleset)
            : base(beatmap, ruleset)
        {
        }

        protected override IEnumerable<PippidonHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap)
        {
            yield return new PippidonHitObject
            {
                Samples = original.Samples,
                StartTime = original.StartTime,
                Position = (original as IHasPosition)?.Position ?? Vector2.Zero,
            };
        }
    }
}
