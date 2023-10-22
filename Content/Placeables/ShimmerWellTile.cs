using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ShimmerQoL.Content.Placeables
{
	public class ShimmerWellTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.Height = 4;
			TileObjectData.newTile.Origin = new Point16(1, 2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 18 };
			TileObjectData.addTile(Type);

            Main.tileLighted[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLighted[Type] = true;

            LocalizedText tileName = CreateMapEntryName();
            AddMapEntry(new Color(200, 105, 230), tileName);

            AnimationFrameHeight = 72;
            TileID.Sets.CountsAsShimmerSource[Type] = true;

            DustType = DustID.Gold;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frameCounter++;
			if(frameCounter >= 4)
			{
				frameCounter = 0;
				if(frame++ >= 6)
				{
					frame = 0;
				}
			}
        }

        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch) {
			Tile tile = Main.tile[i, j];
            Texture2D texture = ModContent.Request<Texture2D>("ShimmerQoL/Content/Placeables/ShimmerWellTile").Value;
            Texture2D glowTexture = ModContent.Request<Texture2D>("ShimmerQoL/Content/Placeables/ShimmerWellTileGlow").Value;
            Texture2D glowTexture2 = ModContent.Request<Texture2D>("ShimmerQoL/Content/Placeables/ShimmerWellTileGlow2").Value;

            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);

			int height = tile.TileFrameY % AnimationFrameHeight == 36 ? 18 : 16;

			int frameYOffset = Main.tileFrame[Type] * AnimationFrameHeight;

            // Main sprite
            spriteBatch.Draw(
				texture,
				new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
				new Rectangle(tile.TileFrameX, tile.TileFrameY + frameYOffset, 16, height),
				Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);

            // Glowmask
            spriteBatch.Draw(
				glowTexture,
				new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
				new Rectangle(tile.TileFrameX, tile.TileFrameY + frameYOffset, 16, height),
				Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

            // Extra effect
            /*
            TorchID.TorchColor(23, out float r, out float g, out float b);
            spriteBatch.Draw(
                glowTexture2,
                new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero,
                new Rectangle(tile.TileFrameX, tile.TileFrameY + frameYOffset, 16, height),
                new Color(r, g, b, 127), 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            */
            return false;
		}

        public override void NumDust(int x, int y, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            TorchID.TorchColor(23, out r, out g, out b);
            r *= 0.5f;
            g *= 0.5f;
            b *= 0.5f;
        }
    }
}
