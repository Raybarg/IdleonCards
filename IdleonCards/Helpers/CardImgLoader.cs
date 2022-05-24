using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IdleonCards.Helpers
{
    public static class CardImgLoader
    {
        static readonly string cardDir = "Cards\\";
        static readonly string notFoundImgName = cardDir + "NotFound.png";

        /// <summary>
        /// Attempt to get image for card name, if not found then set the image to NotFound.png
        /// </summary>
        /// <param name="cardName">Card name</param>
        /// <returns></returns>
        public static Image GetCardImage(string cardName)
        {
            Image img;
            string imgFile = AppDomain.CurrentDomain.BaseDirectory + cardDir + cardName + ".png";

            try
            {
                img = Image.FromFile(imgFile);
            }
            catch (System.IO.FileNotFoundException)
            {
                imgFile = AppDomain.CurrentDomain.BaseDirectory + notFoundImgName;
                img = Image.FromFile(imgFile);
            }

            return img;
        }
    }
}
