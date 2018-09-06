using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Chloroshot.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ShroomophyteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Shroomophyte Helmet");
            Tooltip.SetDefault("'Two worlds combine'"
                + "\n7% increased ranged critical strike chance"
				+ "\n11% increased ranged damage");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 15;
		}
	
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ShroomophyteBreastplate") && legs.type == mod.ItemType("ShroomophyteLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased ranged damage by 50%";
            player.rangedDamage += (player.rangedDamage / 100) * 50;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += (player.rangedDamage / 100) * 11;
            player.rangedCrit += (player.rangedCrit / 100) * 7;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(ItemID.ShroomiteBar, 7);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}