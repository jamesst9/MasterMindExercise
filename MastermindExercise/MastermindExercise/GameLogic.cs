using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MastermindExercise {
    public class GameLogic {
        public static string ExecuteGame(int MasterMindNum, int guessesTaken)
        {
            string positionString = null;
           

            Console.WriteLine($"You currently have {10 - guessesTaken} guess(es) left.\n");
            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < guess.ToString().Length; i++)
                {
                    if (guess.ToString()[i] == MasterMindNum.ToString()[i])
                    {
                        positionString += "+";
                    }
                    else if (MasterMindNum.ToString().Contains(guess.ToString()[i]))
                    {
                        positionString += "-";
                    }
                    else
                    {
                        positionString += " ";
                    }
                }


            }

            catch (Exception e)
            {
                Console.WriteLine("Your answer is invalid. Try again!");
            }


            return positionString;
        }



    }
}
