using LSMODElementsOfLife.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife
{
    public class LSMODElementsOfLife : Mod
    {
        public LSMODElementsOfLife()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                AddEquipTexture(null, EquipType.Legs, "IcePaladinVanity_Legs", "LSMODElementsOfLife/Items/IcePack/Armor/Vanity/IcePaladinVanity_Legs");
            }
        }

        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                bossChecklist.Call(
                    "AddBoss",
                    4f, //<- Posizione della lista
                    new List<int> { ModContent.NPCType<NPCs.IcePack.IceBoss.IceBoss>() },
                    this,
                    "$Mods.LSMODElementsOfLife.NPCName.IceBoss",
                    (Func<bool>)(() => LSMODElementsOfLifeWorld.downedIceBoss),
                    ModContent.ItemType<Items.IcePack.Summon.SummonIceBoss>(),
                    new List<int> { ModContent.ItemType<Items.IcePack.Placeable.IceBossTrophy>(), ModContent.ItemType<Items.IcePack.Armor.Vanity.IcePaladinVanity>(), },
                    new List<int> { ModContent.ItemType<Items.IcePack.IceHeartBroken>(), 
                                    ModContent.ItemType<Items.IcePack.IceFenix>(), 
                                    ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SpearIceBoss>(), 
                                    ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SwordIceBoss>(),
                                    ModContent.ItemType<Items.IcePack.IcetaurFriendlyMountCall>(),
                                    ModContent.ItemType<Items.EmptyEnchantingStone>(),
                                    },
                "$Elements Of Life (Boss Ice Pack). Use the Ice Heart at night to summon it"
                );
            }
        }
    }
}

