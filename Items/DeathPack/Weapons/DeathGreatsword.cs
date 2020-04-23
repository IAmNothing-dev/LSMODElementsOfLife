using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Dusts;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
    public class DeathGreatsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heavy dark");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 80;
            item.height = 90;
            item.useTime = 30;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.useTurn = false;
            item.crit = 10;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.DeathDust>());
            }
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