using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayGame.Graphics
{
    public class Engine
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int timeframe = 10;

        private Dictionary<string, Scene> gameScenes;
        private Dictionary<string, Scene> activeScenes;

        private ManualResetEvent _shutdownEvent = new ManualResetEvent(false);

        public Engine(int width, int height)
        {
            _width = width;
            _height = height;

            gameScenes = new Dictionary<string, Scene>();
            activeScenes = new Dictionary<string, Scene>();

            configureConsole();
        }

        public void Start()
        {
            while(!_shutdownEvent.WaitOne(timeframe)) 
            {
                foreach (var activeScene in  activeScenes)
                {
                    activeScene.Value.Update();
                    activeScene.Value.Draw();
                }
            }
        }

        public void Stop()
        {
            _shutdownEvent.Dispose();
        }

        public void AddScene(string key,Scene scene)
        {
            if (gameScenes.ContainsKey(key))
            {
                throw new ArgumentException("Scene is already in game");
            }

            gameScenes[key] = scene;
        }

        public void AddActiveScene(string key)
        {
            if (!gameScenes.ContainsKey(key))
            {
                throw new ArgumentException();
            }

            activeScenes[key] = gameScenes[key];
        }

        private void configureConsole()
        {
            Console.CursorVisible = false;
            Console.Clear();

            Console.WindowHeight = _height;
            Console.WindowWidth = _width;

            Console.SetBufferSize(_width, _height);
        }
    }
}
