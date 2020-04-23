using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Tiles.IcePack.Mineral
{
	public class IceOre : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 310;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ice Ore");
			AddMapEntry(new Color(35, 105, 125), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.IcePack.Mineral.IceOre>();
			soundType = 21;
			soundStyle = 1;
			mineResist = 4f;
			minPick = 40;
		}
	}
}