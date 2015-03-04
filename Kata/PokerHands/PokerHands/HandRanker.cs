using System.Linq;

namespace PokerHands
{
    public class HandRanker
    {
        public int RankHands(Card[] hand1, Card[] hand2)
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

            // One of the hands have a pair
            if (hand1ByValues.Any(i => i.Count == 2) || hand2ByValues.Any(i => i.Count == 2))
            {
                if (hand1ByValues.Any(i => i.Count == 2) && hand2ByValues.All(i => i.Count != 2)) return 1;

                if (hand1ByValues.All(i => i.Count != 2) && hand2ByValues.Any(i => i.Count == 2)) return 2;

                var hand1PairValue = hand1ByValues.Where(i => i.Count == 2).Select(i => i.Value).FirstOrDefault();
                var hand2PairValue = hand2ByValues.Where(i => i.Count == 2).Select(i => i.Value).FirstOrDefault();

                if (hand1PairValue > hand2PairValue) return 1;

                return 2;
            }

            if (hand1.Max(i => (int)i.CardValue) >= hand2.Max(i => (int)i.CardValue)) return 1;

            return 2;
        }
    }
}