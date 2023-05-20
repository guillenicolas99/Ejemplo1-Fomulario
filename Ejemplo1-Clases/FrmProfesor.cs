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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        public void limpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtINSS.Text = "";
            txtSalario.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string inss = txtINSS.Text;
            double salario = double.Parse(txtSalario.Text);

            if (nombre == "" || direccion == "" || telefono == "" || email == "" || inss == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Aceptar", MessageBoxButtons.OK);
            }
            else
            {
                var profesor = new Profesor(id, nombre, direccion, telefono, email, inss, salario);

                GlobalList.Profesores.Add(profesor);
                limpiarCampos();
                MessageBox.Show("Se Guardó correctamente", "Cerrar", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
