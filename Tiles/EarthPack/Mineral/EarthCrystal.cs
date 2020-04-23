using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Tiles.EarthPack.Mineral
{
	public class EarthCrystal : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;		// The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 310;           // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true;			// Modifies the draw color slightly.
			Main.tileShine[Type] = 1500;			// How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Earth Crystal");
			AddMapEntry(new Color(115, 255, 70), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.EarthPack.Mineral.EarthCrystal>();
			soundType = 21;
			soundStyle = 1;
			mineResist = 1f;
			minPick = 50;
		}
	}
}