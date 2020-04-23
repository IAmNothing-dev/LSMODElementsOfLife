using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LSMODElementsOfLife.Dusts;

namespace LSMODElementsOfLife.Items.IcePack.Weapons
{
    public class IceScythe : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cold Claw");
            Tooltip.SetDefault("Chance to regen health quickly upon hit.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DeathSickle);
            item.shootSpeed *= 1.75f;
            item.shoot = mod.ProjectileType("IceScytheProj");
            item.damage = 25; // The damage your item deals
            item.melee = true; // Whether your item is part of the melee class
            item.width = 40; // The item texture's width
            item.height = 40; // The item texture's height
            item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
            item.knockBack = 5; // The force of knockback of the weapon. Maximum is 20
            item.value = Item.sellPrice(5000); // The value of the weapon in copper coins
            item.rare = 1; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
            item.UseSound = SoundID.Item1; // The sound when the weapon is being used
            item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button
            item.crit = 10; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
            // 60 frames = 1 second
            player.onHitRegen = true;
            target.AddBuff(BuffID.Frostburn, 400);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 10);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}