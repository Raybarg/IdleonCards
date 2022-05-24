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
        /// <summary>
        /// Test statit construct (dummy test for copypasta)
        /// </summary>
        [TestMethod]
        public void TestConstructor()
        {
            CardList cl = CardList.Load();
            Assert.IsNotNull(cl);
        }

        /// <summary>
        /// Test statit construct (dummy test for copypasta)
        /// </summary>
        [TestMethod]
        public void TestLoader()
        {
            string jsonString = @"[{
                                    ""Name"": ""GreenMushroom"",
                                    ""Level"": 0,
                                    ""Row"": 42,
                                    ""Col"": 69
                                }]";
            CardList cl = new();
            cl.DeserializeCardList(jsonString);
            Assert.IsNotNull(cl);
            Assert.AreEqual(1, cl.Count);
            Assert.AreEqual(42, cl.FirstOrDefault().Row);
            Assert.AreEqual(69, cl.FirstOrDefault().Col);
        }
    }
}
