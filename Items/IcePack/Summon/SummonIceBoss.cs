using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LSMODElementsOfLife.Items.IcePack.Summon
{
    public class SummonIceBoss : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Heart");
            Tooltip.SetDefault("Summon the Arianel, The icy Watcher\nUse it during the night and Snow Biome.");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = ItemRarityID.Blue;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            return player.ZoneSnow && !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("NomeDelBoss"));
            {
                return !Main.dayTime && !NPC.AnyNPCs(mod.NPCType("BeamsterBoss"));
            }

        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("IceBoss"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.IcePack.Mineral.IceBar>(), 25);
            recipe.AddIngredient(ItemID.IceBlock, 100);
            recipe.AddIngredient(ItemID.SnowBlock, 100);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
