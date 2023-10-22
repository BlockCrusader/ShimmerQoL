using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.Utilities;

namespace ShimmerQoL.Common
{
	public class ShimmerReforge : GlobalItem
	{
        public override bool? PrefixChance(Item item, int pre, UnifiedRandom rand)
        {
            Player localPlayer = Main.LocalPlayer;
            if (localPlayer.ZoneShimmer && ModContent.GetInstance<TileCounts>().genesisCounduitCount > 0
                && ModContent.GetInstance<Config>().aetherPrefixing)
            {
                if(pre == -1)
                {
                    if (ModContent.GetInstance<Config>().nerfPrefixing && ShimmerHelpers.TransumtationID(item) == -1)
                    {
                        return null;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return null;
        }

        public override bool AllowPrefix(Item item, int pre)
        {
            Player localPlayer = Main.LocalPlayer;

            List<int> shimmerBlaclist = new();

            List<PrefixDefinition> configBlacklist = ModContent.GetInstance<Config>().prefixBlacklist;
            for (int i = 0; i < configBlacklist.Count; i++)
            {
                shimmerBlaclist.Add(configBlacklist[i].Type);
            }

            if (localPlayer.ZoneShimmer && ModContent.GetInstance<TileCounts>().genesisCounduitCount > 0
                && ModContent.GetInstance<Config>().aetherPrefixing)
            {
                if (ModContent.GetInstance<Config>().nerfPrefixing && ShimmerHelpers.TransumtationID(item) == -1)
                {
                    return true;
                }
                else if (shimmerBlaclist.Contains(pre))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
