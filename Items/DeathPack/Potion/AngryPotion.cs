using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Buffs;

namespace LSMODElementsOfLife.Items.DeathPack.Potion
{
    public class AngryPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angry Potion");
            Tooltip.SetDefault("Grants Melee speed and damage x2");
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
            item.rare = 11;
            item.value = Item.sellPrice(silver: 50);
            item.buffType = BuffType<Buffs.DeathPack.Potions.AngryPotionBuff>(); //Specify an existing buff to be applied when used.
            item.buffTime = 4800; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.Ebonkoi, 1);
            recipe.AddIngredient(ItemID.Daybloom, 1);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
