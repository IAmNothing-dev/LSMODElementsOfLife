using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.NPCs.IcePack
{

	public class IceGolem : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Golem");
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 150;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitIceBoss");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathIceBossMinion");
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 84;
			aiType = NPCID.EnchantedSword;
			animationType = NPCID.EnchantedSword;
			Main.npcFrameCount[npc.type] = 20;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.1f : 0.1f;
		}
	}
}
