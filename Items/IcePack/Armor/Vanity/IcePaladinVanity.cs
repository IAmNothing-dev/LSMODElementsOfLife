using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife;

namespace LSMODElementsOfLife.Items.IcePack.Armor.Vanity
{
	[AutoloadEquip(EquipType.Body)]
	internal class IcePaladinVanity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Paladin Vest");
		}
		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 14;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetMatch(bool female, ref int equipSlot, ref bool robes) {
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("IcePaladinVanity_Legs", EquipType.Legs);
		}

		public override void DrawHands(ref bool drawHands, ref bool drawArms) 
		{
			drawHands = false;

		}
	}
}
