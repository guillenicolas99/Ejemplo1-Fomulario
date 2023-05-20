using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listaDeCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro centro= new FrmCentro();
            centro.ShowDialog();

        }

        private void listaDeCentros_Click(object sender, EventArgs e)
        {
            if(GlobalList.Centros.Count > 0)
            {
                FrmListaCentro listarCentro= new FrmListaCentro();
                listarCentro.ShowDialog();
            }
            MessageBox.Show("Campo vacío, favor ingrese los datos", "confirmar", MessageBoxButtons.OK);

        }

        private void agregarProfesor_Click(object sender, EventArgs e)
        {
            FrmProfesor profesor= new FrmProfesor();
            profesor.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalList.Profesores.Count > 0)
            {
                FrmListaProfesores listaProfesores = new FrmListaProfesores();
                listaProfesores.ShowDialog();
            }
            else
                MessageBox.Show("Campo vacío, favor ingrese los datos", "confirmar", MessageBoxButtons.OK);
        }
    }
}
