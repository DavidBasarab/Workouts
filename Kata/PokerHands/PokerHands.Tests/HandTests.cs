using FluentAssertions;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    [Category("PokerHands.Tests")]
    public class HandTests
    {
        [Test]
        public void HandWithHighestRankWins()
        {
            var handRanker = new HandRanker();

            var hand1 = new Card[]
                        {
                                new Card(Suit.Club, CardValue.Two), 
                                new Card(Suit.Club, CardValue.Three), 
                                new Card(Suit.Club, CardValue.Four), 
                                new Card(Suit.Club, CardValue.Six), 
                                new Card(Suit.Heart, CardValue.Seven), 
                        };

            var hand2 = new Card[]
                        {
                                new Card(Suit.Club, CardValue.Two), 
                                new Card(Suit.Club, CardValue.Four), 
                                new Card(Suit.Club, CardValue.Five), 
                                new Card(Suit.Club, CardValue.Six), 
                                new Card(Suit.Heart, CardValue.Eight), 
                        };

            var winner = handRanker.RankHands(hand1, hand2);

            winner.Should().Be(2);
        }
    }
}