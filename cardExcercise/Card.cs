﻿namespace cardExcercise
{
    internal class Card
    {
        public Suit Suit { get; private set; }
        public Value Value { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }


        public Card(Suit suit, Value value)
        {
            Value = value;
            Suit = suit;
        }
    }
} 
    