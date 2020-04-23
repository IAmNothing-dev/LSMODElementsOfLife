using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Tiles.DeathPack.Mineral
{
	public class DeathOre : ModTile
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
			name.SetDefault("Death Ore");
			AddMapEntry(new Color(125, 35, 110), name);

			dustType = 84;
			drop = ModContent.ItemType<Items.DeathPack.Mineral.DeathOre>();
			soundType = 21;
			soundStyle = 1;
			mineResist = 4f;
			minPick = 50;
		}
	}
}