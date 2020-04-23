using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Buffs.IcePack
{
    public class PikaflyBuff : ModBuff
    {

        public override void SetDefaults ()
        {
            DisplayName.SetDefault("Pikafly");
            Description.SetDefault("Pika Pika.\nDesign by = Marshy");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>().petName = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Pikafly")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Pikafly"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}