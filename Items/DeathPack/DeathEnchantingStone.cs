using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.DeathPack
{

    public class DeathEnchantingStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death enchanting stone");
            Tooltip.SetDefault("Use it to give the power of Death");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 38;
            item.rare = 11;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.EmptyEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 5);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
}