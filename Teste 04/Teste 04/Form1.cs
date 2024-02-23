using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_04
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
                int vTemp01 = Convert.ToInt32(N1.Text);
                int vTemp02 = Convert.ToInt32(N2.Text);
                int vTemp03 = Convert.ToInt32(N3.Text);

                if((vTemp01 > 0 && (vTemp01 % 2 == 0)) || (vTemp02 > 0 && (vTemp02 % 2 == 0)) || (vTemp03 > 0 && (vTemp03 % 2 == 0)))
                {
                    MessageBox.Show("So pode numeros inteiros e nao pode negativos ou pares ");
                    return;
                }

                //e deverá dar a indicação se algum dos números é igual ao resto da divisão inteira dos outros dois.
                //1
                string Box = "";
                if(vTemp02 % vTemp03 == vTemp01)
                {
                    Box += "O numero 1 é o resto da divisao inteira de numero 2 e 3" + Environment.NewLine;
                }
                if (vTemp03 % vTemp02 == vTemp01)
                {
                    Box += "O numero 1 é o resto da divisao inteira de numero 3 e 2" + Environment.NewLine;
                }
                //2
                if (vTemp03 % vTemp01 == vTemp02)
                {
                    Box += "O numero 2 é o resto da divisao inteira de numero 3 e 1" + Environment.NewLine;
                }
                if (vTemp01 % vTemp03 == vTemp02)
                {
                    Box += "O numero 2 é o resto da divisao inteira de numero 1 e 3" + Environment.NewLine;
                }
                //3
                if (vTemp02 % vTemp01 == vTemp03)
                {
                    Box += "O numero 3 é o resto da divisao inteira de numero 2 e 1" + Environment.NewLine;
                }
                if (vTemp01 % vTemp02 == vTemp03)
                {
                    Box += "O numero 3 é o resto da divisao inteira de numero 1 e 2" + Environment.NewLine;
                }
                if (Box != "")
                {
                    MessageBox.Show(Box);
                }
                else
                { MessageBox.Show("Nada encontrado."); }
            }
            catch
            {
                MessageBox.Show("So pode numeros inteiros e nao pode negativos ou pares ");
                return;
            }
        }
    }
}
