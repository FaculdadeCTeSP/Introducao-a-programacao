using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data vD01 = new Data();
            vD01.mData = new DateTime(Convert.ToInt32(Ano01.Text), Convert.ToInt32(Mes01.Text), Convert.ToInt32(Dia01.Text));
            vD01.mNome = Nome01.Text;
            Data vD02 = new Data();
            vD02.mData = new DateTime(Convert.ToInt32(Ano02.Text), Convert.ToInt32(Mes02.Text), Convert.ToInt32(Dia02.Text));
            vD02.mNome = Nome02.Text;
            Data vD03 = new Data();
            vD03.mData = new DateTime(Convert.ToInt32(Ano03.Text), Convert.ToInt32(Mes03.Text), Convert.ToInt32(Dia03.Text));
            vD03.mNome = Nome03.Text;

            DateTime[] vTemp = { vD01.mData, vD02.mData, vD03.mData };
            if(vD01.mData == vTemp.Max())
            {
                MessageBox.Show("O mais novo é " + vD01.mNome);
            } else if (vD02.mData == vTemp.Max())
            {
                MessageBox.Show("O mais novo é " + vD02.mNome);
            }
            else if (vD03.mData == vTemp.Max())
            {
                MessageBox.Show("O mais novo é " + vD03.mNome);
            }

            if (vD01.mData == vTemp.Min())
            {
                MessageBox.Show("O mais Velho é " + vD01.mNome);
            }
            else if (vD02.mData == vTemp.Min())
            {
                MessageBox.Show("O mais Velho é " + vD02.mNome);
            }
            else if (vD03.mData == vTemp.Min())
            {
                MessageBox.Show("O mais Velho é " + vD03.mNome);
            }


        }
    }
}
