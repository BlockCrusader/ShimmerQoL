using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShimmerQoL.Content.Placeables
{
	public class GenesisConduitItem : ModItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[Type] = ItemID.TinkerersWorkshop;
        }

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(ModContent.GetInstance<Config>().aetherPylonNPCS);

        public override void SetDefaults() 
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<GenesisConduitTile>());
			Item.SetShopValues(ItemRarityColor.LightPurple6, Terraria.Item.buyPrice(gold: 10));
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (ModContent.GetInstance<Config>().nerfPrefixing)
            {
                tooltips.Add(new TooltipLine(Mod, "nerfTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.ConduitNerf")));
            }
            if (!ModContent.GetInstance<Config>().aetherPrefixing)
            {
                tooltips.Add(new TooltipLine(Mod, "disabledTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.ConduitDisabled")) { OverrideColor = new Color(190, 120, 120) });
            }
        }
    }
}
