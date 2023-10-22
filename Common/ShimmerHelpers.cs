using Terraria.Enums;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace ShimmerQoL.Common
{
    public class ShimmerHelpers : ModSystem 
    {
        public static int TransumtationID(Item item)
        {
            // Code for determining item shimmers adapted from GetShimmered() and GetShimmerEquivalentType()
            int shimmerEquivalentType = ItemID.Sets.ShimmerCountsAsItem[item.type] != -1 ?
                ItemID.Sets.ShimmerCountsAsItem[item.type] : item.type;

            int transumtationItemID = -1;
            if (shimmerEquivalentType == ItemID.RodofDiscord && NPC.downedMoonlord)
            {
                transumtationItemID = ItemID.RodOfHarmony;
            }
            else if (shimmerEquivalentType == ItemID.Clentaminator && NPC.downedMoonlord)
            {
                transumtationItemID = ItemID.Clentaminator2;
            }
            else if (shimmerEquivalentType == ItemID.BottomlessBucket && NPC.downedMoonlord)
            {
                transumtationItemID = ItemID.BottomlessShimmerBucket;
            }
            else if (shimmerEquivalentType == ItemID.BottomlessShimmerBucket && NPC.downedMoonlord)
            {
                transumtationItemID = ItemID.BottomlessBucket;
            }
            else if (shimmerEquivalentType == ItemID.LunarBrick)
            {
                transumtationItemID = Main.GetMoonPhase() switch
                {
                    MoonPhase.QuarterAtRight => ItemID.StarRoyaleBrick,
                    MoonPhase.HalfAtRight => ItemID.CryocoreBrick,
                    MoonPhase.ThreeQuartersAtRight => ItemID.CosmicEmberBrick,
                    MoonPhase.Full => ItemID.HeavenforgeBrick,
                    MoonPhase.ThreeQuartersAtLeft => ItemID.LunarRustBrick,
                    MoonPhase.HalfAtLeft => ItemID.AstraBrick,
                    MoonPhase.QuarterAtLeft => ItemID.DarkCelestialBrick,
                    _ => ItemID.MercuryBrick,
                };
            }
            else if (item.createTile == TileID.MusicBoxes)
            {
                transumtationItemID = ItemID.MusicBox;
            }
            else if (ItemID.Sets.ShimmerTransformToItem[shimmerEquivalentType] > 0)
            {
                transumtationItemID = ItemID.Sets.ShimmerTransformToItem[shimmerEquivalentType];
            }

            return transumtationItemID;
        }
    }
}