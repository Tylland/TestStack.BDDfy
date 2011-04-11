using Bddify.Core;
using NUnit.Framework;

namespace StoryDemo
{
    [WithStory(typeof(CalculatorStory))]
    public class WhenTwoNumbersAreDevided
    {
        void ThenTheResultIsCorrect()
        {
            Assert.That(4/2, Is.EqualTo(2));
        }
    }
}