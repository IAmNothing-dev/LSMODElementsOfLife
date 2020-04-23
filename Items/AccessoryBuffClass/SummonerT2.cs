using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.AccessoryBuffClass
{
    public class SummonerT2 : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Class : Summoner");
            Tooltip.SetDefault("Increase : Minion Max - \n Decrease Minion Damage\nTier 2");
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
            player.AddBuff(mod.BuffType("MinionTotalT2"), 6000, true);
            //player.statDefense += 10;
            player.AddBuff(mod.BuffType("DownDamageMinionT2"), 6000, true);
            //player.meleeSpeed -= 0.02f;
            //player.AddBuff(mod.BuffType("DownMeleeSpeedT1"), 6000, true);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ModContent.ItemType<Items.EmptyEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 10);
            recipe.AddIngredient(ItemID.Amethyst, 10);
            recipe.AddIngredient(ItemID.Topaz, 10);
            recipe.AddIngredient(ItemID.Emerald, 10);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}