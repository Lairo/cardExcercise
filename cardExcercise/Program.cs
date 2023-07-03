using System;

namespace cardExcercise
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();

            Card myCard = new Card(Suit.Spades, Value.Ace);
            Console.WriteLine(myCard.Name);

            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInterger = random.Next();

            Card randomCard = new Card((Suit)numberBetween0and3, (Value)numberBetween1and13);

            Console.WriteLine(randomCard.Name);

        }
    }
}
