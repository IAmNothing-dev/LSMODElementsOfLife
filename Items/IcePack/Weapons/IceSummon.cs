using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Weapons
{
    public class IceSummon : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Call of Metal Ice");
            Tooltip.SetDefault("Summons a minion to fight for you.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 28;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("MetalIceName");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
            item.buffType = mod.BuffType("MetalIceBuff");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 8);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}