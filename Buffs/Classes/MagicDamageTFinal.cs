using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MagicDamageTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Magic Damage Tier Final");
            Description.SetDefault("+6% Magic Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.magicDamage += 0.06f;
        }
    }
}