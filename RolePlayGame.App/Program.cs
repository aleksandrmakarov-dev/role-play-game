using System.Drawing;
using RolePlayGame.Graphics;

namespace RolePlayGame.App
{

    public class Program
    {
        private const int _w = 120;
        private const int _h = 30;

        private static Screen _screen;

        private static Point p = new Point(0,0);



        static void Main()
        {
            _screen = new Screen(_w,_h,8,8);

            _screen.Update += OnScreenUpdate;
            _screen.Start();
        }

        private static void OnScreenUpdate(object? sender, EventArgs e)
        {

        }
    }
}
