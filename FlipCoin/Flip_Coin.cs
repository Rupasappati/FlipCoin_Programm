using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class Flip_Coin
    {
        double heads = 0;
        double Tails = 0;
        Random number = new Random();

        public void Heads_Tails()
        {
            
            Console.WriteLine("Please enter the no.of Flips of the coin");
            double NumOfFlips = Convert.ToInt32(Console.ReadLine());

            if (NumOfFlips > 0)
            {
                for (int i = 0; i < NumOfFlips; i++)
                {
                    int coin = number.Next(1, 3);
                    if (coin == 1)
                    {
                        Console.WriteLine("User get Heads");
                        heads++;
                    }
                    else
                    {
                        Console.WriteLine("user get Tails");
                        Tails++;
                    }
                }

                double Percent_heads = Math.Round((heads / NumOfFlips) * 100);
                Console.WriteLine("Percentage of heads is {0}", Percent_heads);

                double Percent_tails = Math.Round((heads / NumOfFlips) * 100);
                Console.WriteLine("Percentage of heads is {0}", Percent_tails);
            }
            else
            {
                Console.WriteLine("please enter a valid num");
            }

        }
        
    
    }
}
