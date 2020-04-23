using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Weapons
{
    public class IceThrown : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snowflake");
        }

        public override void SetDefaults()
        {
            item.damage = 25;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;       //this is how fast you use the item
            item.useAnimation = 10;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 0;
            item.value = 10;
            item.rare = 1;
            item.reuseDelay = 20;    //this is the item delay
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("IceThrownProj");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 999;       //this is the max stack of this item
            item.consumable = true;  //this make the item consumable when used
            item.noUseGraphic = true;

        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 1);
            recipe.AddIngredient(ItemID.IceBlock, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
}