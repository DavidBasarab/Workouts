﻿using System.Collections.Generic;
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
        public void Hand1WinsWithHighCardAceAndKingJackKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WinsWithHighCardAceAndKingTenEightKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Eight),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Spade, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WinsWithHighCardAceAndKingTenSevenFiveKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WinsWithHighCardAceAndTenKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
        public void Hand1WinsWithPairOfThreesAndJackKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Jack),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Spade, CardValue.Three),
                                new Card(Suit.Heart, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ten)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfFives()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Five),
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
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
        public void Hand1WithHighestPairWinsPairOfFoursAceJackKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Ace),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfFoursAceJackSixKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Six),
                                new Card(Suit.Diamond, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Heart, CardValue.Ace),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfFoursAceKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand1WithHighestPairWinsPairOfKings()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.King),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
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
        public void Hand1WithHighestPairWinsPairOfTwos()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
        public void Hand1WithTwoPairTwosAndThrees()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Three)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WinsWithHighCardAceAndKingKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WinsWithHighCardAceAndKingTenKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WinsWithHighCardAceAndKingTenSevenFourKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WinsWithHighCardAceAndKingTenSevenKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.King),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WinsWithTwoPairTwosAndFours()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Seven)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Four),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfFours()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
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
        public void Hand2WithHighestPairWinsPairOfFoursAceJackSevenKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Six),
                                new Card(Suit.Diamond, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Seven),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Heart, CardValue.Ace),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfFoursAceKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Ace),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfFoursAceQueenKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Jack),
                                new Card(Suit.Club, CardValue.Ace),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Ace),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Diamond, CardValue.Four)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfThrees()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
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
        public void Hand2WithHighestPairWinsPairOfThreesAnd10Kicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Three),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Four)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Spade, CardValue.Three),
                                new Card(Suit.Heart, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ten)
                        };

            RankHands(hand1, hand2, 2);
        }

        [Test]
        public void Hand2WithHighestPairWinsPairOfTwos()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Seven)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Queen),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
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
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Nine)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Club, CardValue.Three),
                                new Card(Suit.Club, CardValue.Six),
                                new Card(Suit.Heart, CardValue.Eight)
                        };

            RankHands(hand1, hand2, 1);
        }

        private void RankHands(IList<Card> hand1, IList<Card> hand2, int expectedWinner)
        {
            var winner = _handRanker.RankHands(hand1, hand2);

            winner.Should().Be(expectedWinner);
        }

        [Test]
        public void Hand2WinsWithTwoPairTwosAndTensAndAceKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Four),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }


        [Test]
        public void Hand1WinsWithTwoPairJacksAndFoursAndKingKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Jack),
                                new Card(Suit.Diamond, CardValue.Jack),
                                new Card(Suit.Heart, CardValue.Four),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Four),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Queen)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WinsWithTwoPairFivesAndTensAndAceKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Diamond, CardValue.Five),
                                new Card(Suit.Spade, CardValue.Ten),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.King)
                        };

            RankHands(hand1, hand2, 2);
        }


        [Test]
        public void Hand1WinsWithTwoPairSevensAndTensAndKingKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Seven),
                                new Card(Suit.Heart, CardValue.Seven),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Diamond, CardValue.Five),
                                new Card(Suit.Spade, CardValue.Ten),
                                new Card(Suit.Diamond, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.King)
                        };

            RankHands(hand1, hand2, 1);
        }

        [Test]
        public void Hand2WinsWithTwoPairTwosAndFoursAndAceKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Four),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Four),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Ace)
                        };

            RankHands(hand1, hand2, 2);
        }


        [Test]
        public void Hand1WinsWithTwoPairTwosAndFoursAndKingKicker()
        {
            var hand1 = new List<Card>
                        {
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Four),
                                new Card(Suit.Spade, CardValue.Four),
                                new Card(Suit.Heart, CardValue.King)
                        };

            var hand2 = new List<Card>
                        {
                                new Card(Suit.Spade, CardValue.Two),
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Diamond, CardValue.Four),
                                new Card(Suit.Club, CardValue.Four),
                                new Card(Suit.Heart, CardValue.Queen)
                        };

            RankHands(hand1, hand2, 1);
        }
    }
}