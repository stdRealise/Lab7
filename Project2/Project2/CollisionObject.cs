using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2
{
    class CollisionObject : GameObject, ICollision
    {
        protected Rectangle _bounds;
        public CollisionObject(Vector2 pos, Texture2D texture) : base(pos, texture)
        {
            _bounds = new Rectangle((int)_pos.X, (int)_pos.Y, _texture.Width, _texture.Height);
        }

        public Rectangle Bounds
        {
            get { return _bounds; }
        }

        public bool CheckCollision(ICollision obj)
        {
            return _bounds.Intersects(obj.Bounds);
        }
        public void Collision()
        {
        }
    }
}
