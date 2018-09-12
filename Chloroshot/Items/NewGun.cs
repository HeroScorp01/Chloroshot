using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Chloroshot.Items
{
    public class NewGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The wrath of the jungle in the palm of your hand.");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 9;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
           
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShroomiteBar, 25);
                recipe.AddIngredient(ItemID.ChlorophyteBar, 30);
                recipe.AddIngredient(tremor.ItemType("BrassBar"), 20);
                recipe.AddIngredient(tremor.ItemType("CarbonSteel"), 15);
                recipe.AddIngerdient(tremor.ItemType("CometiteBar"),5);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 20 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}
