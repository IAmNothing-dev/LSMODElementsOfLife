using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using LSMODElementsOfLife.Mounts;

namespace LSMODElementsOfLife.Items.DeathPack
{
	public class DeathHorseMount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Death horse");
			Tooltip.SetDefault("Summon a dark horse mount");
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
			item.mountType = MountType<Mounts.DeathPack.DeathHorse>();
		}
	}
}