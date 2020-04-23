using LSMODElementsOfLife.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Walls.IcePack
{
	public class IceOreBlockWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = ItemType<Items.IcePack.Placeable.IceOreBlockWall>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}