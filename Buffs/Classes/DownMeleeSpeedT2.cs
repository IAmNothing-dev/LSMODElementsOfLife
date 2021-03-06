using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownMeleeSpeedT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Melee Speed Tier 2");
            Description.SetDefault("-3% Melee Speed");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.meleeSpeed -= 0.03f;
        }
    }
}