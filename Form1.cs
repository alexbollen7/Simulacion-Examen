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
    public partial class Form1 : Form
    {
        List<Temperatura> temperaturas = new List<Temperatura>();
        List<Departamento> departamentos = new List<Departamento>();
        List<RegistroTemp> registroTemps = new List<RegistroTemp>();
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro regTe = new Registro();
            regTe.Show();
        }

        private void buttonDesplegarTemps_Click(object sender, EventArgs e)
        {
            actuTemo();
        }

        private void cargarTemperaturas()
        {
            string fileName = @"..\..\Temperaturas.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Temperatura tempTe = new Temperatura();
                tempTe.IdenDep = int.Parse(reader.ReadLine());
                tempTe.Temp = Convert.ToDouble(reader.ReadLine());
                tempTe.Fecha = Convert.ToDateTime(reader.ReadLine());

                temperaturas.Add(tempTe);
            }
            reader.Close();
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
                deptemp.Identi = int.Parse(reader.ReadLine());

                departamentos.Add(deptemp);
            }
            reader.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //actuTemo();
        }

        private void actuTemo()
        {
            registroTemps.Clear();
            temperaturas.Clear();
            cargarTemperaturas();
            foreach (var temp in temperaturas)
            {
                Departamento depte = departamentos.Find(u => u.Identi == temp.IdenDep);
                RegistroTemp regte = new RegistroTemp();
                regte.NombreDep = depte.NombreDep;
                regte.Temp = temp.Temp;
                regte.Fecha = temp.Fecha;

                registroTemps.Add(regte);
            }
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = registroTemps;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDepartamento();
            cargarTemperaturas();
        }

        private void buttonOrdenarTemps_Click(object sender, EventArgs e)
        {
            ordenarTemps();
        }

        private void ordenarTemps()
        {
            registroTemps = registroTemps.OrderBy(p => p.Temp).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = registroTemps;
            dataGridView1.Refresh();
        }

        private void buttonPromedioTemps_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio d las temperaturas registradas es: " + promedioTemp() + " grados");
        }

        private double promedioTemp()
        {
            double suma = 0;
            int cont = 0;
            foreach(var temp in temperaturas)
            {
                suma += temp.Temp;
                cont++;
            }
            suma = suma / cont;
            return suma;

        }
    }
}
