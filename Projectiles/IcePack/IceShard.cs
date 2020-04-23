using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LSMODElementsOfLife.Projectiles;

namespace LSMODElementsOfLife.Projectiles.IcePack
{
    public class IceShard : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 18;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 150;
            projectile.light = 0.75f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }

        public override void Kill(int timeLeft)
        {

            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.NorthPoleSnowflake, (int)(projectile.damage * 0.5), projectile.knockBack, Main.myPlayer);
        }
    }
}