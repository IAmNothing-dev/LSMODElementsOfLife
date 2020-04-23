using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MeleeDamageT2 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Melee Damage Tier 2");
            Description.SetDefault("+3% Melee Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.meleeDamage += 0.03f;
        }
    }
}