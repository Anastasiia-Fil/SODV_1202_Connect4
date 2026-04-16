using System;

namespace ConnectFourProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();
            game.StartGame();
        }
    }
}
