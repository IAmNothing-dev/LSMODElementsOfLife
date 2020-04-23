using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Mineral
{

    public class IceOreDust : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Dust");
            Tooltip.SetDefault("use it to fuse the ice element");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 20;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceOre>(), 4);
            recipe.AddTile(ModContent.TileType<Tiles.Mortar>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}