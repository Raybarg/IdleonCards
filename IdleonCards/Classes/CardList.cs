﻿using System;
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
            DeserializeCardList(File.ReadAllText(CardListFileName));
        }

        public void DeserializeCardList(string jsonCards)
        {
            AddRange(JsonSerializer.Deserialize<List<Card>>(jsonCards));
        }

        public void Save()
        {
            File.WriteAllText(CardListFileName, JsonSerializer.Serialize(this));
        }

        /// <summary>
        /// Return dictionary of buffs from all cards
        /// </summary>
        /// <returns></returns>
        public List<Tuple<string, string>> GetBuffs()
        {
            return this.Distinct().Select(c => new Tuple<string, string>(c.BuffGroup, c.BuffType)).ToList();
        }
    }
}
