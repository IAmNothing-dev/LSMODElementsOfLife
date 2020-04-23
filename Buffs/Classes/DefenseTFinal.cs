using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DefenseTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Defense Tier Final");
            Description.SetDefault("+30 Defense");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.statDefense += 30;
        }
    }
}