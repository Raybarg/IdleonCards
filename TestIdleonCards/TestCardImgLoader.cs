using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdleonCards;
using System.Drawing;

namespace TestIdleonCards
{
    [TestClass]
    public class TestCardImgLoader
    {
        [TestMethod]
        public void TestGetCardImage()
        {
            Image testImage = IdleonCards.Helpers.CardImgLoader.GetCardImage("foo");
            Assert.IsNotNull(testImage); // Should populate image with "notfound" img instead of throwing exception or returning null
        }
    }
}
