using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LSMODElementsOfLife.Projectiles.IcePack
{
    public class IceGhost : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Icy Ghost");
            Main.projFrames[projectile.type] = 6;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 20;
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            Main.projFrames[projectile.type] = 6;
            Main.projPet[projectile.type] = true;
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            if (player.dead)
            {
                modPlayer.petName = false;
            }
            if (modPlayer.petName)
            {
                projectile.timeLeft = 2;
            }
         }
    }
}