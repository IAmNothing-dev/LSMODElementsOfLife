using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.NPCs
{
    public class NpcDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == mod.NPCType("IceCrystalMob"))
            {
                if (Main.rand.Next(5) == 0)
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LSToken"), 1);
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DeathOreDust"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == mod.NPCType("IceGolem"))
            {
                if (Main.rand.Next(5) == 0)
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LSToken"), 1);
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DeathOreDust"), Main.rand.Next(1, 5));
                    }
                }
            }
            if (npc.type == mod.NPCType("IceBoss")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!LSMODElementsOfLifeWorld.spawnOre)
                {                                                          //Red  Green Blue
                    Main.NewText("The world has been blessed with Ice Crystals", 70, 255, 255);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(3, 5), WorldGen.genRand.Next(2, 4), (ushort)mod.TileType("IceCrystal"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }

                    Main.NewText("The world has been blessed with Death Ore", 125, 35, 110);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), (ushort)mod.TileType("DeathOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                LSMODElementsOfLifeWorld.spawnOre = true;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
        }
    }
}