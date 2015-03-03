using FluentAssertions;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    [Category("PokerHands.Tests")]
    public class HandRankerTests
    {
        private Card[] _allCardArray;

        [SetUp]
        public void SetUp()
        {
            _allCardArray = new[]
                            {
                                    new Card(Suit.Club, CardValue.Two),
                                    new Card(Suit.Club, CardValue.Three),
                                    new Card(Suit.Club, CardValue.Four),
                                    new Card(Suit.Club, CardValue.Five),
                                    new Card(Suit.Club, CardValue.Six),
                                    new Card(Suit.Club, CardValue.Seven),
                                    new Card(Suit.Club, CardValue.Eight),
                                    new Card(Suit.Club, CardValue.Nine),
                                    new Card(Suit.Club, CardValue.Ten),
                                    new Card(Suit.Club, CardValue.Jack),
                                    new Card(Suit.Club, CardValue.Queen),
                                    new Card(Suit.Club, CardValue.King),
                                    new Card(Suit.Club, CardValue.Ace),
                                    new Card(Suit.Heart, CardValue.Two),
                                    new Card(Suit.Heart, CardValue.Three),
                                    new Card(Suit.Heart, CardValue.Four),
                                    new Card(Suit.Heart, CardValue.Five),
                                    new Card(Suit.Heart, CardValue.Six),
                                    new Card(Suit.Heart, CardValue.Seven),
                                    new Card(Suit.Heart, CardValue.Eight),
                                    new Card(Suit.Heart, CardValue.Nine),
                                    new Card(Suit.Heart, CardValue.Ten),
                                    new Card(Suit.Heart, CardValue.Jack),
                                    new Card(Suit.Heart, CardValue.Queen),
                                    new Card(Suit.Heart, CardValue.King),
                                    new Card(Suit.Heart, CardValue.Ace),
                                    new Card(Suit.Spade, CardValue.Two),
                                    new Card(Suit.Spade, CardValue.Three),
                                    new Card(Suit.Spade, CardValue.Four),
                                    new Card(Suit.Spade, CardValue.Five),
                                    new Card(Suit.Spade, CardValue.Six),
                                    new Card(Suit.Spade, CardValue.Seven),
                                    new Card(Suit.Spade, CardValue.Eight),
                                    new Card(Suit.Spade, CardValue.Nine),
                                    new Card(Suit.Spade, CardValue.Ten),
                                    new Card(Suit.Spade, CardValue.Jack),
                                    new Card(Suit.Spade, CardValue.Queen),
                                    new Card(Suit.Spade, CardValue.King),
                                    new Card(Suit.Spade, CardValue.Ace),
                                    new Card(Suit.Diamond, CardValue.Two),
                                    new Card(Suit.Diamond, CardValue.Three),
                                    new Card(Suit.Diamond, CardValue.Four),
                                    new Card(Suit.Diamond, CardValue.Five),
                                    new Card(Suit.Diamond, CardValue.Six),
                                    new Card(Suit.Diamond, CardValue.Seven),
                                    new Card(Suit.Diamond, CardValue.Eight),
                                    new Card(Suit.Diamond, CardValue.Nine),
                                    new Card(Suit.Diamond, CardValue.Ten),
                                    new Card(Suit.Diamond, CardValue.Jack),
                                    new Card(Suit.Diamond, CardValue.Queen),
                                    new Card(Suit.Diamond, CardValue.King),
                                    new Card(Suit.Diamond, CardValue.Ace)
                            };
        }

        [Test]
        public void HandWithHighestRankWins()
        {
            var handRanker = new HandRanker();

            var hand1 = new[]
                        {
                                _allCardArray[0],
                                _allCardArray[1],
                                _allCardArray[3],
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Seven)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            var winner = handRanker.RankHands(hand1, hand2);

            winner.Should().Be(2);
        }
    }
}