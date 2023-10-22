using Terraria.ModLoader;
using ShimmerQoL.Content.Buffs;

namespace ShimmerQoL.Common
{
    public class ShimmerPlayer : ModPlayer
    {
        public override void PreUpdateBuffs()
        {
            if(ModContent.GetInstance<TileCounts>().genesisCounduitCount > 0 && ModContent.GetInstance<Config>().aetherPrefixing)
            {
                Player.AddBuff(ModContent.BuffType<GenesisConduitBuff>(), 2);
            }
        }
    }
}