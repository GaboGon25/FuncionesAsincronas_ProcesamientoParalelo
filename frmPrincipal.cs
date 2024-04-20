using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionesAsincronas_ProcesamientoParalelo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTextos_Click(object sender, EventArgs e)
        {
            frmArchivosTextos frmArchivosTextos = new frmArchivosTextos();
            frmArchivosTextos.ShowDialog();
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            frmImagenes frmImagenes = new frmImagenes();
            frmImagenes.ShowDialog();
        }
    }
}
