using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack
{
    public class IceGhost : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Ice Guardian");
            Tooltip.SetDefault("Summon a pet - Icy Ghost.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("IceGhost");
            item.buffType = mod.BuffType("IceGhostBuff");
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