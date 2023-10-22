using ShimmerQoL.Content.Placeables;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShimmerQoL.Common
{
    public class Transmutations : GlobalItem 
    {
        public override void SetStaticDefaults()
        {
            // Tinkerer's Workshop > Genisis Conduit
            ItemID.Sets.ShimmerTransformToItem[ItemID.TinkerersWorkshop] = ModContent.ItemType<GenesisConduitItem>();

            // Fountains > Shimmer Well
            ItemID.Sets.ShimmerTransformToItem[ItemID.PureWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.BloodWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CorruptWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrimsonWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.DesertWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.HallowedWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.IcyWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.JungleWaterFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.OasisFountain] = ModContent.ItemType<ShimmerWellItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CavernFountain] = ModContent.ItemType<ShimmerWellItem>();

            if (ModContent.GetInstance<Config>().easyPylon)
            {
                // biome Pylons > Aether Pylon
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonDesert] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonHallow] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonJungle] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonMushroom] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonOcean] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonPurity] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonSnow] = ModContent.ItemType<AetherPylonItem>();
                ItemID.Sets.ShimmerTransformToItem[ItemID.TeleportationPylonUnderground] = ModContent.ItemType<AetherPylonItem>();
            }
        }
    }
}