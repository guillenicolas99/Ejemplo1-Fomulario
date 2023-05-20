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
    public partial class FrmListaCentro : Form
    {
        public FrmListaCentro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListaCentro_Load(object sender, EventArgs e)
        {
            lstvCentro.DataSource = GlobalList.Centros;

        }

        private void lstvCentro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
