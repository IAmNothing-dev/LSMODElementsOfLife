using LSMODElementsOfLife.Items;
using LSMODElementsOfLife.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;


namespace LSMODElementsOfLife
{
	public class LSMODElementsOfLifeWorld : ModWorld
	{
		public static bool downedIceBoss;

		public static bool spawnOre = false;

		public override void Initialize()
		{
			downedIceBoss = false;
		}

		public override TagCompound Save()
		{
			var downed = new List<string>();
			if (downedIceBoss)
			{
				downed.Add("IceBoss");
			}

			return new TagCompound
			{
				["downed"] = downed,
			};
		}

		public override void Load(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			downedIceBoss = downed.Contains("IceBoss");
		}

		public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
			if (loadVersion == 0)
			{
				BitsByte flags = reader.ReadByte();
				downedIceBoss = flags[0];
			}
			else
			{
				mod.Logger.WarnFormat("LSMODElementsOFLife: Unknown loadVersion: {0}", loadVersion);
			}
		}

		public override void NetSend(BinaryWriter writer)
		{
			var flags = new BitsByte();
			flags[0] = downedIceBoss;
			writer.Write(flags);
		}

		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			downedIceBoss = flags[0];
		}

		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{

			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Ice Ore", IceOres));
			}

			int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (genIndex == -1)
			{
				return;
			}
			tasks.Insert(genIndex + 1, new PassLegacy("Icy Biome", delegate (GenerationProgress progress)
			{
				progress.Message = "Icy Biome Progress";
				for (int i = 0; i < Main.maxTilesX / 750; i++)       //900 is how many biomes. the bigger is the number = less biomes
				{
					int X = WorldGen.genRand.Next(1, Main.maxTilesX - 100);
					int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - 100, Main.maxTilesY - 200);
					int TileType = mod.TileType("IcyGrassTile");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

					WorldGen.TileRunner(X, Y, 350, WorldGen.genRand.Next(100, 200), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.

				}

			}));
		}

		private void IceOres(GenerationProgress progress)
		{
			progress.Message = "Adding Ice Ores";

			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
			{

				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

				WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), TileType<Tiles.IcePack.Mineral.IceOre>(), false, 0f, 0f, false, true);

			}
		}

		//private void DeathOres(GenerationProgress progress)
		//{
		//	progress.Message = "Adding Death Ores";

		//	for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
		//	{
		//		int x = WorldGen.genRand.Next(0, Main.maxTilesX);
		//		int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);
		//		WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), TileType<Tiles.DeathPack.Mineral.DeathOre>(), false, 0f, 0f, false, true);
		//	}

		//}

		//private void IceCrystals(GenerationProgress progress)
		//{
		//	progress.Message = "Adding Ice Crystals";

		//	for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
		//	{
		//		int x = WorldGen.genRand.Next(0, Main.maxTilesX);
		//		int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

		//		WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 5), WorldGen.genRand.Next(2, 4), TileType<Tiles.IcePack.Mineral.IceCrystal>(), false, 0f, 0f, false, true);

		//	}
		//}

		private void DeathCrystals(GenerationProgress progress)
		{
			progress.Message = "Adding Death Crystals";
			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

				WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 5), WorldGen.genRand.Next(2, 4), TileType<Tiles.DeathPack.Mineral.DeathCrystal>(), false, 0f, 0f, false, true);

			}

		}
	}
}
