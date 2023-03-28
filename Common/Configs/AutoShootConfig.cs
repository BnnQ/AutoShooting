using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace AutoShooting.Common.Configs;

public class AutoShootConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Label(label: "Включить автострельбу")]
    [Tooltip(tooltip: "Эта настройка включает автострельбу")]
    [DefaultValue(value: true)]
    public bool EnableAutoShoot { get; set; }
}