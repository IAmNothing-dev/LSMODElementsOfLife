using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MinionTotalT4 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Minion Max Tier 4");
            Description.SetDefault("+4 Minions");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.maxMinions += 4;
        }
    }
}