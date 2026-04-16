using System;

namespace ConnectFourProject
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int MakeMove()
        {
            Console.Write($"{Name} ({Symbol}), choose a column (1-7): ");
            int column;
            while (!int.TryParse(Console.ReadLine(), out column) || column < 1 || column > 7)
            {
                Console.Write("Invalid input. Please enter a number from 1 to 7: ");
            }

            return column - 1;
        }
    }
}
