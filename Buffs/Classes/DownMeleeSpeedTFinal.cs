using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownMeleeSpeedTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Melee Speed Tier Final");
            Description.SetDefault("-6% Melee Speed");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.meleeSpeed -= 0.06f;
        }
    }
}