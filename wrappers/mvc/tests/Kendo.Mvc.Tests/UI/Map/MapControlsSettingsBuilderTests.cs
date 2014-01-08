namespace Kendo.Mvc.UI.Tests.Map
{
    using System.Collections.Generic;
    using Xunit;
    using Kendo.Mvc.UI.Fluent;

    public class MapControlsSettingsBuilderTests
    {
        private readonly MapControlsSettings settings;
        private readonly MapControlsSettingsBuilder builder;

        public MapControlsSettingsBuilderTests()
        {
            settings = new MapControlsSettings();
            builder = new MapControlsSettingsBuilder(settings);
        }

        [Fact]
        public void Clears_attribution_settings()
        {
            builder.Attribution(false);
            settings.Attribution.ShouldBeNull();
        }

        [Fact]
        public void Sets_attribution_position()
        {
            builder.Attribution(cfg => cfg.Position(MapControlPosition.TopLeft));
            settings.Attribution.Position.ShouldEqual(MapControlPosition.TopLeft);
        }

        [Fact]
        public void Clears_navigator_settings()
        {
            builder.Navigator(false);
            settings.Navigator.ShouldBeNull();
        }

        [Fact]
        public void Sets_navigator_position()
        {
            builder.Navigator(cfg => cfg.Position(MapControlPosition.TopLeft));
            settings.Navigator.Position.ShouldEqual(MapControlPosition.TopLeft);
        }
    }
}