using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownDefenseT4 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Defense Tier 4");
            Description.SetDefault("-25 Defense");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.statDefense -= 25;
        }
    }
}