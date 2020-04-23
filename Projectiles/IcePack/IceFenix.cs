using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LSMODElementsOfLife.Projectiles.IcePack
{
    public class IceFenix : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Ice Guardian");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 72;
            projectile.height = 97;
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            Main.projFrames[projectile.type] = 4;
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