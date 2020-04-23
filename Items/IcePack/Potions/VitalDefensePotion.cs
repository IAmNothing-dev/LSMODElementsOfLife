using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Buffs;

namespace LSMODElementsOfLife.Items.IcePack.Potions
{
    public class VitalDefensePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vital Defense");
            Tooltip.SetDefault("Grants 15+ defense and a small life regeneration");
        }

        public override void SetDefaults()
        {
            item.width = 35;
            item.height = 35;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 50);
            item.buffType = BuffType<Buffs.IcePack.Potions.VitalDefenseBuff>(); //Specify an existing buff to be applied when used.
            item.buffTime = 4800; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.Daybloom, 2);
            recipe.AddIngredient(ItemID.IronOre, 1);
            recipe.AddIngredient(ItemID.Mushroom, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.Daybloom, 2);
            recipe.AddIngredient(ItemID.LeadOre, 1);
            recipe.AddIngredient(ItemID.Mushroom, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
