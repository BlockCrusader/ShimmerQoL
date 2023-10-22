using ShimmerQoL.Content.Placeables;
using System;
using Terraria.ModLoader;

namespace ShimmerQoL.Common
{
    public class TileCounts : ModSystem 
    {
        public int genesisCounduitCount;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            genesisCounduitCount = tileCounts[ModContent.TileType<GenesisConduitTile>()];
        }
    }
}