using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MinionTotalT1 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Minion Max Tier 1");
            Description.SetDefault("+1 Minion");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.maxMinions += 1;
        }
    }
}