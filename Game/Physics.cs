
// Class for applying gravity to an object.
// Physics updates every frame. This script holds a dynamic array of objects that are affected by gravity.
// TODO Is that good for decoupling?? append. its okay i can imagine itll be fast enough
// find a way to attach the class of physics object to other objects. check gpp

// currently uses polymorphism on time, must figure a way to change

using Microsoft.Xna.Framework;

namespace sleepwalking_master
{
    class Physics
    {
        private readonly GameObject gameObject;
        public const float GravityScale = (float)9.8;

        public void PhysicsUpdate(GameTime gameTime)
        {
            float timeSeconds = (float)gameTime.ElapsedGameTime.Seconds;
            ApplyGravity(gameObject, timeSeconds);
        }

        private void ApplyGravity(GameObject gameObject, float timeSeconds)
        {
            gameObject.Velocity.Y += GravityScale * (float)timeSeconds;
            gameObject.Position.Y += gameObject.Velocity.Y * timeSeconds;
        }
    }
}