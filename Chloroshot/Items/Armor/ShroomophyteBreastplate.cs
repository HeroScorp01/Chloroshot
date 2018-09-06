using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Chloroshot.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ShroomophyteBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Shroomophyte Breastplate");
			Tooltip.SetDefault("'Two worlds combine'"
				+ "\n17% increased ranged critical strike chance"
				+ "\n20% increased ranged damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 26;
		}

		public override void UpdateEquip(Player player)
		{
            player.rangedDamage += (player.rangedDamage / 100)*20;
            player.rangedCrit += (player.rangedCrit/100)*17;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 30);
            recipe.AddIngredient(ItemID.ShroomiteBar, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}