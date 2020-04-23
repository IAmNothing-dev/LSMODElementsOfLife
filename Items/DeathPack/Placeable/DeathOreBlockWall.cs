using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.DeathPack.Placeable
{
	public class DeathOreBlockWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death ore wall");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = WallType<Walls.DeathPack.DeathOreBlockWall>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Placeable.DeathOreBlock>(), 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}