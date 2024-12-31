using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDizimoOferta
{
    public static class Staticos
    {

        private static IDbConnection _connection;
        public static IDbConnection Connection()
        {
            if (_connection != null)
            {
                return _connection;
            }

            try
            {
                string connectionString = @"Data Source=C:\Projetos\csharp\ControleDizimoOferta\database.db;";
                _connection = new SQLiteConnection(connectionString);

                _connection.Open();

                return _connection;
            }
            catch
            {

                throw new Exception("Tivemos um erro ao abrir a conexão");
            }
        }

        public static void ConfigDataGridView(this DataGridView dtg)
        {
            // Configurações do DataGridView
            dtg.AllowUserToAddRows = false; // Impede inserções
            dtg.AllowUserToDeleteRows = false; // Impede exclusões
            dtg.ReadOnly = true; // Impede edições
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automaticamente as colunas
            dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira

            // Estilizando as linhas zebradas
            dtg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Cor de fundo para linhas alternadas
            dtg.DefaultCellStyle.BackColor = Color.White; // Cor de fundo padrão para as outras linhas
            dtg.DefaultCellStyle.ForeColor = Color.Black; // Cor do texto
            dtg.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue; // Cor de fundo ao selecionar
            dtg.DefaultCellStyle.SelectionForeColor = Color.White; // Cor do texto ao selecionar
            dtg.RowHeadersVisible = false; // Esconde a coluna de cabeçalho de linha, se desejado

            // Impede redimensionamento manual pelo usuário
            dtg.AllowUserToResizeRows = false;
            dtg.AllowUserToResizeColumns = false;
        }
    }
}
