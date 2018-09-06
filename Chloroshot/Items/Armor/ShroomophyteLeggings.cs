using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Chloroshot.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ShroomophyteLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Shroomophyte Leggings");
            Tooltip.SetDefault("'Two worlds combine'"
                + "\n25% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 19;
		}

		public override void UpdateEquip(Player player)
		{
            player.moveSpeed += (player.moveSpeed / 100) * 25;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}