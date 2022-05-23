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
        public IList<Card> Cards { get; set; }
    }

    public static class CardListLoader
    {
        private static readonly string ListFile = AppDomain.CurrentDomain.BaseDirectory + "Cards\\cards.json";

        public static CardList getCardList()
        {
            CardList cl = new CardList();

            string jsonString = File.ReadAllText(ListFile);

            CardListing cll = JsonSerializer.Deserialize<CardListing>(jsonString);

            foreach(Card item in cll.Cards)
            {
                Card c = new Card(item.Name)
                {
                    Level = item.Level,
                    Row = item.Row,
                    Col = item.Col
                };
                cl.Add(c);
            }
            return cl;
        }
    }
}
