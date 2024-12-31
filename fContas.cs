using BaseDapper;
using ControleDizimoOferta.Models;
using ControleDizimoOferta.Models.DTO;
using CsvHelper.Configuration;
using CsvHelper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDizimoOferta
{
    public partial class fContas : Form
    {
        private readonly DbContext db;
        private IEnumerable<ContasNomes> list;
        private IEnumerable<ContasNomes> listFiltro;
        private IEnumerable<Pessoas> pessoas;
        private IEnumerable<Tipos> tipos;
        public fContas()
        {
            db = new DbContext(Staticos.Connection());
            InitializeComponent();
            Limpar();

        }
        private async Task CarregarRecursos()
        {
            pessoas = await db.QueryAsync<Pessoas>(new { });
            tipos = await db.QueryAsync<Tipos>(new { });
        }

        private void CarregarCbos()
        {
            this.tipoIdComboBox.DataSource = tipos;
            this.tipoIdComboBox.DisplayMember = "Nome";
            this.tipoIdComboBox.ValueMember = "Id";

            var selecionado = (Tipos)this.tipoIdComboBox.SelectedItem;
            this.pessoaIdComboBox.DataSource = pessoas.Where(x => x.Tipo == selecionado.Origem).ToList();
            this.pessoaIdComboBox.DisplayMember = "Nome";
            this.pessoaIdComboBox.ValueMember = "Id";

            int AnoAtual = 2024;
            int[] anos = new int[100];
            for (int i = 0; i < 100; i++)
                anos[i] = AnoAtual++;

            this.cboAno.DataSource = anos;

            this.cboAno.Text = DateTime.Now.Year.ToString();

            var lista = new List<object>
                {
                    new { Id = 1, Nome = "Janeiro" },
                    new { Id = 2, Nome = "Fevereiro" },
                    new { Id = 3, Nome = "Março" },
                    new { Id = 4, Nome = "Abril" },
                    new { Id = 5, Nome = "Maio" },
                    new { Id = 6, Nome = "Junho" },
                    new { Id = 7, Nome = "Julho" },
                    new { Id = 8, Nome = "Agosto" },
                    new { Id = 9, Nome = "Setembro" },
                    new { Id = 10, Nome = "Outubro" },
                    new { Id = 11, Nome = "Novembro" },
                    new { Id = 12, Nome = "Dezembro" }
                };

            this.cboMes.DataSource = lista;
            this.cboMes.ValueMember = "Id";
            this.cboMes.DisplayMember = "Nome";

            this.cboMes.SelectedValue = DateTime.Now.Month;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            this.contasBindingSource.DataSource = new Contas();
        }

        private async Task Salvar()
        {
            try
            {
                Contas conta = (Contas)this.contasBindingSource.DataSource;
                conta.TipoId = Convert.ToInt32(this.tipoIdComboBox.SelectedValue.ToString());
                conta.PessoaId = Convert.ToInt32(this.pessoaIdComboBox.SelectedValue.ToString());
                conta.Competencia = conta.Data.ToString("MM/yyyy");
                conta.Data = conta.Data.Date;
                var selecionado = (Tipos)this.tipoIdComboBox.SelectedItem;
                if (selecionado.Origem == "FORNECEDOR")
                    conta.ValorConta -= (conta.ValorConta * 2);

                if (conta.Id > 0)
                {
                    await db.UpdateAsync<Contas>(conta);
                }
                else
                {
                    await db.InsertAsync<Contas>(conta);
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
                Contas pessoa = (Contas)this.contasBindingSource.DataSource;
                if (pessoa.Id > 0)
                {
                    await db.Delete<Contas>(new { pessoa.Id });
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
            if (MessageBox.Show("Deseja realmente salvar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                string sql = @"Select c.*,t.Nome TipoNome, p.Nome PessoaNome from Contas c 
                            left join Pessoas p on p.Id=c.PessoaId 
                            left join Tipos t on t.Id = c.TipoId where Competencia=@Competencia";

                var competencia = string.Format("{0:00}/{1}", Convert.ToInt32(cboMes.SelectedValue), cboAno.Text);

                var list = await db.GetConnection()
                    .QueryAsync<ContasNomes>(
                        sql,
                        new { Competencia = competencia }
                    );

                listFiltro = list.OrderBy(x => x.Data).ToList();
                this.dtg.DataSource = listFiltro;
                lbTotal.Text = listFiltro.Sum(x => x.ValorConta).ToString("C2");

                this.dtg.ConfigDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                int Id = Convert.ToInt32(this.dtg.Rows[e.RowIndex].Cells[0].Value.ToString());
                Contas conta = await db.QueryFirstOrDefaultAsync<Contas>(new { Id });
                this.contasBindingSource.DataSource = conta;
                this.pessoaIdComboBox.SelectedValue = conta.PessoaId;
                this.tipoIdComboBox.SelectedValue = conta.TipoId;
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

        private async void fContas_Load_1(object sender, EventArgs e)
        {
            await CarregarRecursos();
            CarregarCbos();
            await CarregarLista();
        }

        private void fContas_Click(object sender, EventArgs e)
        {

        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tipoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = (Tipos)this.tipoIdComboBox.SelectedItem;
            this.pessoaIdComboBox.DataSource = pessoas.Where(x => x.Tipo == selecionado.Origem).ToList();
            this.pessoaIdComboBox.DisplayMember = "Nome";
            this.pessoaIdComboBox.ValueMember = "Id";
        }

        private async void btnRecarregar_Click(object sender, EventArgs e)
        {
            await CarregarLista();
        }

        private void cboExportar_Click(object sender, EventArgs e)
        {
            string pasta = SelecionarPasta();
            if (string.IsNullOrWhiteSpace(pasta))
            {
                MessageBox.Show("Nenhuma pasta foi selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Caminho completo do arquivo
            string caminhoArquivo = Path.Combine(pasta,  $"{cboMes.Text}-{cboAno.Text}.csv");

            // Exporta os dados para o arquivo CSV
            ExportarCsv(listFiltro, caminhoArquivo);

            MessageBox.Show($"Arquivo CSV salvo em: {caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExportarCsv<T>(IEnumerable<T> dados, string caminhoArquivo)
        {
            var config = new CsvConfiguration(new CultureInfo("pt-BR"))
            {
                Delimiter = ";", // Delimitador padrão para CSV em PT-BR
                Encoding = System.Text.Encoding.UTF8, // Exportação em UTF-8
                HasHeaderRecord = true // Inclui o cabeçalho no arquivo
            };

            using (var writer = new StreamWriter(caminhoArquivo, false, config.Encoding))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(dados); // Escreve os dados no CSV
            }
        }

        public static string SelecionarPasta()
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.Description = "Selecione a pasta para salvar o arquivo CSV";
                var result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }

            return null;
        }
    }
}
