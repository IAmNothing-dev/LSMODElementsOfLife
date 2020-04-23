using Terraria;
using Terraria.ModLoader;
using LSMODElementsOfLife.Mounts;
namespace LSMODElementsOfLife.Buffs.DeathPack
{
    public class DeathHorseBuff : ModBuff
    {
            
        
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Death Horse");
            Description.SetDefault("Summon a dark horse Mount");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("DeathHorse"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}