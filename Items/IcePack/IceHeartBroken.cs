using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack
{

    public class IceHeartBroken : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Heart Broken");
            Tooltip.SetDefault("Arianel's vessel");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Expert;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }
    }
}