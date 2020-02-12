using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            //split divide una cadema en base a un delimitador (patron) y me devuelve una matriz
            lblrespuesta.Text = "X = " +  objEstadistica.media(txtserie.Text.Split(','));

        }

        private void btnestandar_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Estandar = " + objEstadistica.estandar(txtserie.Text.Split(','));
        }

        private void btntipica_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Tipica = " + objEstadistica.tipica(txtserie.Text.Split(','));
        }
    }
}
