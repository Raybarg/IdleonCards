using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
    
namespace IdleonCards.Helpers
{
    class CardListing
    {
        public IList<CardItem> Cards { get; set; }
    }
    class CardItem
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }

    public static class CardListLoader
    {
        private static readonly string ListFile = AppDomain.CurrentDomain.BaseDirectory + "Cards\\cards.json";

        public static CardList getCardList()
        {
            CardList cl = new CardList();

            string jsonString = File.ReadAllText(ListFile);

            CardListing cll = JsonSerializer.Deserialize<CardListing>(jsonString);

            foreach(CardItem item in cll.Cards)
            {
                Card c = new Card(item.Name)
                {
                    Level = (CardLevels)item.Level,
                    Row = item.Row,
                    Col = item.Col
                };
                cl.Add(c);
            }
            return cl;
        }
    }
}
