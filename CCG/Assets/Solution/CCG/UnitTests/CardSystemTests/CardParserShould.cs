using System;
using CardSystem.CardLibrary;
using NUnit.Framework;

namespace UnitTests.CardSystemTests
{
    [TestFixture]
    public class CardParserShould
    {
        [Test]
        public void ParseValidJsonFile()
        {
            var answer = CardParser.BuildCardLibrary();
            //var answer = CardParser.ParseFile(AppDomain.CurrentDomain.BaseDirectory + "\\sourceCardFiles\\cardSource.txt");
        }
    }
}
