using System.Collections.Generic;
using System.Linq;

namespace PokerHands
{
    public class HandRanker
    {
        public int RankHands(IList<Card> hand1, IList<Card> hand2)
        {
            var hand1ByValues = hand1.GroupBy(i => i.CardValue).Select(g => new
                                                                            {
                                                                                    Value = g.Key,
                                                                                    Count = g.Select(v => (int)v.CardValue).Count()
                                                                            }).ToList();

            var hand2ByValues = hand2.GroupBy(i => i.CardValue).Select(g => new
                                                                            {
                                                                                    Value = g.Key,
                                                                                    Count = g.Select(v => (int)v.CardValue).Count()
                                                                            }).ToList();

            // One of the hands have 2 pairs
            if (hand1ByValues.Count(i => i.Count == 2) == 2 || hand2ByValues.Count(i => i.Count == 2) == 2)
            {
                if (hand1ByValues.Count(i => i.Count == 2) == 2) return 1;

                if (hand2ByValues.Count(i => i.Count == 2) == 2) return 2;
            }

            // One of the hands have a pair
            if (hand1ByValues.Any(i => i.Count == 2) || hand2ByValues.Any(i => i.Count == 2))
            {
                if (hand1ByValues.Any(i => i.Count == 2) && hand2ByValues.All(i => i.Count != 2)) return 1;

                if (hand1ByValues.All(i => i.Count != 2) && hand2ByValues.Any(i => i.Count == 2)) return 2;

                var hand1PairValue = hand1ByValues.Where(i => i.Count == 2).Select(i => i.Value).FirstOrDefault();
                var hand2PairValue = hand2ByValues.Where(i => i.Count == 2).Select(i => i.Value).FirstOrDefault();

                if (hand1PairValue > hand2PairValue) return 1;

                if (hand1PairValue < hand2PairValue) return 2;

                if (hand1.Max(i => (int)i.CardValue) >= hand2.Max(i => (int)i.CardValue)) return 1;

                return 2;
            }

            // No Pairs high card wins
            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            // Have Same High Card
            var hand1MaxCard = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

            hand1.Remove(hand1MaxCard);

            var hand2MaxCard = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

            hand2.Remove(hand2MaxCard);

            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            return 2;
        }
    }
}