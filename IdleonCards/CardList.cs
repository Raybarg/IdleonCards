using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace IdleonCards
{
    public class CardList : List<Card>
    {
    #region "Static Construct"
        public static string CardListFileName = AppDomain.CurrentDomain.BaseDirectory + "Cards\\cards.json";
        public static CardList Load()
        {
            CardList cl = new CardList();
            cl.LoadCardList();
            return cl;
        }
    #endregion

        private void LoadCardList()
        {
            this.DeserializeCardList(File.ReadAllText(CardListFileName));
        }

        public void DeserializeCardList(string jsonCards)
        {
            IList<Card> Cards = JsonSerializer.Deserialize<IList<Card>>(jsonCards);
            foreach (Card item in Cards)
            {
                Card c = new Card(item.Name)
                {
                    Level = item.Level,
                    Row = item.Row,
                    Col = item.Col
                };
                this.Add(c);
            }
        }

        public void AddCard(string name)
        {
            this.Add(new Card(name));
        }

    }
}
