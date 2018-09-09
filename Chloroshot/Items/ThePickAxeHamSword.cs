using Terraria.ID;
using Terraria.ModLoader;

namespace Chloroshot.Items
{
    public class ThePickAxeHamSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The PickAxeHamSword");
            Tooltip.SetDefault("Wtf");
        }
        public override void SetDefaults()
        {
            item.damage = 1000;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 5;
            item.useAnimation = 5;
            item.axe = 85;
            item.hammer = 500;
            item.pick = 500;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 12;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 100);
            recipe.AddIngredient(ItemID.HellstoneBar, 50);
            recipe.AddIngredient(ItemID.FragmentSolar, 30);
            recipe.AddIngredient(ItemID.FragmentVortex, 30);
            recipe.AddIngredient(ItemID.FragmentNebula, 30);
            recipe.AddIngredient(ItemID.FragmentStardust, 30);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}