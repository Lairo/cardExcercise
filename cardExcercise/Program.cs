using System;
using System.Collections.Generic;

namespace cardExcercise
{
    internal class Program
    {
        public static readonly Random random = new Random();
        private static bool foundIt;


        static void Main()
        {
            //Card myCard = new Card(Suit.Spades, Value.Ace);

            //Console.WriteLine(myCard.Name);

            //int count = 0;
            //while (count != 20)
            //{
            //    int numberBetween0and3 = random.Next(4);
            //    int numberBetween1and13 = random.Next(1, 14);
            //    Card randomCard = new Card((Suit)numberBetween0and3, (Value)numberBetween1and13);
            //    Console.WriteLine($"{count+1} {randomCard.Name}");
            //    count++;
            //}
            List<Card> cards = new List<Card>();

            cards.Add(new Card(Suit.Diamonds, Value.King));
            cards.Add(new Card((Suit)2, (Value)3));
            cards.Add(new Card(Suit.Hearts, Value.Ace));
            Console.WriteLine($"{cards[0].Name}\n{cards[1].Name}\n{cards[2].Name}\n");

            string[] aString = new string[3];

            //aCard[0] = new Card(Suit.Diamonds, Value.King);
            //aCard[1] = new Card((Suit)2, (Value)3);
            //aCard[2] = new Card(Suit.Hearts, Value.Ace);

            //Console.WriteLine($"{aCard[0].Name}\n{aCard[1].Name}\n{aCard[2].Name}\n");

            string a = "Yay!";
            string b = "Bummer";

            aString[0] = a;
            aString[1] = b;

            int theSize = aString.Length;

            
            for (int i = 0; i < theSize; i++)
            {
                if (aString[i] == b)
                {
                    foundIt = true;
                    Console.WriteLine(foundIt.ToString());
                    break;
                }
            }

        }
    }
}