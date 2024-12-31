using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDizimoOferta
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fTipos().ShowDialog();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fPessoas().ShowDialog();

        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fContas().ShowDialog();
        }
    }
}
