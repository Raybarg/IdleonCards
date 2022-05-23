using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IdleonCards.Helpers;

namespace IdleonCards
{
    public class Card
    {

        public string Name { get; set; }
        public Enums.Levels Level { get; set; }
        public Image Image {get; }

        public int Row { get; set; }
        public int Col { get; set; }


        public Card()
        {

        }

        public Card(string CardName)
        {
            Name = CardName;
            Level = Enums.Levels.NotFound;
            Image = CardImgLoader.getCardImage(CardName);
        }
    }
}
