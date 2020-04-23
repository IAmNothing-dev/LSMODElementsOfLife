using LSMODElementsOfLife.Tiles;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack.Placeable
{
	public class IcyWood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icy wood");
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
			item.createTile = TileType<Tiles.IcePack.Placeable.Biome.IcyWoodTile>();
		}
	}
}