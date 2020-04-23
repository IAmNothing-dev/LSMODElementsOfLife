using LSMODElementsOfLife.Dusts;
using LSMODElementsOfLife.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.WeaponsTier.BroadswordElemental
{
    public class BroadswordIceT2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Broadsword");
            Tooltip.SetDefault("Tier 2");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.melee = true;
            item.width = 49;
            item.height = 49;
            item.useTime = 30;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.IceEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.WeaponsTier.BroadswordElemental.BroadswordIceT1>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceOreDust>(), 5);
            recipe.AddIngredient(ItemID.IceBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
