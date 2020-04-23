using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MeleeDamageTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Melee Damage Tier Final");
            Description.SetDefault("+6% Melee Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.meleeDamage += 0.06f;
        }
    }
}