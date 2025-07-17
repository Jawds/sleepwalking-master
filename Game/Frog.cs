using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sleepwalking_master
{
    class Frog
    {
        private readonly Texture2D frogTexture;

        private readonly int ViewportWidth;
        private readonly int ViewportHeight;

        public Vector2 Position;
        public Vector2 previousPosition;

        public Vector2 Velocity;

        public const int Height = 30;
        public const int Width = 30;

        public float speed = 5;

        public Frog(Texture2D texture, Vector2 Position)
        {
            frogTexture = texture;

            this.Position.X = ViewportWidth / 2 - Width / 2;
            this.Position.Y = ViewportHeight / 2 - Height / 2;

            this.previousPosition = this.Position;

            Velocity = Position;
        }

        public void MoveLeft()
        {
            previousPosition = Position;

            if (Position.X > 0)
            {
                Position.X -= speed;
            }
        }

        public void MoveRight()
        {
            previousPosition = Position;

            if (Position.X < ViewportWidth - Width)
            {
                Position.X += speed;
            }
        }

        public Texture2D GetTexture()
        {
            return frogTexture;
        }

        public Vector2 GetPosition()
        {
            return Position;
        }

        public Vector2 GetPreviousPosition()
        {
            return previousPosition;
        }
    }
}