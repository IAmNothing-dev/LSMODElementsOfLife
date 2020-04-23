using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
    public class DeathSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Tip");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 85;
            item.height = 85;
            item.maxStack = 1;
            item.useTime = 25;
            item.useAnimation = 38;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.shoot = mod.ProjectileType("DeathSpearProj");
            item.shootSpeed = 5f;
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