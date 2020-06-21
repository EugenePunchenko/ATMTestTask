using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadwiseTestBankTask
{
    abstract class MoneyCreator
    {
        public abstract Money returnMoney();
    }

    class TenRubblesCreator : MoneyCreator
    {
        public override Money returnMoney()
        {
            return new TenRubbles();
        }
    }
    class FiftyRubblesCreator : MoneyCreator
    {
        public override Money returnMoney()
        {
            return new FiftyRubbles();
        }
    }
    class OneHudredRubblesCreator : MoneyCreator
    {
        public override Money returnMoney()
        {
            return new OneHundredRubbles();
        }
    }
}
