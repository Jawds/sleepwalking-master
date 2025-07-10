using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace sleepwalking_master
{
    class Frog
    {
        private readonly Texture2D frogTexture;

        private readonly int ViewportWidth;

        private float xPosition;
        private float yPosition;
        private float previousXPosition;
        private float previousYPosition;

        public const int Height = 20;
        public const int Width = 20;

        public float speed = 5;

        public Frog(Texture2D texture,int ViewportWidth, float xPosition, float yPosition)
        {
            frogTexture = texture;
            this.ViewportWidth = ViewportWidth;

            previousXPosition = xPosition;
            previousYPosition = yPosition;
        }

        public void MoveLeft()
        {
            previousXPosition = xPosition;

            xPosition -= speed;
            
        }

        public void MoveRight()
        {
            previousXPosition = xPosition;

            if (xPosition < ViewportWidth - Width)
            {
                xPosition += speed;
            }
        }

        public Texture2D GetTexture()
        {
            return frogTexture;
        }

        public float GetXPosition()
        {
            return xPosition;
        }

        public float GetYPosition()
        {
            return yPosition;
        }

        public float GetPreviousXPosition()
        {
            return previousXPosition;
        }

        public float GetPreviousYPosition()
        {
            return previousYPosition;
        }
    }
}