using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Tile is used for composing levels. Each Tile is 

namespace sleepwalking_master
{
    class Tile
    {
        private int xPosition;
        private int yPosition;
        private readonly Texture2D tileTexture;

        public const int Width = 30;
        public const int Height = 30;

        public enum Collision
        {
            NONE,
            PASSABLE,
            RIGID
        }

        public Collision TileCollision;

        public enum Layer
        {
            BACK,
            MID,
            FORE,
        }

        public Layer TileLayer;

        public Tile(Texture2D texture, int xPosiiton, int yPosition, Collision TileCollision, Layer TileLayer)
        {
            texture = tileTexture;
            this.xPosition = xPosiiton;
            this.yPosition = yPosition;
            this.TileCollision = TileCollision;
            this.TileLayer = TileLayer;
        }
    }
}