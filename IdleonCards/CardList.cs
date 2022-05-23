using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleonCards
{
    public class CardList : List<Card>
    {
        public void AddCard(string name)
        {
            this.Add(new Card(name));
        }
    }
}
