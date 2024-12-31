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
            this.menuStrip1.Visible = Staticos.logado;

            this.txtLogin.Visible = !Staticos.logado;
            this.txtSenha.Visible = !Staticos.logado;
            this.cmdlogar.Visible = !Staticos.logado;
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

        private void cmdlogar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.ToUpper()=="IGREJA" && txtSenha.Text == "igreja123456")
            {
                Staticos.logado = true;
                this.menuStrip1.Visible = Staticos.logado;

                this.txtLogin.Visible = !Staticos.logado;
                this.txtSenha.Visible = !Staticos.logado;
                this.cmdlogar.Visible = !Staticos.logado;
                return;
            }
            MessageBox.Show("Login ou senha inválidos");

        }
    }
}
