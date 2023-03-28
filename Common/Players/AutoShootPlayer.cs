using AutoShooting.Common.Configs;
using Terraria;
using Terraria.ModLoader;

namespace AutoShooting.Common.Players;

public class AutoShootPlayer : ModPlayer
{
    public override bool? CanAutoReuseItem(Item item)
    {
        var config = ModContent.GetInstance<AutoShootConfig>();
        if (!config.EnableAutoShoot || !(item.DamageType == DamageClass.Magic ||
                                         item.DamageType == DamageClass.Ranged ||
                                         item.DamageType == DamageClass.Melee ||
                                         item.DamageType == DamageClass.MeleeNoSpeed ||
                                         item.damage > 0)) return base.CanAutoReuseItem(item);

        return true;
    }
}