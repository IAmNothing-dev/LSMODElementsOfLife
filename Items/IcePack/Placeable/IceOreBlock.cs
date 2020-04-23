using LSMODElementsOfLife.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace LSMODElementsOfLife.Items.IcePack.Placeable
{
	public class IceOreBlock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice ore block");
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
			item.createTile = TileType<Tiles.IcePack.Placeable.IceOreBlock>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceOre>(), 1);
			recipe.AddIngredient(ItemID.IceBlock, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Placeable.IceOreBlockWall>(), 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}