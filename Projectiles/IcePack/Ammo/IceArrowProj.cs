using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LSMODElementsOfLife.Projectiles;
using LSMODElementsOfLife.Dusts;

namespace LSMODElementsOfLife.Projectiles.IcePack.Ammo
{
    public class IceArrowProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 400;
            projectile.light = 0.10f;
            aiType = 1;
        }
        public override void AI()
        {
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<IceDust>(),
                    projectile.velocity.X * .2f, projectile.velocity.Y * .2f, 150, Scale: 1.2f);
                dust.velocity += projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }

            if (Main.rand.NextBool(4))
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<IceDust>(),
                    0, 0, 150, Scale: 0.3f);
                dust.velocity += projectile.velocity * 0.5f;
                dust.velocity *= 0.5f;
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {

            target.AddBuff(BuffID.Frostburn, 510);

        }
        //After the projectile is dead
        //public override void Kill(int timeLeft)
        //{

        //    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.NorthPoleSnowflake, (int)(projectile.damage * 0.5), projectile.knockBack, Main.myPlayer); // This spawns a projectile after this projectile is dead

        //}


    }
}