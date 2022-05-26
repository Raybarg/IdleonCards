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
        string jsonString = @"[{
                                    ""Name"": ""GreenMushroom"",
                                    ""BuffGroup"": ""Generic"",
                                    ""BuffType"": ""Buff"",
                                    ""Level"": 0,
                                    ""Row"": 42,
                                    ""Col"": 69
                                }]";

        /// <summary>
        /// Test static construct (dummy test for copypasta)
        /// </summary>
        [TestMethod]
        public void TestConstructor()
        {
            CardList cl = CardList.Load();
            Assert.IsNotNull(cl);
        }

        /// <summary>
        /// Test json cardlist deserializing loader
        /// </summary>
        [TestMethod]
        public void TestLoader()
        {
            CardList cl = new();
            cl.DeserializeCardList(jsonString);
            Assert.IsNotNull(cl);
            Assert.AreEqual(1, cl.Count);
            Assert.AreEqual(42, cl.FirstOrDefault().Row);
            Assert.AreEqual(69, cl.FirstOrDefault().Col);
        }

        [TestMethod]
        public void TestGetBuffs()
        {
            CardList cl = new();
            cl.DeserializeCardList(jsonString);
            Dictionary<string, string> buffs = cl.GetBuffs();
            Assert.AreEqual(1, buffs.Count);
            Assert.AreEqual("Generic", buffs.FirstOrDefault().Key);
            Assert.AreEqual("Buff", buffs.FirstOrDefault().Value);
        }
    }
}
