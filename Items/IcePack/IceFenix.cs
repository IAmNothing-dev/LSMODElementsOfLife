using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack
{
    public class IceFenix : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Ice Guardian");
            Tooltip.SetDefault("Summon a pet - Ice Guardian.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("IceFenix");
            item.buffType = mod.BuffType("IceFenixBuff");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}