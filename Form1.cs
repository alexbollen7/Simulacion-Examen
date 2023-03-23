using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro regTe = new Registro();
            regTe.Show();
        }
    }
}
