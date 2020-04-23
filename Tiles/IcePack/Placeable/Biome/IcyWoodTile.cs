using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Tiles.IcePack.Placeable.Biome
{
	public class IcyWoodTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			drop = ItemType<Items.IcePack.Placeable.IcyWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new IcyTreeTile());
		}
	}
}