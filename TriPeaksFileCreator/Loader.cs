using System.ComponentModel;
using System.Text.RegularExpressions;

namespace TriPeaksSolver
{
    public static class Loader
    {
        private static List<Card> pileCards = [];
        private static List<Card> boardCards = [];

        public static (Board board, Pile pile) LoadDummy()
        {
            Pile pile = new(
                [ new ("6", CardType.Spade, true), new ("7", CardType.Diamond, true), new ("6", CardType.Club, true), new ("2", CardType.Diamond, true)
            , new ("Q", CardType.Diamond, true), new ("7", CardType.Club, true), new ("8", CardType.Heart, true), new ("10", CardType.Club, true)
            , new ("J", CardType.Diamond, true), new ("8", CardType.Club, true), new ("5", CardType.Spade, true), new ("5", CardType.Diamond, true)
            , new ("8", CardType.Diamond, true), new ("9", CardType.Heart, true), new ("K", CardType.Club, true), new ("9", CardType.Diamond, true)
            , new ("3", CardType.Heart, true), new ("4", CardType.Diamond, true), new ("5", CardType.Club, true), new ("A", CardType.Spade, true)
            , new ("J", CardType.Heart, true), new ("A", CardType.Diamond, true), new ("A", CardType.Heart, true), new ("10", CardType.Spade, true) ]);

            List<Card> c = [];

            c.Add(new("Q", CardType.Heart));
            c.Add(new("K", CardType.Spade));
            c.Add(new("3", CardType.Club));

            c.Add(new("10", CardType.Heart));
            c.Add(new("J", CardType.Spade));
            c.Add(new("A", CardType.Club));
            c.Add(new("Q", CardType.Club));
            c.Add(new("3", CardType.Diamond));
            c.Add(new("5", CardType.Heart));

            c.Add(new("4", CardType.Club));
            c.Add(new("9", CardType.Spade));
            c.Add(new("Q", CardType.Spade));
            c.Add(new("9", CardType.Club));
            c.Add(new("2", CardType.Spade));
            c.Add(new("2", CardType.Heart));
            c.Add(new("2", CardType.Club));
            c.Add(new("K", CardType.Heart));
            c.Add(new("7", CardType.Spade));

            c.Add(new("3", CardType.Spade));
            c.Add(new("6", CardType.Diamond));
            c.Add(new("7", CardType.Heart));
            c.Add(new("K", CardType.Diamond));
            c.Add(new("8", CardType.Spade));
            c.Add(new("4", CardType.Heart));
            c.Add(new("10", CardType.Diamond));
            c.Add(new("4", CardType.Spade));
            c.Add(new("6", CardType.Heart));
            c.Add(new("J", CardType.Club));

            Board board = LinkBoard(c);

            return (board, pile);
        }

        public static (Board board, Pile pile) LoadFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            return LoadFromLines(lines);
        }

        public static (Board board, Pile pile) LoadFromText(string text)
        {
            var lines = text.Split("\n");
            return LoadFromLines(lines);
        }

        public static (Board board, Pile pile) LoadFromLines(string[] lines)
        {
            pileCards = [];
            boardCards = [];

            bool parsingPile = false;
            bool parsingBoard = false;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (line.StartsWith("Pile:")) { parsingPile = true; parsingBoard = false; continue; }
                if (line.StartsWith("Board")) { parsingPile = false; parsingBoard = true; continue; }

                if (parsingPile)
                {
                    pileCards.AddRange(ParseCardsFromPileLine(line));
                }
                else if (parsingBoard)
                {
                    boardCards.AddRange(ParseCardsFromBoardLine(line));
                }
            }

            // Standard TriPeaks uses 28 cards on the board.
            if (boardCards.Count != 28)
                throw new Exception($"Expected 28 board cards, but found {boardCards.Count}.");

            return (LinkBoard(boardCards), new Pile(pileCards));
        }

        private static List<Card> ParseCardsFromLine(string line, bool isPile = false)
        {
            // This regex captures cards like "K of Hearts", "10 of Spades", or just "K"
            // It splits by spaces but keeps "of Suit" parts together if present.
            var matches = Regex.Matches(line, @"(\w+)( of \w+)?");
            List<Card> cards = [];

            foreach (Match match in matches)
            {
                string rank = match.Groups[1].Value;
                CardType type = CardType.Spade; // Default

                if (match.Groups[2].Success)
                {
                    string typeStr = match.Groups[2].Value.Replace(" of ", "").Trim();
                    Enum.TryParse(typeStr, true, out type);
                }

                cards.Add(new Card(rank, type, isPile));
            }
            return cards;
        }

        private static List<Card> ParseCardsFromPileLine(string line)
        {
            line = line.TrimEnd(", ".ToCharArray());
            string[] matches = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

            List<Card> cards = [];

            foreach (string match in matches)
            {
                string[] strCard = match.Trim().Split(" of ", StringSplitOptions.RemoveEmptyEntries);

                if (strCard.Length > 1)
                {
                    string rank = strCard[0].Trim();
                    string typeStr = strCard[1].Trim();
                    Enum.TryParse(typeStr, true, out CardType type);

                    cards.Add(new Card(rank, type, true));
                }
                else
                {
                    cards.Add(new Card());
                }
            }
            return cards;
        }

        private static List<Card> ParseCardsFromBoardLine(string line)
        {
            string[] matches = line.Split("  ", StringSplitOptions.RemoveEmptyEntries);

            List<Card> cards = [];

            foreach (string match in matches)
            {
                string[] strCard = match.Trim().Split(" of ", StringSplitOptions.RemoveEmptyEntries);

                if (strCard.Length > 1)
                {
                    string rank = strCard[0].Trim();
                    string typeStr = strCard[1].Trim();
                    Enum.TryParse(typeStr, true, out CardType type);

                    cards.Add(new Card(rank, type, false));
                }
                else
                {
                    cards.Add(new Card());
                }
            }
            return cards;
        }

        private static Board LinkBoard(List<Card> c)
        {
            // We assume the boardCards list is ordered from Top Row to Bottom Row.
            // Indices: 
            // 0, 1, 2 (Peaks)
            // 3-8 (Row 2)
            // 9-17 (Row 3)
            // 18-27 (Row 4 - Bottom)

            // Link Row 3 to Row 4 (Bottom Row)
            for (int i = 0; i < 9; i++)
            {
                c[9 + i].Card1 = c[18 + i];
                c[9 + i].Card2 = c[18 + i + 1];
            }

            // Link Row 2 to Row 3
            c[3].Card1 = c[9];
            c[3].Card2 = c[10];
            c[4].Card1 = c[10];
            c[4].Card2 = c[11];
            c[5].Card1 = c[12];
            c[5].Card2 = c[13];
            c[6].Card1 = c[13];
            c[6].Card2 = c[14];
            c[7].Card1 = c[15];
            c[7].Card2 = c[16];
            c[8].Card1 = c[16];
            c[8].Card2 = c[17];

            // Link Row 1 to Row 2
            c[0].Card1 = c[3];
            c[0].Card2 = c[4];
            c[1].Card1 = c[5];
            c[1].Card2 = c[6];
            c[2].Card1 = c[7];
            c[2].Card2 = c[8];

            return new Board(c[0], c[1], c[2]);
        }

        public static List<Card> GetBoradCards()
        {
            return boardCards;
        }
    }
}