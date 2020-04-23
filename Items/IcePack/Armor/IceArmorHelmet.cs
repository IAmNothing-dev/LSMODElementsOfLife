using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class IceArmorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice helmet");
            Tooltip.SetDefault("Immune : Frozen\nMelee Damage 5%\nTier 1");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;

        }
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Frozen] = true;
            player.meleeDamage += 0.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("IceArmorChestplate") && legs.type == mod.ItemType("IceArmorLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {

            player.AddBuff(BuffID.Warmth, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 20);
            recipe.AddIngredient(ItemID.IceBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}