using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    class OneHundredRubbles : Money
    {
        public OneHundredRubbles()
        {
            this.Name = "One hundred rubbles";
            this.DeneminationOfBill = 100;
        }

        public override int INFO()
        {

            return this.DeneminationOfBill;
        }
    }
}
