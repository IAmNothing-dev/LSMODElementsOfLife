using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.Classes
{
    public class DownManacostTFinal : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Decrease : Mana cost Tier Final");
            Description.SetDefault("-6% Mana cost");
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 1;
            player.manaCost -= 0.06f;
        }
    }
}