using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownDamageMinionT3 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Minion Damage Tier 3");
            Description.SetDefault("-4% Minion Damage");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.minionDamage -= 0.04f;
        }
    }
}