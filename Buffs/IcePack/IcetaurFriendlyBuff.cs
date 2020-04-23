using Terraria;
using Terraria.ModLoader;
using LSMODElementsOfLife.Mounts;
namespace LSMODElementsOfLife.Buffs.IcePack
{
    public class IcetaurFriendlyBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Icetaur Friendly");
            Description.SetDefault("Summon a Icetaur Mount");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("IcetaurFriendly"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}