using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MinionTotalTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Minion Max Tier Final");
            Description.SetDefault("+5 Minions");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.maxMinions += 5;
        }
    }
}