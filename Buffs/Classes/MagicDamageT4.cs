using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MagicDamageT4 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Magic Damage Tier 4");
            Description.SetDefault("+5% Magic Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.magicDamage += 0.05f;
        }
    }
}