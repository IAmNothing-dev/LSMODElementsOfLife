using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.NPCs.IcePack
{

	public class IceCrystalMob : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icetaur");
		}

		public override void SetDefaults()
		{
			npc.width = 45;
			npc.height = 57;
			npc.damage = 10;
			npc.defense = 8;
			npc.lifeMax = 125;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitIcetaur");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathIcetaur");
			npc.value = 60f;
			npc.knockBackResist = 0.05f;
			npc.aiStyle = 3;
			aiType = NPCID.DD2WitherBeastT2;
			animationType = NPCID.DD2WitherBeastT2;
			Main.npcFrameCount[npc.type] = 17;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.1f : 0.1f;
		}
	}
}
