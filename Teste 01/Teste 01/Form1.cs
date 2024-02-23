using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_01
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
                if(Hora01.Text == "" || Minuto01.Text == "" || Segundo01.Text=="" || Nome01.Text == "")
                {
                    MessageBox.Show("Falta preencher campos!");
                    return;
                }
                Convert.ToInt32(Hora01.Text);
                Convert.ToInt32(Minuto01.Text);
                Convert.ToInt32(Segundo01.Text);

                if (Hora02.Text == "" || Minuto02.Text == "" || Segundo02.Text == "" || Nome02.Text == "")
                {
                    MessageBox.Show("Falta preencher campos!");
                    return;
                }
                Convert.ToInt32(Hora02.Text);
                Convert.ToInt32(Minuto02.Text);
                Convert.ToInt32(Segundo02.Text);
            }
            catch 
            {
                MessageBox.Show("Verifique os campos");
                return;
            }
            CorredorData vCorredor01 = new CorredorData();
            vCorredor01.mID = 1;
            vCorredor01.mNome = Nome01.Text;
            vCorredor01.mHoras = Convert.ToInt32(Hora01.Text);
            vCorredor01.mMinutos = Convert.ToInt32(Minuto01.Text);
            vCorredor01.mSegundos = Convert.ToInt32(Segundo01.Text);
            CorredorData vCorredor02 = new CorredorData();
            vCorredor02.mID = 2;
            vCorredor02.mNome = Nome02.Text;
            vCorredor02.mHoras = Convert.ToInt32(Hora02.Text);
            vCorredor02.mMinutos = Convert.ToInt32(Minuto02.Text);
            vCorredor02.mSegundos = Convert.ToInt32(Segundo02.Text);

            TimeSpan vTempo01 = new TimeSpan(vCorredor01.mHoras, vCorredor01.mMinutos, vCorredor01.mSegundos);
            TimeSpan vTempo02 = new TimeSpan(vCorredor02.mHoras, vCorredor02.mMinutos, vCorredor02.mSegundos);

            if(vTempo01  == vTempo02)
            {
                MessageBox.Show("Os Tempos são iguais!");
            }
            else if (vTempo01 < vTempo02)
            {
                MessageBox.Show("O " + vCorredor01.mNome + " chegou primeiro com uma diferença de " + (vTempo02 - vTempo01) + ".");
            }
            else
            {
                MessageBox.Show("O " + vCorredor02.mNome + " chegou primeiro com uma diferença de " + (vTempo01 - vTempo02) + ".");
            }
        }
    }
}
