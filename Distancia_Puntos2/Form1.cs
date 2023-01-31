using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_Puntos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Calculos cordenadas = new Calculos();
            cordenadas.Xa = Double.Parse(Txt_XA.Text);
            cordenadas.Ya = Double.Parse(Txt_YA.Text);
            cordenadas.Xb = Double.Parse(Txt_XB.Text);
            cordenadas.Yb = Double.Parse(Txt_YB.Text);

            Txt_Resultado.Text = cordenadas.Distancia().ToString();
        }
    }
}
