using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShimmerQoL.Common
{
	public class ShimmerCraft : ModSystem
	{
        public override void AddRecipes()
        {
            var configEnabled = new Condition("Mods.ShimmerQoL.CommonItemTooltip.ConfigCondition", () => ModContent.GetInstance<Config>().wellCrafting);
            for (int itemType = 0; itemType < ItemLoader.ItemCount; itemType++)
            {
                int shimmerEquivalentType = ItemID.Sets.ShimmerCountsAsItem[itemType] != -1 ?
                ItemID.Sets.ShimmerCountsAsItem[itemType] : itemType;

                Item dummyItem = new Item();
                dummyItem.SetDefaults(itemType);

                if (shimmerEquivalentType == ItemID.RodofDiscord)
                {
                    var postML = Recipe.Create(ItemID.RodOfHarmony);
                    postML.AddIngredient(itemType);
                    postML.AddTile<Content.Placeables.ShimmerWellTile>();
                    postML.AddCondition(Condition.DownedMoonLord);
                    postML.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        postML.AddCondition(Condition.InAether);
                    }
                    postML.Register();
                }
                else if(shimmerEquivalentType == ItemID.Clentaminator)
                {
                    var postML = Recipe.Create(ItemID.Clentaminator2);
                    postML.AddIngredient(itemType);
                    postML.AddTile<Content.Placeables.ShimmerWellTile>();
                    postML.AddCondition(Condition.DownedMoonLord);
                    postML.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        postML.AddCondition(Condition.InAether);
                    }
                    postML.Register();
                }
                else if(shimmerEquivalentType == ItemID.BottomlessBucket)
                {
                    var postML = Recipe.Create(ItemID.BottomlessShimmerBucket);
                    postML.AddIngredient(itemType);
                    postML.AddTile<Content.Placeables.ShimmerWellTile>();
                    postML.AddCondition(Condition.DownedMoonLord);
                    postML.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        postML.AddCondition(Condition.InAether);
                    }
                    postML.Register();
                }
                else if (shimmerEquivalentType == ItemID.BottomlessShimmerBucket)
                {
                    var postML = Recipe.Create(ItemID.BottomlessBucket);
                    postML.AddIngredient(itemType);
                    postML.AddTile<Content.Placeables.ShimmerWellTile>();
                    postML.AddCondition(Condition.DownedMoonLord);
                    postML.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        postML.AddCondition(Condition.InAether);
                    }
                    postML.Register();
                }
                else if (shimmerEquivalentType == ItemID.LunarBrick)
                {
                    var astra = Recipe.Create(ItemID.AstraBrick);
                    astra.AddIngredient(itemType);
                    astra.AddTile<Content.Placeables.ShimmerWellTile>();
                    astra.AddCondition(Condition.MoonPhaseThirdQuarter);
                    astra.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        astra.AddCondition(Condition.InAether);
                    }
                    astra.Register();

                    var cosmic = Recipe.Create(ItemID.CosmicEmberBrick);
                    cosmic.AddIngredient(itemType);
                    cosmic.AddTile<Content.Placeables.ShimmerWellTile>();
                    cosmic.AddCondition(Condition.MoonPhaseWaxingGibbous);
                    cosmic.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        cosmic.AddCondition(Condition.InAether);
                    }
                    cosmic.Register();

                    var cryo = Recipe.Create(ItemID.CryocoreBrick);
                    cryo.AddIngredient(itemType);
                    cryo.AddTile<Content.Placeables.ShimmerWellTile>();
                    cryo.AddCondition(Condition.MoonPhaseFirstQuarter);
                    cryo.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        cryo.AddCondition(Condition.InAether);
                    }
                    cryo.Register();

                    var dark = Recipe.Create(ItemID.DarkCelestialBrick);
                    dark.AddIngredient(itemType);
                    dark.AddTile<Content.Placeables.ShimmerWellTile>();
                    dark.AddCondition(Condition.MoonPhaseWaningCrescent);
                    dark.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        dark.AddCondition(Condition.InAether);
                    }
                    dark.Register();

                    var heaven = Recipe.Create(ItemID.HeavenforgeBrick);
                    heaven.AddIngredient(itemType);
                    heaven.AddTile<Content.Placeables.ShimmerWellTile>();
                    heaven.AddCondition(Condition.MoonPhaseFull);
                    heaven.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        heaven.AddCondition(Condition.InAether);
                    }
                    heaven.Register();

                    var lunar = Recipe.Create(ItemID.LunarRustBrick);
                    lunar.AddIngredient(itemType);
                    lunar.AddTile<Content.Placeables.ShimmerWellTile>();
                    lunar.AddCondition(Condition.MoonPhaseWaningGibbous);
                    lunar.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        lunar.AddCondition(Condition.InAether);
                    }
                    lunar.Register();

                    var mercury = Recipe.Create(ItemID.MercuryBrick);
                    mercury.AddIngredient(itemType);
                    mercury.AddTile<Content.Placeables.ShimmerWellTile>();
                    mercury.AddCondition(Condition.MoonPhaseNew);
                    mercury.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        mercury.AddCondition(Condition.InAether);
                    }
                    mercury.Register();

                    var star = Recipe.Create(ItemID.StarRoyaleBrick);
                    star.AddIngredient(itemType);
                    star.AddTile<Content.Placeables.ShimmerWellTile>();
                    star.AddCondition(Condition.MoonPhaseWaxingCrescent);
                    star.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        star.AddCondition(Condition.InAether);
                    }
                    star.Register();
                }
                else if (dummyItem.createTile == TileID.MusicBoxes)
                {
                    var music = Recipe.Create(ItemID.MusicBox);
                    music.AddIngredient(itemType);
                    music.AddTile<Content.Placeables.ShimmerWellTile>();
                    music.AddCondition(configEnabled);
                    if (ModContent.GetInstance<Config>().wellAether)
                    {
                        music.AddCondition(Condition.InAether);
                    }
                    music.Register();
                }
                else if (ItemID.Sets.ShimmerTransformToItem[shimmerEquivalentType] > 0)
                {
                    try
                    {
                        var recipe = Recipe.Create(ItemID.Sets.ShimmerTransformToItem[shimmerEquivalentType]);
                        recipe.AddIngredient(itemType);
                        recipe.AddTile<Content.Placeables.ShimmerWellTile>();
                        recipe.AddCondition(configEnabled);
                        if (ModContent.GetInstance<Config>().wellAether)
                        {
                            recipe.AddCondition(Condition.InAether);
                        }
                        recipe.Register();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
