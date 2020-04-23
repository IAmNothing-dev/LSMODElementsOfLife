using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.DeathPack.Potions
{
    public class AngryPotionBuff : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Angry");
            Description.SetDefault("Grants Melee speed and damage x2");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage *= 2;
            player.meleeSpeed *= 2;
        }
    }
}
