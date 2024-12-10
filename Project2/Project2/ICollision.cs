using Microsoft.Xna.Framework;

namespace Project2
{
    interface ICollision
    {
        bool CheckCollision(ICollision obj);
        void Collision();
        Rectangle Bounds
        {
            get;
        }
    }
}
