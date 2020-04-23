using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
    public class DeathYoYo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demon eye");
        }

        public override void SetDefaults()
        {
            item.damage = 30;//The damage stat for the Weapon.
            item.melee = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.useTime = 22;  //How fast the Weapon is used.
            item.useAnimation = 22;   //How long the Weapon is used for.
            item.useStyle = 5;//The way your Weapon will be used, 1 is the regular sword swing for example
            item.channel = true;// We can keep the left mouse button down when trying to keep using this weapon.
            item.knockBack = 2f;//The knockback stat of your Weapon.
            item.value = Item.sellPrice(silver: 50);// How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 11;//The color the title of your Weapon when hovering over it ingame  
            item.autoReuse = false;  //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("DeathYoyoProj"); //This defines what type of projectile this weapon will shot            
            item.noUseGraphic = true; //  Do not use the item graphic when using the item (we just want the yoyo projectile to spawn).
            item.noMelee = true;// Makes sure that the animation when using the item doesn't hurt NPCs.
            item.UseSound = SoundID.Item1; //The sound played when using your Weapon     
            item.shootSpeed = 15;
            item.crit = 10;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 10);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
            //recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.LeadOre, 1);
            //recipe.AddIngredient(null, "ItemName", 1); 
            //recipe.SetResult(this);
            //recipe.AddRecipe();
        }
        
    }
}