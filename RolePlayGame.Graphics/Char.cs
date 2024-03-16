namespace RolePlayGame.Graphics
{
    public struct Char
    {
        public char c;
        public ConsoleColor color;
        public ConsoleColor background;

        public Char(char c, ConsoleColor color = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            this.c = c;
            this.color = color;
            this.background = background;
        }
    }
}
