using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación_Examen
{
    public partial class Registro : Form
    {
        List<Departamento> departamentos = new List<Departamento>();
        List<Temperatura> temperaturas = new List<Temperatura>();
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cargarDepartamento();
        }

        private void cargarDepartamento()
        {
            string fileName = @"..\..\Departamentos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Departamento deptemp = new Departamento();
                deptemp.NombreDep = reader.ReadLine();
                comboBox1.Items.Add(deptemp.NombreDep);
                deptemp.Identi = int.Parse(reader.ReadLine());

                departamentos.Add(deptemp);
            }
            reader.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            if ((comboBox1.Text != "") && (textBoxTempe.Text != ""))
            {
                Departamento depte = departamentos.Find(u => u.NombreDep == comboBox1.SelectedItem.ToString());
                Temperatura tempte = new Temperatura();
                tempte.IdenDep = depte.Identi;
                tempte.Temp = Convert.ToDouble(textBoxTempe.Text);
                tempte.Fecha = dateTimePicker1.Value;

                temperaturas.Add(tempte);
            }
            MessageBox.Show("La temperatura se registro correctamente");
        }

        private void escribirTemperaturas()
        {
            string fileName = @"..\..\Temperaturas.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var temp in temperaturas)
            {
                writer.WriteLine(temp.IdenDep.ToString());
                writer.WriteLine(temp.Temp.ToString());
                writer.WriteLine(temp.Fecha);
            }
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            escribirTemperaturas();
            this.Dispose();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            escribirTemperaturas();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxTempe.Text = "";
            comboBox1.Text = "";
        }
    }
}
