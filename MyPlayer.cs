using LSMODElementsOfLife.Buffs;
using LSMODElementsOfLife.Dusts;
using LSMODElementsOfLife.Items;
using LSMODElementsOfLife.NPCs;
using LSMODElementsOfLife.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool minionName = false;
        public bool petName = false;
        public static bool hasProjectiles;
        public bool LightPet = false;
        public override void ResetEffects()
        {
            minionName = false;
            petName = false;
            
        }
    }
}