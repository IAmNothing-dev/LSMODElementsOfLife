using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DefenseT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Defense Tier 2");
            Description.SetDefault("+15 Defense");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.statDefense += 15;
        }
    }
}