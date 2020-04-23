using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{

    public class DeathBow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demoniac Claw");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(30, 53);
            item.rare = 11;
            item.value = Item.sellPrice(silver: 50);

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.autoReuse = true;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 30;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 8.5f;
            item.crit = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 10);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}