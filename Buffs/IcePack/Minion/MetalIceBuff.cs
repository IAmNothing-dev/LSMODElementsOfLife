using System;
using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.IcePack.Minion
{
    public class MetalIceBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Metal Ice");
            Description.SetDefault("Metal Ice summon");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("MetalIceName")] > 0)
            {
                modPlayer.minionName = true;
            }
            if (!modPlayer.minionName)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}