using Terraria.ID;
using Terraria.ModLoader;

namespace Chloroshot.Items
{
	public class THEAXE : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The OP Axe");
			Tooltip.SetDefault("Have Fun!");
		}
		public override void SetDefaults()
		{
			item.damage = 500;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 60;
			item.useAnimation = 60;
            item.axe = 80;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 12;
			item.UseSound = SoundID.Item15;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 50);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
