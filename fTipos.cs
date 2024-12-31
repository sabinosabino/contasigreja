using BaseDapper;
using ControleDizimoOferta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDizimoOferta
{
    public partial class fTipos : Form
    {
        private readonly DbContext tipos;
        private IEnumerable<Tipos> list;
        public fTipos()
        {
            tipos =  new DbContext(Staticos.Connection());
            InitializeComponent();
            Limpar();
        }

        private async void Tipos_Load(object sender, EventArgs e)
        {
            await CarregarLista();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            this.tiposBindingSource.DataSource = new Tipos { Origem = "CONGREGAÇÃO" };
        }

        private async Task Salvar()
        {
            try
            {
                Tipos tipo = (Tipos) this.tiposBindingSource.DataSource;
                if (tipo.Id > 0)
                {
                    await tipos.UpdateAsync<Tipos>(tipo);
                }
                else
                {
                    await tipos.InsertAsync<Tipos>(tipo);
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
                Tipos tipo = (Tipos)this.tiposBindingSource.DataSource;
                if (tipo.Id > 0)
                {
                    await tipos.Delete<Tipos>(new { tipo.Id });
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
                list = await tipos.QueryAsync<Tipos>(new { });
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
                Tipos tipo = list.FirstOrDefault(x => x.Id == Id);
                this.tiposBindingSource.DataSource = tipo;
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
    }
}
