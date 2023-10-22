using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ShimmerQoL.Content.Placeables
{
	public class GenesisConduitTile : ModTile
	{
		public override void SetStaticDefaults()
        {
			Main.tileNoAttach[Type] = true;
			Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            AdjTiles = new int[] { TileID.TinkerersWorkbench };
            DustType = 1;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 18 };
			TileObjectData.addTile(Type);

            LocalizedText tileName = CreateMapEntryName();
            AddMapEntry(new Color(200, 105, 230), tileName);
        }

		public override void NumDust(int x, int y, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            TorchID.TorchColor(23, out r, out g, out b);
            r *= 0.6f;
            g *= 0.6f;
            b *= 0.6f;
        }

        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture = ModContent.Request<Texture2D>("ShimmerQoL/Content/Placeables/GenesisConduitTile").Value;
            Texture2D glowTexture = ModContent.Request<Texture2D>("ShimmerQoL/Content/Placeables/GenesisConduitTileGlow").Value;

            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);

            int height = tile.TileFrameY == 36 ? 18 : 16;

            // Main sprite
            spriteBatch.Draw(
                texture,
                new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
                new Rectangle(tile.TileFrameX, tile.TileFrameY, 16, height),
                Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);

            // Glowmask
            spriteBatch.Draw(
                glowTexture,
                new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
                new Rectangle(tile.TileFrameX, tile.TileFrameY, 16, height),
                Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

            return false;
        }
    }
}
