using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Graphics
{
    public class BounceNode : Node
    {
        private int _boundLeft = 0;  
        private int _boundRight = 0;
        private int _boundTop = 0;
        private int _boundBottom = 0;

        private int _dirX;
        private int _dirY;

        public BounceNode(int x, int y, int width, int height, int dirX, int dirY) : base(x, y, width, height)
        {
            _dirX = dirX;
            _dirY = dirY;
        }

        public void SetBounds(int l, int r, int b, int t)
        {
            _boundLeft = l;
            _boundRight = r;
            _boundTop = t;
            _boundBottom = b;
        }

        public override void Update()
        {
            if (_x <= _boundLeft || _x + _w >= _boundRight)
            {
                _dirX = -_dirX;
            }

            if (_y <= _boundBottom || _y + _h >= _boundTop)
            {
                _dirY = -_dirY;
            }

            _x += _dirX;
            _y += _dirY;
        }
    }
}
