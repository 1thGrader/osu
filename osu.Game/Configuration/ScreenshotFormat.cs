﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Localisation;
using osu.Game.Localisation;

namespace osu.Game.Configuration
{
    public enum ScreenshotFormat
    {
        [LocalisableDescription(typeof(GraphicsSettingsStrings), nameof(GraphicsSettingsStrings.JPG))]
        Jpg = 1,

        [LocalisableDescription(typeof(GraphicsSettingsStrings), nameof(GraphicsSettingsStrings.PNG))]
        Png = 2
    }
}
