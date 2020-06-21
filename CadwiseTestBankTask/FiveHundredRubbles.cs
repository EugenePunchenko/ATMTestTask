using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    class FiveHundredRubbles : Money
    {
        public FiveHundredRubbles()
        {
            this.Name = "Five hundred rubbles";
            this.DeneminationOfBill = 500;
        }

        public override int INFO()
        {

            return this.DeneminationOfBill;
        }
    }
}
