using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project2
{
    class ControlledObject : MovingObject
    {
        public ControlledObject(Vector2 pos, Texture2D texture, Vector2 v) : base(pos, texture, v)
        {
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Right) && _pos.X + _v.X + _texture.Width <= 1920)
                _pos.X += _v.X;
            else if (ks.IsKeyDown(Keys.Left) && _pos.X - _v.X >= 0)
                _pos.X -= _v.X;
            else if (ks.IsKeyDown(Keys.Up) && _pos.Y - _v.Y >= 0)
                _pos.Y -= _v.Y;
            else if (ks.IsKeyDown(Keys.Down) && _pos.Y + _v.Y + _texture.Height <= 1080)
                _pos.Y += _v.Y;
        }
    }
}
