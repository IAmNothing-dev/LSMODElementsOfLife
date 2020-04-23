using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Tiles.IcePack.Placeable.Biome
{
	public class IcyGrassTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = false;
			drop = ItemType<Items.IcePack.Placeable.Biome.IcyDirt>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new IcyTreeTile());
		}

		//public override void ChangeWaterfallStyle(ref int style)
		//{
		//	style = mod.GetWaterfallStyleSlot("ExampleWaterfallStyle");
		//}

		public override int SaplingGrowthType(ref int style)
		{
			style = 0;
			return TileType<IcySaplingTile>();
		}
	}
}