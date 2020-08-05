using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static int player = 2;
        static int input = 0;
        static bool runGame = true;
        static bool inputCorrect = true;

        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                PlayGame();
            }
            
        }
        public static void SetField()
        {
            Console.Clear(); 
            Console.WriteLine("****Tic Tac Toe****\n\n");
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2}    ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2}    ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2}    ", playField[2, 0], playField[2, 1], playField[2, 2]);
           
        }
        public static void PlayGame()
        {

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('X', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('O', input);
                }
                SetField();

                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar)))
                    {
                        if (playerChar == 'O')
                        {
                            Console.WriteLine("\nPlayer 1 Win!");
                            Console.WriteLine("Press any key to Restart the Game");
                            Console.ReadKey();
                            runGame = false;
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 2 Win!");
                            Console.WriteLine("Press any key to Restart the Game");
                            Console.ReadKey();
                            runGame = false;
                        }

                    }
                }
                if (runGame)
                {
                    do
                    {


                        Console.WriteLine("\nPlayer {0} Choose your field: ", player);
                        try
                        {
                            input = Convert.ToInt32(Console.ReadLine());
                            if ((input == 1) && (playField[0, 0] == '1'))
                                inputCorrect = true;
                            else if ((input == 2) && (playField[0, 1] == '2'))
                                inputCorrect = true;
                            else if ((input == 3) && (playField[0, 2] == '3'))
                                inputCorrect = true;
                            else if ((input == 4) && (playField[1, 0] == '4'))
                                inputCorrect = true;
                            else if ((input == 5) && (playField[1, 1] == '5'))
                                inputCorrect = true;
                            else if ((input == 6) && (playField[1, 2] == '6'))
                                inputCorrect = true;
                            else if ((input == 7) && (playField[2, 0] == '7'))
                                inputCorrect = true;
                            else if ((input == 8) && (playField[2, 1] == '8'))
                                inputCorrect = true;
                            else if ((input == 9) && (playField[2, 2] == '9'))
                                inputCorrect = true;
                            else
                            {
                                if ((input > 0 && input < 10))
                                {
                                    Console.WriteLine("\nPlease Choose another field");
                                    inputCorrect = false;
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease Choose from 1 to 9");
                                    inputCorrect = false;
                                }
                            }

                        }
                        catch
                        {
                            Console.WriteLine("\nPlease input a number");
                        }


                    } while (!inputCorrect);
                }

            } while (runGame);
            ResetGame();
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;

                //default:
                //    Console.WriteLine("Please input between 1 to 9");
                //    break;
            }
        }
        public static void ResetGame()
        {
           char[,] resetPlayField =
{
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
            playField = resetPlayField;
            player = 2;
            input = 0;
            runGame = true;
            inputCorrect = true;
        }
    }
}