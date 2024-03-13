namespace RolePlayGame.Graphics
{
    public class Screen
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int _fontWidth;
        private readonly int _fontHeight;

        private char[,] buffer;

        private Thread _background;
        private ManualResetEvent _shutdownEvent = new ManualResetEvent(false);

        private const int FrameTime = 500;

        public event EventHandler Update;

        public Screen(int width, int height, int fontWidth, int fontHeight)
        {
            _width = width;
            _height = height;
            _fontWidth = fontWidth;
            _fontHeight = fontHeight;

            Initialize();
        }


        public void Stop()
        {
            _shutdownEvent.Set();
        }

        public void Start()
        {
            _background.Join();
        }

        public void Print(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }

        private void Initialize()
        {
            buffer = new char[_width, _height];

            Console.SetBufferSize(_width,_height);
            Console.SetWindowSize(_width,_height);
            Console.CursorVisible = false;

            _background = new Thread(RunInBackground)
            {
                IsBackground = true
            };

            _background.Start();
        }

        private void RunInBackground()
        {

            while (!_shutdownEvent.WaitOne(FrameTime))
            {
                Update.Invoke(this,EventArgs.Empty);
            }
        }
    }
}
