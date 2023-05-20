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
    public partial class FrmCentro : Form
    {        
        
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCentro = txtNombre.Text;
            string direccionCentro = txtDireccion.Text;
            string telefonoCentro = txtTelefono.Text;
            string emailCentro = txtEmail.Text;

            if (nombreCentro == "" ||direccionCentro == "" || telefonoCentro == "" || emailCentro == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Aceptar", MessageBoxButtons.OK);
            }

            else
            {
                var centro = new Centro(nombreCentro, direccionCentro, telefonoCentro, emailCentro);

                GlobalList.Centros.Add(centro);
                limpiarCampos();
                MessageBox.Show("Se Guardó correctamente", "Cerrar", MessageBoxButtons.OK);
            }
            
        }
    }
}
