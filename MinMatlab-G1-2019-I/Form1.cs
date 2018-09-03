using System;
using System.Drawing;
using System.Windows.Forms;

namespace MinMatlab_G1_2019_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
          lbMatriz1.Text=  Unidimensional.Leer(txtbMatrizEntrada.Text).ToString() ;
        }
    }
}
