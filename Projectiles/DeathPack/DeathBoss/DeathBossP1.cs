using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Projectiles.DeathPack.DeathBoss
{
    public class DeathBossP1 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ShadowBeamHostile);
            aiType = ProjectileID.ShadowBeamHostile;

        }

        public override void Kill(int timeLeft)
        {

            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.NorthPoleSnowflake, (int)(projectile.damage * 0.5), projectile.knockBack, Main.myPlayer);
        }
    }
}