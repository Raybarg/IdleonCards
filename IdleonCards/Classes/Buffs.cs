using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleonCards
{
    public class Buff
    {
        public string Name;
        public string Class;
        public string Type;

        public Buff(string BuffClass, string BuffType)
        {
            Name = BuffType;
            Class = BuffClass;
            Type = BuffType;
        }
    }

    public class Buffs: List<Buff>
    {
        public Buffs(List<Tuple<string, string>> BuffsDict)
        {
            Fill(BuffsDict);
        }

        public void AddBuff(string BuffClass, string BuffType)
        {
            this.Add(new Buff(BuffClass, BuffType));
        }

        public void Fill(List<Tuple<string, string>> BuffsDict)
        {
            foreach (Tuple<string, string> buff in BuffsDict)
            {
                this.AddBuff(buff.Item1, buff.Item2);
            }
        }
    }

}
