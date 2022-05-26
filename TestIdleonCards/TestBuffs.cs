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
    public class TestBuffs
    {
        static string BuffClass = "TestBuffClass";
        static string BuffType = "TestBuffType";
        KeyValuePair<string, string> SingleBuff = new(BuffClass, BuffType);

        /// <summary>
        /// Dummy list test
        /// </summary>
        [TestMethod]
        public void TestBuffList()
        {
            Buffs b = new();
            b.AddBuff(BuffClass, BuffType);
            Assert.AreEqual(1, b.Count);

            // So far, name and type are equal strings... Name might be resolved for more "UI friendly" naming convention. So this is bad assertion.
            Assert.AreEqual(BuffType, b.FirstOrDefault().Name); 
        }

        /// <summary>
        /// Test buffs fill method
        /// </summary>
        [TestMethod]
        public void TestFillBuffList()
        {
            Buffs b = new();
            Dictionary<string, string> buffs = new();
            buffs.Add(SingleBuff.Key, SingleBuff.Value);
            b.Fill(buffs);
            Assert.AreEqual(1, b.Count);
            Assert.AreEqual(BuffClass, b.FirstOrDefault().Class);
            Assert.AreEqual(BuffType, b.FirstOrDefault().Type);
        }


    }
}
