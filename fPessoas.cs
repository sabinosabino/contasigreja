using BaseDapper;
using ControleDizimoOferta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDizimoOferta
{
    public partial class fPessoas : Form
    {
        private readonly DbContext Pessoas;
        private IEnumerable<Pessoas> list;
        public fPessoas()
        {
            Pessoas =  new DbContext(Staticos.Connection());
            InitializeComponent();
            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            this.pessoasBindingSource.DataSource = new Pessoas { Tipo = "CONGREGAÇÃO" };
        }

        private async Task Salvar()
        {
            try
            {
                Pessoas pessoa = (Pessoas)  this.pessoasBindingSource.DataSource;
                if (pessoa.Id > 0)
                {
                    await Pessoas.UpdateAsync<Pessoas>(pessoa);
                }
                else
                {
                    await Pessoas.InsertAsync<Pessoas>(pessoa);
                }

                Limpar();
                await CarregarLista();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task Excluir()
        {
            try
            {
                Pessoas pessoa = (Pessoas)this.pessoasBindingSource.DataSource;
                if (pessoa.Id > 0)
                {
                    await Pessoas.Delete<Pessoas>(new { pessoa.Id });
                    await CarregarLista();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente salvar?","Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                await Salvar();

                MessageBox.Show("Salvo com successo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CarregarLista()
        {

            try
            {
                list = await Pessoas.QueryAsync<Pessoas>(new { });
                this.dtg.DataSource = list;
                this.dtg.ConfigDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                int Id = Convert.ToInt32(this.dtg.Rows[e.RowIndex].Cells[0].Value.ToString());
                Pessoas pessoa = list.FirstOrDefault(x => x.Id == Id);
                this.pessoasBindingSource.DataSource = pessoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                await Excluir();

                MessageBox.Show("Excluido com successo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void fPessoas_Load(object sender, EventArgs e)
        {
            await CarregarLista();
        }
    }
}
