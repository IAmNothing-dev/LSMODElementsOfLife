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
using LSMODElementsOfLife.Dusts;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
    public class DeathRapier : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silence");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 38;
            item.rare = 11;
            item.value = Item.sellPrice(silver: 50);

            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.UseSound = SoundID.Item1;

            item.autoReuse = true;
            item.useTurn = true;
            item.melee = true;
            item.damage = 20;
            item.knockBack = 1.5f;
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