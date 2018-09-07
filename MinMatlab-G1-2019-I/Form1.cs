using System;
using System.Drawing;
using System.Windows.Forms;

namespace MinMatlab_G1_2019_I
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        Unidimensional u2;
        Unidimensional u3;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            try
            {
                u1 = Unidimensional.Leer(txtbMatrizEntrada.Text);
                lbMatriz1.Text = u1.ToString();
                errorProv.Clear();
            }
            catch(FormatException error)
            {
                errorProv.SetError(txtbMatrizEntrada, error.Message);
            }

            txtbMatrizEntrada.Clear();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                u2 = Unidimensional.Leer(txtbMatrizEntrada.Text);
                if (u1.N != u2.N)
                {
                    throw new ApplicationException("Deben de medir lo mesmo");
                }
                u3 = u1 + u2;
                lbMatriz2.Text = u3.ToString();
                
                errorProv.Clear();
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(lbMatriz1, error.Message);
            }
            catch(FormatException error)
            {
                errorProv.SetError(txtbMatrizEntrada, error.Message);
            }
            

            txtbMatrizEntrada.Clear();

        }
    }
}
