using System;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.IcePack.Potions
{
    public class VitalDefenseBuff : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Vital defense");
            Description.SetDefault("Grants 15+ defense and a small life regeneration");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen = +10;
            player.statDefense += 15;
        }
    }
}
