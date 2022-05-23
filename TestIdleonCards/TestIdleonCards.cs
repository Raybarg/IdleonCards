using Microsoft.VisualStudio.TestTools.UnitTesting;
using IdleonCards;

namespace TestIdleonCards
{
    [TestClass]
    public class TestIdleonCards
    {
        private readonly string ValidName = "GreenMushroom";

        [TestMethod]
        public void TestCardCreate()
        {
            Card c = new(ValidName);
            Assert.AreEqual(ValidName, c.Name);
            Assert.AreEqual(CardLevels.NotFound, c.Level);
            Assert.IsNotNull(c.Image);
        }

        [TestMethod]
        public void TestCardListAddCard()
        {
            CardList cl = new();
            cl.AddCard(ValidName);
            Assert.AreEqual(1, cl.Count);
        }

    }
}
