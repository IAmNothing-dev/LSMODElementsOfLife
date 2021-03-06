using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DefenseT1 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Defense Tier 1");
            Description.SetDefault("+10 Defense");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.statDefense += 10;
        }
    }
}