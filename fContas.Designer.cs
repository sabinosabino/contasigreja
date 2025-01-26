
namespace ControleDizimoOferta
{
    partial class fContas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label competenciaLabel;
            System.Windows.Forms.Label pessoaIdLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label valorContaLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContas));
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pessoaIdComboBox = new System.Windows.Forms.ComboBox();
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.valorContaTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.competenciaTextBox = new System.Windows.Forms.TextBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.cboExportar = new System.Windows.Forms.Button();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            competenciaLabel = new System.Windows.Forms.Label();
            pessoaIdLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            valorContaLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(39, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(39, 42);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 9;
            dataLabel.Text = "Data:";
            // 
            // competenciaLabel
            // 
            competenciaLabel.AutoSize = true;
            competenciaLabel.Location = new System.Drawing.Point(39, 68);
            competenciaLabel.Name = "competenciaLabel";
            competenciaLabel.Size = new System.Drawing.Size(72, 13);
            competenciaLabel.TabIndex = 10;
            competenciaLabel.Text = "Competencia:";
            // 
            // pessoaIdLabel
            // 
            pessoaIdLabel.AutoSize = true;
            pessoaIdLabel.Location = new System.Drawing.Point(39, 120);
            pessoaIdLabel.Name = "pessoaIdLabel";
            pessoaIdLabel.Size = new System.Drawing.Size(42, 13);
            pessoaIdLabel.TabIndex = 11;
            pessoaIdLabel.Text = "Pessoa";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(39, 94);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(28, 13);
            tipoIdLabel.TabIndex = 12;
            tipoIdLabel.Text = "Tipo";
            // 
            // valorContaLabel
            // 
            valorContaLabel.AutoSize = true;
            valorContaLabel.Location = new System.Drawing.Point(39, 147);
            valorContaLabel.Name = "valorContaLabel";
            valorContaLabel.Size = new System.Drawing.Size(65, 13);
            valorContaLabel.TabIndex = 14;
            valorContaLabel.Text = "Valor Conta:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(39, 173);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 16;
            observacaoLabel.Text = "Observacao:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "Id", true));
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Location = new System.Drawing.Point(113, 12);
            this.idNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.idNumericUpDown.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(86, 240);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(164, 240);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Blue;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(11, 240);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(12, 269);
            this.dtg.Name = "dtg";
            this.dtg.Size = new System.Drawing.Size(828, 217);
            this.dtg.TabIndex = 9;
            this.dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellContentClick);
            this.dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellDoubleClick);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(113, 38);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dataDateTimePicker.TabIndex = 10;
            // 
            // pessoaIdComboBox
            // 
            this.pessoaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pessoaIdComboBox.FormattingEnabled = true;
            this.pessoaIdComboBox.Location = new System.Drawing.Point(113, 117);
            this.pessoaIdComboBox.Name = "pessoaIdComboBox";
            this.pessoaIdComboBox.Size = new System.Drawing.Size(366, 21);
            this.pessoaIdComboBox.TabIndex = 12;
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(113, 91);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(366, 21);
            this.tipoIdComboBox.TabIndex = 13;
            this.tipoIdComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoIdComboBox_SelectedIndexChanged);
            // 
            // valorContaTextBox
            // 
            this.valorContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "ValorConta", true));
            this.valorContaTextBox.Location = new System.Drawing.Point(113, 144);
            this.valorContaTextBox.Name = "valorContaTextBox";
            this.valorContaTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorContaTextBox.TabIndex = 15;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(113, 170);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(702, 49);
            this.observacaoTextBox.TabIndex = 17;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTotal.Location = new System.Drawing.Point(750, 247);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(35, 16);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "0,00";
            // 
            // competenciaTextBox
            // 
            this.competenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "Competencia", true));
            this.competenciaTextBox.Enabled = false;
            this.competenciaTextBox.Location = new System.Drawing.Point(113, 65);
            this.competenciaTextBox.Name = "competenciaTextBox";
            this.competenciaTextBox.Size = new System.Drawing.Size(366, 20);
            this.competenciaTextBox.TabIndex = 19;
            // 
            // cboAno
            // 
            this.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(326, 242);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(73, 21);
            this.cboAno.TabIndex = 20;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(420, 242);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(128, 21);
            this.cboMes.TabIndex = 21;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.White;
            this.btnRecarregar.ForeColor = System.Drawing.Color.Black;
            this.btnRecarregar.Location = new System.Drawing.Point(554, 240);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(75, 23);
            this.btnRecarregar.TabIndex = 22;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // cboExportar
            // 
            this.cboExportar.BackColor = System.Drawing.Color.White;
            this.cboExportar.ForeColor = System.Drawing.Color.Black;
            this.cboExportar.Location = new System.Drawing.Point(635, 240);
            this.cboExportar.Name = "cboExportar";
            this.cboExportar.Size = new System.Drawing.Size(75, 23);
            this.cboExportar.TabIndex = 23;
            this.cboExportar.Text = "Exportar";
            this.cboExportar.UseVisualStyleBackColor = false;
            this.cboExportar.Click += new System.EventHandler(this.cboExportar_Click);
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataSource = typeof(ControleDizimoOferta.Models.Contas);
            // 
            // fContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 506);
            this.Controls.Add(this.cboExportar);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.competenciaTextBox);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(observacaoLabel);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(valorContaLabel);
            this.Controls.Add(this.valorContaTextBox);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(pessoaIdLabel);
            this.Controls.Add(this.pessoaIdComboBox);
            this.Controls.Add(competenciaLabel);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.fContas_Load_1);
            this.Click += new System.EventHandler(this.fContas_Click);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox pessoaIdComboBox;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.TextBox valorContaTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox competenciaTextBox;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Button cboExportar;
    }
}

