using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadwiseTestBankTask
{
    abstract class Money
    {
        public string Name { get; set; }
        public int DeneminationOfBill { get; set; }
        public Money()
        {

        }
        public virtual int INFO()
        {
            return 0;
        }
    }
}
