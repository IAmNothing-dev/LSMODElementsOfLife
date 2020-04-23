using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items
{

    public class LSToken : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LS Token");
            Tooltip.SetDefault("Use it to craft Special Contents of the Elements Of Life mod.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Expert;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}