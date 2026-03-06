namespace helloworld;

class TicTacToe
{
    // Slots to store options
    char[] slots = new char[9];

    // Display board
    void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{slots[0]}, {slots[1]}, {slots[2]}");
        Console.WriteLine($"{slots[3]}, {slots[4]}, {slots[5]}");
        Console.WriteLine($"{slots[6]}, {slots[7]}, {slots[8]}");
        Console.WriteLine("");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to Tradic's Tic Tac Toe!");
        Console.WriteLine("E means Empty, O means captured by Player 1, X means captured by Player 2");

        TicTacToe Board = new TicTacToe();

        // Set all slots of the board to empty
        for (int i = 0; i <= 8; i++)
        {
            Board.slots[i] = 'E';
        }

        // Display current state of the board
        Board.Display();

        for (int i = 1; i < 9; i++)
        {
            bool PlayerChance = (i % 2 != 0); // TRUE = PLAYER 1, FALSE = PLAYER 2
            char player = (PlayerChance) ? '1' : '2';
            Console.WriteLine($"Enter an index, it is currently Player {player}'s turn");
            Console.WriteLine("");
            
            string InputtedString = Console.ReadLine();
            int InputtedIndex;

            bool InputSuccess = int.TryParse(InputtedString, out InputtedIndex);
            
            while (!InputSuccess || InputtedIndex < 1 || InputtedIndex > 9 || Board.slots[InputtedIndex - 1] != 'E')
            {

                Console.WriteLine("Invalid input, please make sure the input is a numerical value between 1 and 9 and is not a already taken index.");
                Console.WriteLine("");

                InputtedString = Console.ReadLine();
                InputSuccess = int.TryParse(InputtedString, out InputtedIndex);
            }

            if (PlayerChance)
            {
                // Player 1
                Board.slots[InputtedIndex - 1] = 'O';
            }
            else
            {
                // Player 2
                Board.slots[InputtedIndex - 1] = 'X';
            }

            Board.Display();
            
            // WIN STATES
            if ((Board.slots[0] == Board.slots[1]) && (Board.slots[1] == Board.slots[2]) && Board.slots[0] != 'E' && Board.slots[1] != 'E' && Board.slots[2] != 'E')
            {
                Console.WriteLine($"Player {player} has won!");
                break;
            }
            else if ((Board.slots[3] == Board.slots[4]) && (Board.slots[4] == Board.slots[5]) && Board.slots[3] != 'E' && Board.slots[4] != 'E' && Board.slots[5] != 'E')
            {
                Console.WriteLine($"Player {player} has won!");
                break;
            }
            else if ((Board.slots[6] == Board.slots[7]) && (Board.slots[7] == Board.slots[8]) && Board.slots[6] != 'E' && Board.slots[7] != 'E' && Board.slots[8] != 'E')
            {
                Console.WriteLine($"Player {player} has won!");
                break;
            }
            else if ((Board.slots[0] == Board.slots[4]) && (Board.slots[4] == Board.slots[8]) && Board.slots[0] != 'E' && Board.slots[4] != 'E' && Board.slots[8] != 'E')
            {
                Console.WriteLine($"Player {player} has won!");
                break;
            }
            else if ((Board.slots[2] == Board.slots[4]) && (Board.slots[4] == Board.slots[6]) && Board.slots[2] != 'E' && Board.slots[4] != 'E' && Board.slots[6] != 'E')
            {
                Console.WriteLine($"Player {player} has won!");
                break;
            }
            else if (i == 9)
            {
                Console.WriteLine("");
                Console.WriteLine("     DRAW     ");
                Console.WriteLine("");
            }

        }

    }
}
