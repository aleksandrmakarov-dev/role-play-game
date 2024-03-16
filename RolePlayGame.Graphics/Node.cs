using System.Drawing;

namespace RolePlayGame.Graphics
{
    public class Node
    {
        protected int _x;
        protected int _y;

        protected int _w;
        protected int _h;

        protected char[] _data;

        public ConsoleColor Color { get; set; }
        public ConsoleColor Background { get; set; }

        public Node(
            int x, 
            int y, 
            int width, 
            int height, 
            ConsoleColor color = ConsoleColor.White, 
            ConsoleColor background = ConsoleColor.Black
            )
        {
            _x = x;
            _y = y;
            _w = width;
            _h = height;

            Color = color;
            Background = background;

            _data = new char[width * height];
        }

        public void LoadTexture(params char[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                _data[i] = data[i];
            }
        }

        public void Draw(Char[,] buffer)
        {

            for(int i = 0; i<_h; i++)
            {
                for(int j = 0; j < _w; j++)
                {
                    buffer[_y + i, _x + j] = new Char(_data[i * _w + j],Color,Background);
                }
            }
        }

        public virtual void Update()
        {

        }
    }
}
