using System;

namespace ConnectFourProject
{
    public class GameController
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public GameController()
        {
            board = new Board();
            Console.Write("Enter Player 1 name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter Player 2 name: ");
            string name2 = Console.ReadLine();

            player1 = new HumanPlayer(name1, 'X');
            player2 = new HumanPlayer(name2, 'O');
            currentPlayer = player1;
        }

        public void StartGame()
        {
            bool playAgain = true;
            Console.WriteLine("=== Welcome to Connect Four ===");
            Console.WriteLine("Get 4 symbols in a row to win.");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            while (playAgain)
            {
                board.InitializeBoard();
                currentPlayer = player1;
                bool gameRunning = true;

                while (gameRunning)
                {
                    Console.Clear();
                    board.DisplayBoard();

                    int column = currentPlayer.MakeMove();

                    if (!board.DropDisc(column, currentPlayer.Symbol))
                    {
                        Console.WriteLine("This column is full. Try another one.");
                        Console.ReadKey();
                        continue;
                    }

                    if (board.CheckWinner(currentPlayer.Symbol))
                    {
                        Console.Clear();
                        board.DisplayBoard();
                        Console.WriteLine($"{currentPlayer.Name} wins!");
                        gameRunning = false;
                    }
                    else if (board.IsBoardFull())
                    {
                        Console.Clear();
                        board.DisplayBoard();
                        Console.WriteLine("The game is a draw.");
                        gameRunning = false;
                    }
                    else
                    {
                        SwitchPlayer();
                    }
                }

                Console.Write("Do you want to play again? (Y/N): ");
                string answer = Console.ReadLine().ToUpper();

                if (answer != "Y")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }

        private void SwitchPlayer()
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }
        }
    }
}