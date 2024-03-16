using System.Drawing;
using RolePlayGame.Graphics;

namespace RolePlayGame.App
{

    public class Program
    {
        private const int _w = 120;
        private const int _h = 30;
        private static Engine _engine;
        private static Random _rand = new Random();

        static void Main()
        {
            _engine = new Engine(_w, _h);

            BounceNode node1 = new BounceNode(10, 10, 2, 2,1,1);
            node1.LoadTexture('*', '@', '3', 'a');
            node1.SetBounds(0, _w, 0, _h);

            BounceNode node2 = new BounceNode(20,20, 2,1, -1, -1);
            node2.LoadTexture('#', '#');
            node2.SetBounds(0, _w, 0, _h);

            BounceNode node3 = new BounceNode(2, 2, 1,2, -1, 1);
            node3.LoadTexture('#', '#');
            node3.SetBounds(0, _w, 0, _h);

            BounceNode node4 = new BounceNode(5,5, 1, 1, 1, -1);
            node4.LoadTexture('@');
            node4.SetBounds(0,_w,0,_h);

            BounceNode node5 = new BounceNode(25, 25, 3, 3, 1, -1);
            node5.Color = ConsoleColor.Green;
            node5.Background = ConsoleColor.DarkGreen;
            node5.LoadTexture('#', '#', '#', '#', '#', '#', '#', '#', '#');
            node5.SetBounds(0, _w, 0, _h);

            Scene main = new Scene(_w,_h,new List<Node> { node1, node2, node3, node4,node5 });

            _engine.AddScene(nameof(main), main);
            _engine.AddActiveScene(nameof(main));

            _engine.Start();
        }
    }
}
