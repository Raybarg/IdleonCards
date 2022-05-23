using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdleonCards;

namespace TestIdleonCards
{
    [TestClass]
    public class TestCardListLoader
    {
        [TestMethod]
        public void TestGetCardList()
        {
            CardList cl = IdleonCards.Helpers.CardListLoader.getCardList();

            Assert.IsNotNull(cl);
        }
    }
}
