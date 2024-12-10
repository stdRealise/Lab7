using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project2
{
    class GameObject
    {
        protected Vector2 _pos;
        protected Texture2D _texture;
        
        public GameObject(Vector2 pos, Texture2D texture)
        {
            _pos = pos;
            _texture = texture;
        }
        public virtual void Draw(SpriteBatch spriteBatch) 
        {
            spriteBatch.Draw(_texture, _pos, Color.White);
        }
        public virtual void Update(GameTime gameTime)
        {
        }
    }
}
