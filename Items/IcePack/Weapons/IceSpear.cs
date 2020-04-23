using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LSMODElementsOfLife.Dusts;

namespace LSMODElementsOfLife.Items.IcePack.Weapons
{
    public class IceSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pierces ice");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 85;
            item.height = 85;
            item.scale = 1.1f;
            item.maxStack = 1;
            item.useTime = 25;
            item.useAnimation = 30;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.shoot = mod.ProjectileType("IceSpearProj");
            item.shootSpeed = 5f;
            item.crit = 10;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.Frostburn, 400);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 10);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}