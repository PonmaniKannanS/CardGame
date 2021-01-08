using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Model;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            #region Game menu
            //Menu
            Console.WriteLine("Welcome to card game!!!");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 to pick the card");
            Console.WriteLine("2 to shuffle the cards");
            Console.WriteLine("Restart the game");
            Console.WriteLine("Any other key to exit!!!");
            #endregion

            #region Main game part
            bool isGameToBeContinue = true;
            do
            {
                Console.Write("Enter input : ");
                try
                {
                    int input = int.Parse(Console.ReadLine().Trim());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine(deck.PlayACard());
                            break;
                        case 2:
                            deck.ShuffleDeck();
                            break;
                        case 3:
                            deck.RestartGame();
                            break;
                        default:
                            isGameToBeContinue = false;
                            Console.WriteLine("Invalid input!!!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    isGameToBeContinue = false;
                    Console.WriteLine("Input input!!!");
                }
                catch
                {
                    Console.WriteLine("General exception!!!");
                }

                Console.WriteLine("------------------------------------------------");

            } while (isGameToBeContinue);
            #endregion

            Console.ReadLine();
        }
    }
}
