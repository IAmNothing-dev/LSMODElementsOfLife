using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack
{
    public class PikaflyCall : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pikafly");
            Tooltip.SetDefault("Summon a pet - Pikafly.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("Pikafly");
            item.buffType = mod.BuffType("PikaflyBuff");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.LSToken>(), 150);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
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