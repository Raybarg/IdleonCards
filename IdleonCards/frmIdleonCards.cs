using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleonCards;

namespace IdleonCards
{
    public partial class Form1 : Form
    {
        Color DefaultColor;
        Button[] cardButtons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CardList cl = CardList.Load();

            if (cl != null && cl.Count > 0)
            {
                cardButtons = new Button[cl.Count];
                for (int i = 0; i < cl.Count; i++)
                {
                    cardButtons[i] = new Button();
                    cardButtons[i].Name = cl[i].Name;

                    cardButtons[i].Visible = true;
                    cardButtons[i].Location = new Point(40 + cl[i].Col * 32, 40 + cl[i].Row * 48);
                    cardButtons[i].Size = new Size(new Point(27, 35));
                    cardButtons[i].Image = cl[i].Image;
                    cardButtons[i].FlatStyle = FlatStyle.Flat;
                    cardButtons[i].FlatAppearance.BorderSize = 1;

                    cardButtons[i].Click += CardButtonClick;

                    this.Controls.Add(cardButtons[i]);
                }
            }
            
        }

        private void CardButtonClick(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            if (b.FlatAppearance.BorderColor != System.Drawing.Color.OrangeRed)
            {
                DefaultColor = b.FlatAppearance.BorderColor;
                b.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
                b.FlatAppearance.BorderSize = 3;
            } else
            {
                b.FlatAppearance.BorderColor = DefaultColor;
                b.FlatAppearance.BorderSize = 1;
            }
            
            this.ActiveControl = null;
        }
    }
}
