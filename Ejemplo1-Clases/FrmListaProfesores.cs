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
    public partial class FrmListaProfesores : Form
    {
        public FrmListaProfesores()
        {
            InitializeComponent();
        }

        private void lstvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListaProfesores_Load(object sender, EventArgs e)
        {
            lstvProfesores.DataSource = GlobalList.Profesores;
        }
    }
}
