using LSMODElementsOfLife.Dusts;
using LSMODElementsOfLife.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Items;

namespace LSMODElementsOfLife.Items.WeaponsTier.BroadswordElemental
{
    public class BroadswordIceTFinal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice broadsword");
            Tooltip.SetDefault("Tier Final");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.melee = true;
            item.width = 49;
            item.height = 49;
            item.useTime = 30;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 10;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustType<IceDust>());
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.Frostburn, 450);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.IceEnchantingStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.WeaponsTier.BroadswordElemental.BroadswordIceT5>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 5);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 5);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceOreDust>(), 5);
            recipe.AddIngredient(ItemID.IceBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.EnchantingTable>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
