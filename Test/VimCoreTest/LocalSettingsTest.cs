﻿using Xunit;

namespace Vim.UnitTest
{
    public sealed class LocalSettingsTest
    {
        private readonly IVimGlobalSettings _globalSettings;
        private readonly IVimLocalSettings _localSettings;
        private readonly LocalSettings _localSettingsRaw;

        public LocalSettingsTest()
        {
            _globalSettings = new GlobalSettings();
            _localSettingsRaw = new LocalSettings(_globalSettings);
            _localSettings = _localSettingsRaw;
        }

        [Fact]
        public void ShiftWidthDefaultValue()
        {
            Assert.Equal(8, _localSettings.ShiftWidth);
        }

        [Fact]
        public void Sanity()
        {
            Assert.Same(_globalSettings, _localSettings.GlobalSettings);
        }
    }
}
