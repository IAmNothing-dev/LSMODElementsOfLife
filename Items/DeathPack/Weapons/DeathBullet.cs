using LSMODElementsOfLife.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LSMODElementsOfLife.Items.DeathPack.Weapons
{
	public class DeathBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Death bullet");
		}

		public override void SetDefaults() {
			item.damage = 15;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;    
			item.knockBack = 2.5f;
			item.value = 50000;
			item.rare = ItemRarityID.Blue;
			item.shoot = ProjectileType<Projectiles.DeathPack.Weapons.DeathBulletProj>();  
			item.shootSpeed = 16f; 
			item.ammo = AmmoID.Bullet;              
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.DeathPack.Mineral.DeathBar>(), 1);
			recipe.AddIngredient(ItemID.IceBlock, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
		}
	}
}
