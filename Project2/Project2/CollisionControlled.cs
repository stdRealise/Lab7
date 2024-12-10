using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2
{
    class CollisionControlled : ControlledObject, ICollision
    {
        protected Rectangle _bounds;
        public CollisionControlled(Vector2 pos, Texture2D texture, Vector2 v) : base(pos, texture, v)
        {
            _bounds = new Rectangle((int)_pos.X, (int)_pos.Y, _texture.Width, _texture.Height);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _bounds.X = (int)_pos.X;
            _bounds.Y = (int)_pos.Y;
        }
        public bool CheckCollision(ICollision obj)
        {
            return _bounds.Intersects(obj.Bounds);
        }
        public Rectangle Bounds
        {
            get { return _bounds; }
        }
        public void Collision()
        {
            _v.X = 0;
            _v.Y = 0;
        }
    }
}
