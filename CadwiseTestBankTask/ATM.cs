using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    class ATM : ITerminal
    {
        public Dictionary<Money, int> Cash{ get; }
        public ATM()
        {
            Cash = new Dictionary<Money, int>();
            
        }
        public void AddCash(Money money)
        {

            if(!Cash.ContainsKey(money))
            {
                Cash.Add(money, 1);

            }
            else
            {

                Cash[money] += 1;
            }
            
            
        }
        public string INFO()
        {

            StringBuilder info = new StringBuilder();
            foreach(var pair in Cash)
            {
                info.Append(pair.Key.INFO().ToString() + " рублей - " + pair.Value.ToString() + " купюр ");
            }
            return info.ToString();
        }

        public void Restart()
        {
            Cash.Clear();
        }
    }
}
