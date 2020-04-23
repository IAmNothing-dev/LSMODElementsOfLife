using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class RangedDamageTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Ranged Damage Tier Final");
            Description.SetDefault("+6% Ranged Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.rangedDamage += 0.06f;
        }
    }
}