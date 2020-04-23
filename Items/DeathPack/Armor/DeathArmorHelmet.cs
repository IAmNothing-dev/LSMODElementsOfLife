using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.DeathPack.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DeathArmorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death helmet");
            Tooltip.SetDefault("Immune : Obstructed\nMelee Damage 5%\nTier 1");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 11;
            item.defense = 4;

        }
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Obstructed] = true;
            player.meleeDamage += 0.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DeathArmorChestplate") && legs.type == mod.ItemType("DeathArmorLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {

            player.AddBuff(BuffID.ObsidianSkin, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 20);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}