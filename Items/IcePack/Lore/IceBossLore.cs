using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Lore
{

    public class IceBossLore : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore - Ice Boss");
            Tooltip.SetDefault("Arianel, one of the faithful servants of ***\n was said to have been sent on an expedition millennia ago to keep the Moon Lord under control,\n not much is known about Arianel, but one thing is certain,\n ***'s servants do not die until until *** is not killed.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 21;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 1);
            item.maxStack = 99;
        }
    }
}