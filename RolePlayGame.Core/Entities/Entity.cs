using System.Drawing;
using RolePlayGame.Core.Entities.Utils;

namespace RolePlayGame.Core.Entities
{
    public abstract class Entity
    {
        private double _health;
        private Point _position;
        private Level _level;

        public Entity(double health, Point point, Level level) 
        {
            _health = health;
            _position = point;
            _level = level;
        }
    }
}
