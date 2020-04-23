using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack.Mineral
{
	public class IceCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Crystal");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 57;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.IcePack.Mineral.IceCrystal>();
			item.width = 12;
			item.height = 12;
			item.value = 75000;
			item.rare = ItemRarityID.Blue;
		}
	}
}
