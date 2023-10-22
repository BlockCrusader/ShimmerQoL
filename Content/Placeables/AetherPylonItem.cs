using Terraria.Enums;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShimmerQoL.Content.Placeables
{
	public class AetherPylonItem : ModItem
	{
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(ModContent.GetInstance<Config>().aetherPylonNPCS);

        public override void SetDefaults() 
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<AetherPylonTile>());
			Item.SetShopValues(ItemRarityColor.LightPurple6, Terraria.Item.buyPrice(gold: 10));
		}
	}
}
