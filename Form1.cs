using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Geometria_por_KAML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prismaCuadrangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.cuadrangular cuadrangular = new Formularios.cuadrangular();
            cuadrangular.MdiParent = this;
            cuadrangular.Show();
        }

        private void prismaHexagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.hexagonal hexagonal = new Formularios.hexagonal();
            hexagonal.MdiParent = this;
            hexagonal.Show();

        }

        private void cilindricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.cilindrico cilindrico = new Formularios.cilindrico();
            cilindrico.MdiParent = this;
            cilindrico.Show();

        }

        private void conicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.conico conico = new Formularios.conico();
            conico.MdiParent = this;
            conico.Show();

        }
    }
}
