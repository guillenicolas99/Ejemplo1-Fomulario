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
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string nombre, string direccion, string telefono, string email)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
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
            FrmListaCentro listarCentro= new FrmListaCentro();
            listarCentro.ShowDialog();
        }
    }
}
