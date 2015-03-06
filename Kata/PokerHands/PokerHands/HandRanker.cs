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
                if (hand1ByValues.Count(i => i.Count == 2) == 2 && hand2ByValues.Count(i => i.Count == 2) != 2) return 1;

                if (hand2ByValues.Count(i => i.Count == 2) == 2 && hand1ByValues.Count(i => i.Count == 2) != 2) return 2;

                // Both Have 2 Pair find Highest Pair Value
                var hand1HighestPairValue = hand1ByValues.Where(i => i.Count == 2).OrderByDescending(i => i.Value).Select(i => i.Value).FirstOrDefault();
                var hand2HighestPairValue = hand2ByValues.Where(i => i.Count == 2).OrderByDescending(i => i.Value).Select(i => i.Value).FirstOrDefault();

                if (hand1HighestPairValue > hand2HighestPairValue)
                {
                    return 1;
                }

                if (hand1HighestPairValue < hand2HighestPairValue)
                {
                    return 2;
                }

                // Same Highest Pair must compare next
                hand1ByValues = hand1ByValues.Where(i => i.Value != hand1HighestPairValue).ToList();
                hand2ByValues = hand2ByValues.Where(i => i.Value != hand2HighestPairValue).ToList();
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

                // Remove Pair Values 3 Cards Left
                hand1 = hand1.Where(i => i.CardValue != hand1PairValue).ToList();
                hand2 = hand2.Where(i => i.CardValue != hand1PairValue).ToList();

                // They have the same pair must compare kickers
                if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

                if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

                // They have the same kicker must remove max card 2 Cards Left
                var hand1MaxCardPair = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

                hand1.Remove(hand1MaxCardPair);

                var hand2MaxCardPair = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

                hand2.Remove(hand2MaxCardPair);

                if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

                if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

                // They have the same kicker must remove max card 1 Cards Left
                hand1MaxCardPair = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

                hand1.Remove(hand1MaxCardPair);

                hand2MaxCardPair = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

                hand2.Remove(hand2MaxCardPair);

                if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

                if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;
            }

            // No Pairs high card wins
            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            // Have Same High Card Must remove the high card and compare  4 Cards Left
            var hand1MaxCard = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

            hand1.Remove(hand1MaxCard);

            var hand2MaxCard = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

            hand2.Remove(hand2MaxCard);

            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            // Have Same High Card Must remove the high card and compare 3 Cards Left
            hand1MaxCard = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

            hand1.Remove(hand1MaxCard);

            hand2MaxCard = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

            hand2.Remove(hand2MaxCard);

            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            // Have Same High Card Must remove the high card and compare 2 Cards Left
            hand1MaxCard = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

            hand1.Remove(hand1MaxCard);

            hand2MaxCard = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

            hand2.Remove(hand2MaxCard);

            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            // Have Same High Card Must remove the high card and compare 1 Cards Left
            hand1MaxCard = hand1.FirstOrDefault(j => (int)j.CardValue == hand1.Max(i => (int)i.CardValue));

            hand1.Remove(hand1MaxCard);

            hand2MaxCard = hand2.FirstOrDefault(j => (int)j.CardValue == hand2.Max(i => (int)i.CardValue));

            hand2.Remove(hand2MaxCard);

            if (hand1.Max(i => (int)i.CardValue) > hand2.Max(i => (int)i.CardValue)) return 1;

            if (hand1.Max(i => (int)i.CardValue) < hand2.Max(i => (int)i.CardValue)) return 2;

            return -1;
        }
    }
}