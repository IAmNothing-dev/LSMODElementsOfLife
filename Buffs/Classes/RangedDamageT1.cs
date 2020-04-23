using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class RangedDamageT1 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Ranged Damage Tier 1");
            Description.SetDefault("+2% Ranged Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.rangedDamage += 0.02f;
        }
    }
}