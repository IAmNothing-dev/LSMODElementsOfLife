using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.AccessoryBuffClass
{
    public class WarriorT4 : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Class : Warrior");
            Tooltip.SetDefault("Incrase : Melee Damage - Defense\n Decrease Melee Speed\nTier 4");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 62;
            item.value = 10;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //player.meleeDamage += 0.02f;
            player.AddBuff(mod.BuffType("MeleeDamageT4"), 6000, true);
            //player.statDefense += 10;
            player.AddBuff(mod.BuffType("DefenseT4"), 6000, true);
            //player.meleeSpeed -= 0.02f;
            player.AddBuff(mod.BuffType("DownMeleeSpeedT4"), 6000, true);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ModContent.ItemType<Items.EmptyEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 20);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathCrystal>(), 20);
            recipe.AddIngredient(ItemID.Amethyst, 20);
            recipe.AddIngredient(ItemID.Topaz, 20);
            recipe.AddIngredient(ItemID.Emerald, 20);
            recipe.AddIngredient(ItemID.Sapphire, 20);
            recipe.AddIngredient(ItemID.Ruby, 20);
            recipe.AddIngredient(ItemID.Diamond, 20);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}