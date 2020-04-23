using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items
{

    public class EmptyEnchantingStone : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empty Enchanting Stone");
            Tooltip.SetDefault("Use this item to craft enchanted elemental stones\nNeed Enchanting Table");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 42;
            item.rare = ItemRarityID.Expert;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }
    }
}