using System;

namespace cardExcercise
{
    internal class Program
    {
        public static readonly Random random = new Random();

        static void Main()
        {
            Card myCard = new Card(Suit.Spades, Value.Ace);
            Console.WriteLine(myCard.Name);

            
            
           

            int count = 0;
            while (count != 20)
            {
                int numberBetween0and3 = random.Next(4);
                int numberBetween1and13 = random.Next(1, 14);
                Card randomCard = new Card((Suit)numberBetween0and3, (Value)numberBetween1and13);
                Console.WriteLine($"{count+1} {randomCard.Name}");
                count++;
            }

        }
    }
}
