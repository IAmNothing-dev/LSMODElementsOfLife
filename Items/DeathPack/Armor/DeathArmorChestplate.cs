using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.DeathPack.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class DeathArmorChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Death chestplate");
            Tooltip.SetDefault("Immune : Shadow Flame\nMelee Damage 2%\nTier 1");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.defense = 5; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.meleeDamage += 0.02f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 30);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}