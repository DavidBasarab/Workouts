using FluentAssertions;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    [Category("PokerHands.Tests")]
    public class HandTests
    {
        private HandRanker _handRanker;

        [SetUp]
        public void SetUp()
        {
            _handRanker = new HandRanker();
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfTwos()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfThrees()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfFours()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Nine),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfFives()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Five),
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Nine),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfKings()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.King),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Nine),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfTwos()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void HandWithHighestRankWinsAceHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void HandWithHighestRankWinsEightHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
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

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void HandWithHighestRankWinsJackHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void HandWithHighestRankWinsKingHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void HandWithHighestRankWinsNineHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void HandWithHighestRankWinsQueenHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void HandWithHighestRankWinsTenHigh()
        {
            var hand1 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new[]
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 1);
        }

        private void RankHands(Card[] hand1, Card[] hand2, int expectedWinner)
        {
            var winner = _handRanker.RankHands(hand1, hand2);

            winner.Should().Be(expectedWinner);
        }
    }
}