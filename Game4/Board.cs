using System;

namespace ConnectFourProject
{
    public class Board
    {
        private char[,] grid;
        private int rows = 6;
        private int columns = 7;

        public Board()
        {
            grid = new char[rows, columns];
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    grid[row, col] = '.';
                }
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine();
            Console.WriteLine(" 1 2 3 4 5 6 7");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(" " + grid[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public bool DropDisc(int column, char symbol)
        {
            if (column < 0 || column >= columns)
            {
                return false;
            }

            for (int row = rows - 1; row >= 0; row--)
            {
                if (grid[row, column] == '.')
                {
                    grid[row, column] = symbol;
                    return true;
                }
            }

            return false;
        }
        public bool CheckWinner(char symbol)
        {
            return CheckHorizontal(symbol) ||
                   CheckVertical(symbol) ||
                   CheckDiagonal(symbol);
        }

        private bool CheckHorizontal(char symbol)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row, col + 1] == symbol &&
                        grid[row, col + 2] == symbol &&
                        grid[row, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckVertical(char symbol)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row + 1, col] == symbol &&
                        grid[row + 2, col] == symbol &&
                        grid[row + 3, col] == symbol)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckDiagonal(char symbol)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row + 1, col + 1] == symbol &&
                        grid[row + 2, col + 2] == symbol &&
                        grid[row + 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (grid[row, col] == symbol &&
                        grid[row - 1, col + 1] == symbol &&
                        grid[row - 2, col + 2] == symbol &&
                        grid[row - 3, col + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    } 

}
