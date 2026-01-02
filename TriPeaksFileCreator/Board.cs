using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriPeaksSolver
{
    public class Board(Card card1, Card card2, Card card3)
    {
        public Card? Card1 = card1;
        public Card? Card2 = card2;
        public Card? Card3 = card3;

        // The cache stores "State Keys" we have already explored and found to be unsolvable
        private readonly HashSet<string> _failedStates = [];

        public List<Card>? GetSolveOrder(Pile pile)
        {
            _failedStates.Clear();
            List<Card> allCards = [];
            FindAllCards(Card1, allCards);
            FindAllCards(Card2, allCards);
            FindAllCards(Card3, allCards);

            if (!pile.HasNextCard()) return null;

            Card initialWaste = pile.GetNextCard()!;
            List<Card> history = [initialWaste];

            // Note: I removed 'static' so the method can access _failedStates
            if (Solve(allCards, pile, initialWaste, history, 0))
            {
                return history;
            }

            return null;
        }

        private bool Solve(List<Card> boardCards, Pile pile, Card currentWaste, List<Card> history, int pileDrawCount)
        {
            // 1. Base Case: Win
            if (boardCards.All(c => c == null)) return true;

            // 2. Generate a unique key for the current state
            string stateKey = GetStateKey(boardCards, pileDrawCount, currentWaste);
            if (_failedStates.Contains(stateKey)) return false;

            // 3. Try moves from the Board
            var availableMoves = boardCards
                .Select((card, index) => new { card, index })
                .Where(x => x.card != null && IsFaceUp(x.card, boardCards) && IsValidMove(currentWaste, x.card))
                .ToList();

            foreach (var move in availableMoves)
            {
                Card card = move.card!;
                int index = move.index;

                boardCards[index] = null!;
                history.Add(card);

                if (Solve(boardCards, pile, card, history, pileDrawCount)) return true;

                // Backtrack
                history.RemoveAt(history.Count - 1);
                boardCards[index] = card;
            }

            // 4. Try drawing from the Pile
            if (pile.HasNextCard())
            {
                Card nextFromPile = pile.GetNextCard()!;
                history.Add(nextFromPile);

                if (Solve(boardCards, pile, nextFromPile, history, pileDrawCount + 1)) return true;

                // Backtrack
                history.RemoveAt(history.Count - 1);
                pile.PutNextCard(nextFromPile);
            }

            // 5. If we get here, this state is a dead end. Cache it.
            _failedStates.Add(stateKey);
            return false;
        }

        private static string GetStateKey(List<Card> boardCards, int pileCount, Card waste)
        {
            // We represent the board as a string of 1s and 0s (1 = card present, 0 = null)
            char[] boardBitMap = new char[boardCards.Count];
            for (int i = 0; i < boardCards.Count; i++)
            {
                boardBitMap[i] = boardCards[i] == null ? '0' : '1';
            }
            return $"{new string(boardBitMap)}|{pileCount}|{waste.GetValue()}";
        }

        private static bool IsValidMove(Card waste, Card board)
        {
            int v1 = waste.GetValue();
            int v2 = board.GetValue();
            return Math.Abs(v1 - v2) == 1 || (v1 == 1 && v2 == 13) || (v1 == 13 && v2 == 1);
        }

        private static bool IsFaceUp(Card card, List<Card> boardCards)
        {
            // Optimization: If a card is not in the list, it's effectively "gone"
            bool card1Gone = card.Card1 == null || !boardCards.Contains(card.Card1);
            bool card2Gone = card.Card2 == null || !boardCards.Contains(card.Card2);
            return card1Gone && card2Gone;
        }

        private static void FindAllCards(Card? card, List<Card> list)
        {
            if (card == null || list.Contains(card)) return;
            list.Add(card);
            FindAllCards(card.Card1, list);
            FindAllCards(card.Card2, list);
        }

        public static string GetString(List<Card> cards)
        {
            StringBuilder sb = new StringBuilder();

            // 1. Enhanced CSS with Hover effects and larger symbols
            sb.AppendLine("<style>");
            sb.AppendLine("  .card-container { display: flex; flex-direction: column; gap: 12px; align-items: center; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; padding: 20px; }");

            // Card Base & Transition
            sb.AppendLine("  .card { border: 1px solid #ddd; border-radius: 10px; padding: 15px; width: 60px; background: #fff; ");
            sb.AppendLine("          box-shadow: 0 2px 5px rgba(0,0,0,0.08); transition: all 0.3s ease; cursor: default; }");

            // Hover Effect
            sb.AppendLine("  .card:hover { transform: translateY(-5px); box-shadow: 0 8px 15px rgba(0,0,0,0.1); border-color: #bbb; }");

            // Red Suits & Symbol Size
            sb.AppendLine("  .red-suit { color: #d63031; font-weight: bold; font-size: 1.4em; vertical-align: middle; line-height: 0; }");
            sb.AppendLine("  .card-content { font-size: 1.1em; color: #2d3436; display: flex; align-items: center; justify-content: center; }");
            sb.AppendLine("</style>");

            // 2. Open Container
            sb.AppendLine("<div class='card-container'>");

            foreach (var card in cards)
            {
                // Wrap symbols and apply the red-suit class
                string cardContent = card.GetString()
                    .Replace("♥", "<span class='red-suit'>♥</span>")
                    .Replace("♦", "<span class='red-suit'>♦</span>");

                sb.AppendLine("  <div class='card'>");
                sb.AppendFormat("    <div class='card-content'>{0}</div>", cardContent);
                sb.AppendLine("  </div>");
            }

            sb.AppendLine("</div>");

            return sb.ToString();
        }
    }
}