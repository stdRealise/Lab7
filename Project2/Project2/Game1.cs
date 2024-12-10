using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Manager _manager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {
            _manager = new Manager();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _manager.AddObject(new CollisionObject(new Vector2(200, 840), Content.Load<Texture2D>("wraith")));
            _manager.AddObject(new CollisionObject(new Vector2(1, 40), Content.Load<Texture2D>("scout")));
            _manager.AddObject(new MovingObject(new Vector2(2, 2), Content.Load<Texture2D>("carrier"), new Vector2(2, 0)));
            _manager.AddObject(new CollisionMoving(new Vector2(1650, 2), Content.Load<Texture2D>("phoenix"), new Vector2(2, 5)));
            _manager.AddObject(new CollisionControlled(new Vector2(500, 500), Content.Load<Texture2D>("cruiser"), new Vector2(5, 10)));
        }

        protected override void Update(GameTime gameTime)
        { 
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            _manager.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            _manager.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

