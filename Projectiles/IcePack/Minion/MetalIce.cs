using System;
using Terraria;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Projectiles.IcePack.Minion
{
    public abstract class MetalIce : ModProjectile
    {
        public override void AI()
        {
            CheckActive();
            Behavior();
        }

        public abstract void CheckActive();

        public abstract void Behavior();
    }
}