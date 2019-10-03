using Terraria;
using Terraria.ModLoader;

namespace Chloroshot.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class BeetlShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A Beetle Shield."
				+ "Gives Beetle Powers");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 7;
			item.accessory = true;
			item.defense = 4;
			item.lifeRegen = 19;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.meleeDamage += 19f;
				player.rangedDamage += 19f;
				player.endurance = 1f - 0.1f * (1f - player.endurance);
				player.GetModPlayer<ExamplePlayer>().exampleShield = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemId.BeetleShell, 15);
			recipe.AddIngerdient(ModId.TurtleShield,1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
