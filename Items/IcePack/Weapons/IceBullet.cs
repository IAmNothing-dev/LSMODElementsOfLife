using LSMODElementsOfLife.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.IcePack.Weapons
{
	public class IceBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice bullet");
		}

		public override void SetDefaults() {
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;    
			item.knockBack = 2.5f;
			item.value = 50000;
			item.rare = ItemRarityID.Blue;
			item.shoot = ProjectileType<Projectiles.IcePack.Ammo.IceBulletProj>();  
			item.shootSpeed = 16f; 
			item.ammo = AmmoID.Bullet;              
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 1);
			recipe.AddIngredient(ItemID.IceBlock, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
		}
	}
}
