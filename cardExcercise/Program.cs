using System;
using System.Collections.Generic;

namespace cardExcercise
{
    internal class Program
    {
        public static readonly Random random = new Random();

        static void Main()
        {
            Card myCard = new Card(Suit.Spades, Value.Ace);
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
            Console.WriteLine(cards[0].Name);
            Console.WriteLine(cards[1].Name);
            Console.WriteLine(cards[2].Name);

        }
    }
}