using LSMODElementsOfLife.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Walls.DeathPack
{
	public class DeathOreBlockWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = ItemType<Items.DeathPack.Placeable.DeathOreBlockWall>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}