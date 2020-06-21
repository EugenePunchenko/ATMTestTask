using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    class TenRubbles : Money
    {
        public TenRubbles()
        {
            this.Name = "Ten rubbles";
            this.DeneminationOfBill = 10;
        }

        public override int INFO()
        {

            return this.DeneminationOfBill;
        }
    }
}
