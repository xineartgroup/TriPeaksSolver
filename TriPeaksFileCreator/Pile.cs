namespace TriPeaksSolver
{
    public class Pile
    {
        private int _Position = 0;

        private readonly List<Card> _Cards;

        public Pile(List<Card> cards)
        {
            _Cards = cards;
            _Position = _Cards.Count - 1;
        }

        public Card? GetNextCard()
        {
            if (_Position < 0)
            {
                return null;
            }
            Card card = _Cards[_Position];
            _Position--;
            return card;
        }

        public bool HasNextCard()
        {
            return _Position >= 0;
        }

        public void PutNextCard(Card card)
        {
            _Position++;
            _Cards.Insert(_Position, card);
        }
    }
}
