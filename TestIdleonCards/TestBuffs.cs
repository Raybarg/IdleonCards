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
        static readonly string BuffClass = "TestBuffClass";
        static readonly string BuffType = "TestBuffType";
        static readonly KeyValuePair<string, string> SingleBuff = new(BuffClass, BuffType);

        /// <summary>
        /// Test buffs fill method
        /// </summary>
        [TestMethod]
        public void TestFillBuffList()
        {
            Dictionary<string, string> buffs = new();
            buffs.Add(SingleBuff.Key, SingleBuff.Value);
            Buffs b = new(buffs);
            Assert.AreEqual(1, b.Count);
            Assert.AreEqual(BuffClass, b.FirstOrDefault().Class);
            Assert.AreEqual(BuffType, b.FirstOrDefault().Type);
        }


    }
}
