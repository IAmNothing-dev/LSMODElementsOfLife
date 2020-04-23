using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Mounts;

namespace LSMODElementsOfLife.Items.IcePack
{
	public class IcetaurFriendlyMountCall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icetaur Friendly");
			Tooltip.SetDefault("Summon a Icetaur Mount");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = MountType<Mounts.IcePack.IcetaurFriendly>();
		}
	}
}