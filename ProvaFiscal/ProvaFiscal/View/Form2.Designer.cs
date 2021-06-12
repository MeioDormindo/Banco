namespace ProvaFiscal.View
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label veiculoLabel;
            System.Windows.Forms.Label data_estacionamentoLabel;
            System.Windows.Forms.Label ladoLabel;
            System.Windows.Forms.Label horaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.estacionamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.estacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaDataSet = new ProvaFiscal.provaDataSet();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.estacionamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.veiculoTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.horaComboBox = new System.Windows.Forms.ComboBox();
            this.ladoComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataestacionamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            veiculoLabel = new System.Windows.Forms.Label();
            data_estacionamentoLabel = new System.Windows.Forms.Label();
            ladoLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).BeginInit();
            this.estacionamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // veiculoLabel
            // 
            veiculoLabel.AutoSize = true;
            veiculoLabel.Location = new System.Drawing.Point(134, 25);
            veiculoLabel.Name = "veiculoLabel";
            veiculoLabel.Size = new System.Drawing.Size(45, 13);
            veiculoLabel.TabIndex = 4;
            veiculoLabel.Text = "Veiculo:";
            // 
            // data_estacionamentoLabel
            // 
            data_estacionamentoLabel.AutoSize = true;
            data_estacionamentoLabel.Location = new System.Drawing.Point(351, 24);
            data_estacionamentoLabel.Name = "data_estacionamentoLabel";
            data_estacionamentoLabel.Size = new System.Drawing.Size(112, 13);
            data_estacionamentoLabel.TabIndex = 6;
            data_estacionamentoLabel.Text = "Data Estacionamento:";
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Location = new System.Drawing.Point(667, 24);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new System.Drawing.Size(93, 13);
            ladoLabel.TabIndex = 8;
            ladoLabel.Text = "Lado Estacionado";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(553, 24);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(30, 13);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora";
            // 
            // estacionamentoBindingNavigator
            // 
            this.estacionamentoBindingNavigator.AddNewItem = null;
            this.estacionamentoBindingNavigator.BindingSource = this.estacionamentoBindingSource;
            this.estacionamentoBindingNavigator.CountItem = null;
            this.estacionamentoBindingNavigator.DeleteItem = null;
            this.estacionamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.estacionamentoBindingNavigatorSaveItem});
            this.estacionamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estacionamentoBindingNavigator.MoveFirstItem = null;
            this.estacionamentoBindingNavigator.MoveLastItem = null;
            this.estacionamentoBindingNavigator.MoveNextItem = null;
            this.estacionamentoBindingNavigator.MovePreviousItem = null;
            this.estacionamentoBindingNavigator.Name = "estacionamentoBindingNavigator";
            this.estacionamentoBindingNavigator.PositionItem = null;
            this.estacionamentoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.estacionamentoBindingNavigator.TabIndex = 0;
            this.estacionamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // estacionamentoBindingSource
            // 
            this.estacionamentoBindingSource.DataMember = "Estacionamento";
            this.estacionamentoBindingSource.DataSource = this.provaDataSet;
            // 
            // provaDataSet
            // 
            this.provaDataSet.DataSetName = "provaDataSet";
            this.provaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Novo Cadastro";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Cancelar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // estacionamentoBindingNavigatorSaveItem
            // 
            this.estacionamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estacionamentoBindingNavigatorSaveItem.Enabled = false;
            this.estacionamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estacionamentoBindingNavigatorSaveItem.Image")));
            this.estacionamentoBindingNavigatorSaveItem.Name = "estacionamentoBindingNavigatorSaveItem";
            this.estacionamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estacionamentoBindingNavigatorSaveItem.Text = "Salvar";
            this.estacionamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.estacionamentoBindingNavigatorSaveItem_Click);
            // 
            // veiculoTextBox
            // 
            this.veiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Veiculo", true));
            this.veiculoTextBox.Enabled = false;
            this.veiculoTextBox.Location = new System.Drawing.Point(0, 41);
            this.veiculoTextBox.Name = "veiculoTextBox";
            this.veiculoTextBox.Size = new System.Drawing.Size(301, 20);
            this.veiculoTextBox.TabIndex = 5;
            this.veiculoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.veiculoTextBox_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 40);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // horaComboBox
            // 
            this.horaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "hora", true));
            this.horaComboBox.Enabled = false;
            this.horaComboBox.FormattingEnabled = true;
            this.horaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.horaComboBox.Location = new System.Drawing.Point(510, 39);
            this.horaComboBox.Name = "horaComboBox";
            this.horaComboBox.Size = new System.Drawing.Size(121, 21);
            this.horaComboBox.TabIndex = 17;
            this.horaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horaComboBox_KeyPress);
            // 
            // ladoComboBox
            // 
            this.ladoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Lado", true));
            this.ladoComboBox.Enabled = false;
            this.ladoComboBox.FormattingEnabled = true;
            this.ladoComboBox.Items.AddRange(new object[] {
            "Esquerdo",
            "Direito"});
            this.ladoComboBox.Location = new System.Drawing.Point(655, 39);
            this.ladoComboBox.Name = "ladoComboBox";
            this.ladoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ladoComboBox.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.dataestacionamentoDataGridViewTextBoxColumn,
            this.hora,
            this.ladoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.dataRegistroDataGridViewTextBoxColumn,
            this.Regra});
            this.dataGridView1.DataSource = this.estacionamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 448);
            this.dataGridView1.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veículo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            this.veiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataestacionamentoDataGridViewTextBoxColumn
            // 
            this.dataestacionamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_estacionamento";
            this.dataestacionamentoDataGridViewTextBoxColumn.HeaderText = "Estacionado";
            this.dataestacionamentoDataGridViewTextBoxColumn.Name = "dataestacionamentoDataGridViewTextBoxColumn";
            this.dataestacionamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataestacionamentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 50;
            // 
            // ladoDataGridViewTextBoxColumn
            // 
            this.ladoDataGridViewTextBoxColumn.DataPropertyName = "Lado";
            this.ladoDataGridViewTextBoxColumn.HeaderText = "Lado da rua";
            this.ladoDataGridViewTextBoxColumn.Name = "ladoDataGridViewTextBoxColumn";
            this.ladoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ladoDataGridViewTextBoxColumn.Width = 90;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataRegistroDataGridViewTextBoxColumn
            // 
            this.dataRegistroDataGridViewTextBoxColumn.DataPropertyName = "DataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.HeaderText = "Data Registro";
            this.dataRegistroDataGridViewTextBoxColumn.Name = "dataRegistroDataGridViewTextBoxColumn";
            this.dataRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRegistroDataGridViewTextBoxColumn.Width = 120;
            // 
            // Regra
            // 
            this.Regra.DataPropertyName = "Regra";
            this.Regra.HeaderText = "Regra";
            this.Regra.Name = "Regra";
            this.Regra.ReadOnly = true;
            this.Regra.Width = 110;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ladoComboBox);
            this.Controls.Add(this.horaComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(veiculoLabel);
            this.Controls.Add(this.veiculoTextBox);
            this.Controls.Add(data_estacionamentoLabel);
            this.Controls.Add(ladoLabel);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.estacionamentoBindingNavigator);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).EndInit();
            this.estacionamentoBindingNavigator.ResumeLayout(false);
            this.estacionamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private provaDataSet provaDataSet;
        private System.Windows.Forms.BindingSource estacionamentoBindingSource;
        private System.Windows.Forms.BindingNavigator estacionamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton estacionamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox veiculoTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox horaComboBox;
        private System.Windows.Forms.ComboBox ladoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataestacionamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regra;
    }
}