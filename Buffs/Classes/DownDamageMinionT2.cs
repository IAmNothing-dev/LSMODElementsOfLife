using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownDamageMinionT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Minion Damage Tier 2");
            Description.SetDefault("-3% Minion Damage");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.minionDamage -= 0.03f;
        }
    }
}