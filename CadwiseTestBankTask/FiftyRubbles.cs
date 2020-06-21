using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    class FiftyRubbles : Money
    {
        public FiftyRubbles()
        {
            this.Name = "Fifty rubbles";
            this.DeneminationOfBill = 50;
        }

        public override int INFO()
        {

            return this.DeneminationOfBill;
        }
    }
}
