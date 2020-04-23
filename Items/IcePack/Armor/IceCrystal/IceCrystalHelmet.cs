using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Armor.IceCrystal
{
    [AutoloadEquip(EquipType.Head)]
    public class IceCrystalHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice crystal helmet");
            Tooltip.SetDefault("Immune : Frozen\nMelee Damage 10%\nTier 2");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.defense = 7;

        }
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Frozen] = true;
            player.meleeDamage += 0.10f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("IceCrystalChestplate") && legs.type == mod.ItemType("IceCrystalLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Thorns, Extra Life, Ice resistance";
            player.AddBuff(BuffID.Warmth, 1);
            player.thorns = 0.5f;
            player.statLifeMax2 += 100;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Armor.IceArmorHelmet>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceCrystal>(), 20);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}