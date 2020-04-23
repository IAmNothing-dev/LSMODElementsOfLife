﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LSMODElementsOfLife.Items;


namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
    public class DeathArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death Arrow");

        }
        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 10;
            item.height = 27;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = ItemRarityID.Blue;
            item.shoot = mod.ProjectileType("DeathArrowProj");
            item.shootSpeed = 2f;
            item.ammo = 40;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 1);
            recipe.AddIngredient(ItemID.AshBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }
    }
}