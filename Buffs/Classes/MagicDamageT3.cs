using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class MagicDamageT3 : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Increase : Magic Damage Tier 3");
            Description.SetDefault("+4% Magic Damage");
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.magicDamage += 0.04f;
        }
    }
}