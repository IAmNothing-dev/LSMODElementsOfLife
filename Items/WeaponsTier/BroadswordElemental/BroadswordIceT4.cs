using LSMODElementsOfLife.Dusts;
using LSMODElementsOfLife.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.WeaponsTier.BroadswordElemental
{
    public class BroadswordIceT4 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice broadsword");
            Tooltip.SetDefault("Tier 4");
        }

        public override void SetDefaults()
        {
            item.damage = 33;
            item.melee = true;
            item.width = 49;
            item.height = 49;
            item.useTime = 30;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.IceEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.WeaponsTier.BroadswordElemental.BroadswordIceT3>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 5);
            recipe.AddIngredient(ItemID.IceBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
