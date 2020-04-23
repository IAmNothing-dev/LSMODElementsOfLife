using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MinionTotalT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Minion Max Tier 2");
            Description.SetDefault("+2 Minions");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.maxMinions += 2;
        }
    }
}