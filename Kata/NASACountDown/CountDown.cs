using System.Collections.Generic;

namespace NASACountdown
{
    public class CountDown
    {
        public IList<int> Start(int startingNumber)
        {
            return new List<int>(ProcessCountdown(startingNumber));
        }

        private IEnumerable<int> ProcessCountdown(int startingNumber)
        {
            for (var currentIndex = startingNumber; currentIndex >= 0; currentIndex--)
                yield return currentIndex;
        }
    }
}