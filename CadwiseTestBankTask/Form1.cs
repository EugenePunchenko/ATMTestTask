using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadwiseTestBankTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        ATM atm = new ATM();
        private void buttonAddCash_Click(object sender, EventArgs e)
        {
            MoneyCreator creator;
            if(radioButtonTenRubbles.Checked)
            {
                creator = new TenRubblesCreator();
                atm.AddCash(creator.returnMoney());
                //Вот тут добавляю деньги как объект мани в словарь 
                // но если я сделаю такую вещь
                //atm.Cash.Contains(creator.returnMoney()); не будет соответствия 
                
            }
            if(radioButtonFiftyRubbles.Checked)
            {
                creator = new FiftyRubblesCreator();
                atm.AddCash(creator.returnMoney());
            }
            if(radioButtonOneHundredRubbles.Checked)
            {
                creator = new OneHudredRubblesCreator();
                atm.AddCash(creator.returnMoney());
            }
        }

        private void buttonINFO_Click(object sender, EventArgs e)
        {
            listBoxINFO.Items.Clear();
            listBoxINFO.Items.Add(atm.INFO());
            
            
        }

        private void button1_Click(object sender, EventArgs e) // ну это чисто кнопка для теста
        {
            listBoxINFO.Items.Clear();
            string s = "abc";
            /*foreach(var i in atm.Cash)
            {
                s = "";
                s += i.Key.Name + " - " + i.Value.ToString() + " купюр";
                listBoxINFO.Items.Add(s);
            }*/
            int j;
            MoneyCreator creator = new TenRubblesCreator(); 
            //s = atm.Cash[money].ToString();
            listBoxINFO.Items.Add(atm.Cash.Count.ToString());

            for(int i = 0; i < atm.Cash.Count;i++)
            {
                s += atm.Cash.TryGetValue(creator.returnMoney(),out j).ToString();
            }
            listBoxINFO.Items.Add(s);


        }
    }
}
