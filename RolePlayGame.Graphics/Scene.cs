namespace RolePlayGame.Graphics
{
    public class Scene
    {
        private readonly int _w;
        private readonly int _h;
        private Char[,] _buffer;

        private List<Node> _nodes;

        public Scene(int width, int height,List<Node> nodes)
        {
            _w = width;
            _h = height;

            initializeBuffer(width, height);

            _nodes = nodes;
        }

        public void Update()
        {
            foreach (Node node in _nodes)
            {
                node.Update();
            }
        }

        public void Draw() 
        {
            clearBuffer();

            foreach (var node in _nodes)
            {
                node.Draw(_buffer);
            }

            drawBuffer();
        }

        private void drawBuffer()
        {
            for(int i = 0; i < _h; i++)
            {
                for(int j = 0; j < _w; j++)
                {
                    Char ch = _buffer[i, j];

                    Console.SetCursorPosition(j,i);

                    Console.ForegroundColor = ch.color;
                    Console.BackgroundColor = ch.background;

                    Console.Write(ch.c);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }

        private void initializeBuffer(int width, int height)
        {
            _buffer = new Char[height,width];

            clearBuffer();
        }

        private void clearBuffer()
        {
            for (int i = 0; i < _h; i++)
            {
                for (int j = 0; j < _w; j++)
                {
                    _buffer[i, j] = new Char(' ');
                }
            }
        }
    }
}
