using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack
{

    public class IceEnchantingStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice enchanting stone");
            Tooltip.SetDefault("Use it to give the power of ice");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 38;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ModContent.ItemType<Items.EmptyEnchantingStone>(), 1);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}