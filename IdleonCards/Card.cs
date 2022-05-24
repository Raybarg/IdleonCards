using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IdleonCards.Helpers;
using System.Text.Json.Serialization;

namespace IdleonCards
{
    public class Card
    {

        public string Name { get; set; }
        public Enums.Levels Level { get; set; }

        private Image _image;

        [JsonIgnore]
        public Image Image {
            get {
                if (_image == null)
                {
                    _image = CardImgLoader.GetCardImage(Name);
                }
                return _image;
            }
        }

        public int Row { get; set; }
        public int Col { get; set; }

        [JsonIgnore]
        public Point Location { 
            get {
                return new Point(40 + Col * 32, 40 + Row * 48);
            } 
        }
    }
}
