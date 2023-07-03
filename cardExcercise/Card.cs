namespace cardExcercise
{
    internal class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }


        public Card(Suit suit, Value value)
        {
            Value = value;
            Suit = suit;
        }
    }
}
