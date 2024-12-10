using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project2
{
    class MovingObject : GameObject
    {
        protected Vector2 _v;
        public MovingObject(Vector2 pos, Texture2D texture, Vector2 v) : base(pos, texture)
        {
            _v = v;
        }
        public override void Update(GameTime gameTime)
        {
            if (_pos.X + _v.X + _texture.Width > 1920)
                _v.X = -_v.X;
            else if (_pos.X + _v.X < 0)
                _v.X = -_v.X;
            if (_pos.Y + _v.Y + _texture.Height > 1080)
                _v.Y = -_v.Y;
            else if (_pos.Y + _v.Y < 0)
                _v.Y = -_v.Y;
            _pos += _v;
        }
    }
}
