using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linea
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtLadoX.Text);
                double y = double.Parse(txtLadoY.Text);
                double x2 = double.Parse(txtX2.Text);
                double y2 = double.Parse(txtY2.Text);


                clsLinea linea = new clsLinea(x, y, x2, y2);
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));

                grafico.DrawLine(pen, linea.obtenx(), linea.obteny(), linea.obtenx2(), linea.obteny2());
                txtCantidad.Text = Convert.ToString(clsLinea.obtenContar());
            }
            catch
            {

                MessageBox.Show("Digite el valor de tipo numerico");
            }
        }
    }
}
