namespace TriPeaksSolver
{
    public class Card
    {
        private readonly string _Rank;
        private readonly CardType _Type;
        private readonly int _Value;
        private readonly bool _IsPile;

        public Card? Card1 = null;
        public Card? Card2 = null;

        public Card()
        {
            _Rank = "";
            _Type = CardType.None;
            _Value = 0;
            _IsPile = false;
        }

        public Card(string rank, CardType type, bool isPile = false)
        {
            _Rank = rank;
            _Type = type;
            _IsPile = isPile;
            if (rank == "K" || rank == "King")
            {
                _Value = 13;
            }
            else if (rank == "Q" || rank == "Queen")
            {
                _Value = 12;
            }
            else if (rank == "J" || rank == "Jack")
            {
                _Value = 11;
            }
            else if (rank == "A" || rank == "Ace")
            {
                _Value = 1;
            }
            else if (rank == "2" || rank == "3" 
                || rank == "4" || rank == "5" 
                || rank == "6" || rank == "7" 
                || rank == "8" || rank == "9"
                || rank == "10")
            {
                _Value = Convert.ToInt32(rank);
            }
            else
            {
                _Value = 0;
            }
        }

        public string GetRank()
        {
            return _Rank;
        }

        public int GetValue()
        {
            return _Value;
        }

        public CardType GetCardType()
        {
            return _Type;
        }

        public string GetCardTypeSymbol()
        {
            if (_Type == CardType.Heart) return "♥";
            else if (_Type == CardType.Diamond) return "♦";
            else if (_Type == CardType.Club) return "♣";
            else return "♠";
        }

        public string GetString()
        {
            return (_IsPile ? " -> " : "") + $"{_Rank}{GetCardTypeSymbol()}";
        }

        public override string ToString()
        {
            return $"{_Rank} of {_Type}";
        }
    }
}