using LSMODElementsOfLife.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace LSMODElementsOfLife.Items.DeathPack.Placeable
{
	public class DeathOreBlock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death ore block");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = TileType<Tiles.DeathPack.Placeable.DeathOreBlock>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathOre>(), 1);
			recipe.AddIngredient(ItemID.AshBlock, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Placeable.DeathOreBlockWall>(), 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}