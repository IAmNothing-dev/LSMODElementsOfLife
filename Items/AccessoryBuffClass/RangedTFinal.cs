using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.AccessoryBuffClass
{
    public class RangedTFinal : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Class : Ranged");
            Tooltip.SetDefault("Increase : Ranged damage - \n Decrease : Defense\nTier Final");
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
            player.AddBuff(mod.BuffType("RangedDamageTFinal"), 6000, true);
            //player.statDefense += 10;
            player.AddBuff(mod.BuffType("DownDefenseTFinal"), 6000, true);
            //player.meleeSpeed -= 0.02f;
            //player.AddBuff(mod.BuffType("DownMeleeSpeedT1"), 6000, true);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ModContent.ItemType<Items.EmptyEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 25);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathCrystal>(), 25);
            recipe.AddIngredient(ItemID.Amethyst, 25);
            recipe.AddIngredient(ItemID.Topaz, 25);
            recipe.AddIngredient(ItemID.Emerald, 25);
            recipe.AddIngredient(ItemID.Sapphire, 25);
            recipe.AddIngredient(ItemID.Ruby, 25);
            recipe.AddIngredient(ItemID.Diamond, 25);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}