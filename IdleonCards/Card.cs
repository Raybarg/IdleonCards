using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IdleonCards.Helpers;

namespace IdleonCards
{
    public enum CardLevels
    {
        NotFound = 0,
        Found = 1,
        Star1 = 2,
        Star2 = 3,
        Star3 = 4
    }

    public class Card
    {
        private readonly string _name;
        /// <summary>
        /// Card Name
        /// </summary>
        public string Name
        {
            get => _name;
        }

        private CardLevels _level;
        /// <summary>
        /// Card Level (stars)
        /// </summary>
        public CardLevels Level
        {
            get => _level;
            set => _level = value;
        }

        private readonly Image _image;
        /// <summary>
        /// Image of a card
        /// </summary>
        public Image Image
        {
            get => _image;
        }

        public int Row { get; set; }
        public int Col { get; set; }


        public Card(string CardName)
        {
            _name = CardName;
            _level = CardLevels.NotFound;
            _image = CardImgLoader.getCardImage(CardName);
        }
    }
}
