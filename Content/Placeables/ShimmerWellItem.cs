using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ShimmerQoL.Content.Placeables
{
	public class ShimmerWellItem : ModItem
	{
        public override void SetDefaults() 
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<ShimmerWellTile>());
			Item.SetShopValues(ItemRarityColor.LightPurple6, Terraria.Item.buyPrice(gold: 4));
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (ModContent.GetInstance<Config>().wellAether)
            {
                tooltips.Add(new TooltipLine(Mod, "nerfTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.WellNerf")));
            }
            if (!ModContent.GetInstance<Config>().wellCrafting)
            {
                tooltips.Add(new TooltipLine(Mod, "disabledTip", Language.GetTextValue("Mods.ShimmerQoL.CommonItemTooltip.WellDisabled")) { OverrideColor = new Color(190, 120, 120) });
            }
        }
    }
}
