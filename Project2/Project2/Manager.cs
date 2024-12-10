using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


namespace Project2
{
    class Manager
    {
        private List<GameObject> _gameObjects;
        public Manager()
        {
            _gameObjects = new List<GameObject>();
        }

        public void AddObject(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
        }

        private void CheckCollisions()
        {
            for (int i = 0; i < _gameObjects.Count; i++)
            {
                for (int j = i + 1; j < _gameObjects.Count; j++)
                {
                    if (_gameObjects[i] is ICollision obj && _gameObjects[j] is ICollision obj2)
                    {
                        if(obj.CheckCollision(obj2))
                        {
                            OnCollision(obj);
                            OnCollision(obj2);
                        }
                    }
                }
            }
        }

        public void OnCollision(ICollision gameObject)
        {
            gameObject.Collision();
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameObject obj in _gameObjects)
                obj.Update(gameTime);
                CheckCollisions();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in _gameObjects)
                obj.Draw(spriteBatch);
        }

    }
}
