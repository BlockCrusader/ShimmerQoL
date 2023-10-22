using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ModLoader;
using Terraria.ModLoader.Default;
using Terraria.ObjectData;

namespace ShimmerQoL.Content.Placeables
{
	public class AetherPylonTile : ModPylon
	{
		public const int CrystalVerticalFrameCount = 8;

		public Asset<Texture2D> crystalTexture;
		public Asset<Texture2D> crystalHighlightTexture;
		public Asset<Texture2D> mapIcon;

		public override void Load() 
		{
			crystalTexture = ModContent.Request<Texture2D>(Texture + "_Crystal");
			crystalHighlightTexture = ModContent.Request<Texture2D>(Texture + "_CrystalHighlight");
			mapIcon = ModContent.Request<Texture2D>(Texture + "_MapIcon");
		}

		public override void SetStaticDefaults() {
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.DrawYOffset = 2;
			TileObjectData.newTile.StyleHorizontal = true;

			// Handles tile entitiy
			TEModdedPylon moddedPylon = ModContent.GetInstance<AetherPylonTileEntity>();
			TileObjectData.newTile.HookCheckIfCanPlace = new PlacementHook(moddedPylon.PlacementPreviewHook_CheckIfCanPlace, 1, 0, true);
			TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(moddedPylon.Hook_AfterPlacement, -1, 0, false);

			TileObjectData.addTile(Type);

			TileID.Sets.InteractibleByNPCs[Type] = true;
			TileID.Sets.PreventsSandfall[Type] = true;
			TileID.Sets.AvoidedByMeteorLanding[Type] = true;

			// Makes the tile count a pylon for teleportation-access/proximity purposes
			AddToArray(ref TileID.Sets.CountsAsPylon);

			LocalizedText pylonName = CreateMapEntryName();
			AddMapEntry(new Color(200, 105, 230), pylonName);
		}

		public override NPCShop.Entry GetNPCShopEntry() 
		{
            var configEnabled = new Condition("Mods.ShimmerQoL.CommonItemTooltip.ConfigCondition", () => ModContent.GetInstance<Config>().sellAetherPylon);
            var configSimple = new Condition("Mods.ShimmerQoL.CommonItemTooltip.SimplePylonConfig", () => ModContent.GetInstance<Config>().easyPylon);

            var standardCond = new Condition("Mods.ShimmerQoL.CommonItemTooltip.PylonCondStandard", () => configEnabled.IsMet() && !configSimple.IsMet() && Condition.NotInEvilBiome.IsMet() 
			&& Condition.InAether.IsMet() && Condition.DownedEyeOfCthulhu.IsMet() && Condition.NotDownedEowOrBoc.IsMet());

			var simpleCond = new Condition("Mods.ShimmerQoL.CommonItemTooltip.PylonCondSimple", () => configEnabled.IsMet() && configSimple.IsMet() && Condition.NotInEvilBiome.IsMet()
			&& Condition.InAether.IsMet() && Condition.AnotherTownNPCNearby.IsMet() && Condition.HappyEnoughToSellPylons.IsMet());

			var pylonCond = new Condition("Mods.ShimmerQoL.CommonItemTooltip.PylonCondFull", () => standardCond.IsMet() || simpleCond.IsMet());

            return new NPCShop.Entry(ModContent.ItemType<AetherPylonItem>(), pylonCond);
		}

		public override void MouseOver(int i, int j)
		{
			Main.LocalPlayer.cursorItemIconEnabled = true;
			Main.LocalPlayer.cursorItemIconID = ModContent.ItemType<AetherPylonItem>();
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) 
		{
			ModContent.GetInstance<AetherPylonTileEntity>().Kill(i, j);
		}

		public override bool ValidTeleportCheck_NPCCount(TeleportPylonInfo pylonInfo, int defaultNecessaryNPCCount) {

			int neededNPCs = ModContent.GetInstance<Config>().aetherPylonNPCS;
			if(neededNPCs <= 0)
			{
				return true;
			}

            Point16 tilePos = pylonInfo.PositionInTiles;
            return TeleportPylonsSystem.DoesPositionHaveEnoughNPCs(neededNPCs, tilePos);
		}

		public override bool ValidTeleportCheck_BiomeRequirements(TeleportPylonInfo pylonInfo, SceneMetrics sceneData) 
		{
			return sceneData.EnoughTilesForShimmer && (double)pylonInfo.PositionInTiles.Y >= Main.worldSurface;
        }

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) 
		{
            TorchID.TorchColor(23, out r, out g, out b);
			r *= 0.75f;
            g *= 0.75f;
            b *= 0.75f;
		}

		public override void SpecialDraw(int i, int j, SpriteBatch spriteBatch) 
		{
			DefaultDrawPylonCrystal(spriteBatch, i, j, crystalTexture, crystalHighlightTexture, new Vector2(0f, -12f), Color.White * 0.1f, Color.White, 4, CrystalVerticalFrameCount);
		}

		public override void DrawMapIcon(ref MapOverlayDrawContext context, ref string mouseOverText, TeleportPylonInfo pylonInfo, bool isNearPylon, Color drawColor, float deselectedScale, float selectedScale) 
		{
			bool mouseOver = DefaultDrawMapIcon(ref context, mapIcon, pylonInfo.PositionInTiles.ToVector2() + new Vector2(1.5f, 2f), drawColor, deselectedScale, selectedScale);
			DefaultMapClickHandle(mouseOver, pylonInfo, ModContent.GetInstance<AetherPylonItem>().DisplayName.Key, ref mouseOverText);
		}
	}
}
