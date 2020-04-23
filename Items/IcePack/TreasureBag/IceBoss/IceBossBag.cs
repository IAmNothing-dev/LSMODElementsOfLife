using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack.TreasureBag.IceBoss
{
    public class IceBossBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arianel - Treasure Bag");
            Tooltip.SetDefault("{$CommonItemToolTip.RightClickToOpen}");
        }
        
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 32;
            item.height = 32;
            item.rare = 1;
            item.expert = true;
        }



        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(1))
            {
                player.QuickSpawnItem(mod.ItemType("IceHeartBroken"));
                player.QuickSpawnItem(mod.ItemType("LSToken"), Main.rand.Next(1,5));
            }
            int choice = Main.rand.Next(5);
            if (choice == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SpearIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<IceFenix>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Placeable.IceBossTrophy>());
                player.QuickSpawnItem(ModContent.ItemType<Items.EmptyEnchantingStone>());
            }
            if (choice == 1)
            {
                player.QuickSpawnItem(ModContent.ItemType<IceFenix>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SwordIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Armor.Vanity.IcePaladinVanity>());
                player.QuickSpawnItem(ModContent.ItemType<Items.EmptyEnchantingStone>());
            }
            if (choice == 2)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SpearIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SwordIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.IcetaurFriendlyMountCall>());
                player.QuickSpawnItem(ModContent.ItemType<Items.EmptyEnchantingStone>());
            }
            if (choice == 3)
            {
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SwordIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<IceFenix>());
                player.QuickSpawnItem(ModContent.ItemType<Items.EmptyEnchantingStone>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Placeable.IceBossTrophy>());
            }
            if (choice == 4)
            {
                player.QuickSpawnItem(ModContent.ItemType<IceFenix>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Weapons.IceBoss.SpearIceBoss>());
                player.QuickSpawnItem(ModContent.ItemType<Items.IcePack.Armor.Vanity.IcePaladinVanity>());
                player.QuickSpawnItem(ModContent.ItemType<Items.EmptyEnchantingStone>());
            }
        }

        public override int BossBagNPC => ModContent.NPCType<NPCs.IcePack.IceBoss.IceBoss>();
    }
}