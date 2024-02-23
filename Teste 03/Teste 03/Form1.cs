using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int vTemp = Convert.ToInt32(N1.Text);
                int[] vM5 = { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
                bool mult = false;
                foreach (int item in vM5)
                {
                    if(item == vTemp)
                    {
                        mult = true;
                    }
                }
                if (vTemp >= 0 && (vTemp % 2 == 0 ) && vTemp <= 100 && mult == true) 
                {
                    MessageBox.Show("Obdece");
                }
                else
                {
                    MessageBox.Show("Não Obdece");
                }
            }
            catch 
            {
                MessageBox.Show("Algo esta mal");
            }
            
        }
    }
}
