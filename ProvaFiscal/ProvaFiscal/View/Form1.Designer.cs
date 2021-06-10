namespace ProvaFiscal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label veiculoLabel;
            System.Windows.Forms.Label ladoLabel;
            System.Windows.Forms.Label horaLabel;
            this.estacionamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.estacionamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.veiculoTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ladoComboBox = new System.Windows.Forms.ComboBox();
            this.estacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaDataSet = new ProvaFiscal.provaDataSet();
            this.estacionamentoTableAdapter = new ProvaFiscal.provaDataSetTableAdapters.EstacionamentoTableAdapter();
            this.tableAdapterManager = new ProvaFiscal.provaDataSetTableAdapters.TableAdapterManager();
            this.estacionamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataEstacionamento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.horaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            veiculoLabel = new System.Windows.Forms.Label();
            ladoLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).BeginInit();
            this.estacionamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // estacionamentoBindingNavigator
            // 
            this.estacionamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estacionamentoBindingNavigator.BindingSource = this.estacionamentoBindingSource;
            this.estacionamentoBindingNavigator.CountItem = null;
            this.estacionamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estacionamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.estacionamentoBindingNavigatorSaveItem});
            this.estacionamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estacionamentoBindingNavigator.MoveFirstItem = null;
            this.estacionamentoBindingNavigator.MoveLastItem = null;
            this.estacionamentoBindingNavigator.MoveNextItem = null;
            this.estacionamentoBindingNavigator.MovePreviousItem = null;
            this.estacionamentoBindingNavigator.Name = "estacionamentoBindingNavigator";
            this.estacionamentoBindingNavigator.PositionItem = null;
            this.estacionamentoBindingNavigator.Size = new System.Drawing.Size(896, 25);
            this.estacionamentoBindingNavigator.TabIndex = 0;
            this.estacionamentoBindingNavigator.Text = "bindingNavigator1";
            this.estacionamentoBindingNavigator.RefreshItems += new System.EventHandler(this.estacionamentoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // estacionamentoBindingNavigatorSaveItem
            // 
            this.estacionamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estacionamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estacionamentoBindingNavigatorSaveItem.Image")));
            this.estacionamentoBindingNavigatorSaveItem.Name = "estacionamentoBindingNavigatorSaveItem";
            this.estacionamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estacionamentoBindingNavigatorSaveItem.Text = "Save Data";
            this.estacionamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.estacionamentoBindingNavigatorSaveItem_Click);
            // 
            // veiculoLabel
            // 
            veiculoLabel.AutoSize = true;
            veiculoLabel.Location = new System.Drawing.Point(98, 12);
            veiculoLabel.Name = "veiculoLabel";
            veiculoLabel.Size = new System.Drawing.Size(45, 13);
            veiculoLabel.TabIndex = 3;
            veiculoLabel.Text = "Veiculo:";
            // 
            // veiculoTextBox
            // 
            this.veiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Veiculo", true));
            this.veiculoTextBox.Location = new System.Drawing.Point(15, 28);
            this.veiculoTextBox.Name = "veiculoTextBox";
            this.veiculoTextBox.Size = new System.Drawing.Size(216, 20);
            this.veiculoTextBox.TabIndex = 4;
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Location = new System.Drawing.Point(645, 9);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new System.Drawing.Size(95, 13);
            ladoLabel.TabIndex = 9;
            ladoLabel.Text = "Lado estacionado:";
            ladoLabel.Click += new System.EventHandler(this.ladoLabel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ladoComboBox
            // 
            this.ladoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Lado", true));
            this.ladoComboBox.FormattingEnabled = true;
            this.ladoComboBox.Items.AddRange(new object[] {
            "Esquerdo",
            "Direito"});
            this.ladoComboBox.Location = new System.Drawing.Point(632, 28);
            this.ladoComboBox.Name = "ladoComboBox";
            this.ladoComboBox.Size = new System.Drawing.Size(120, 21);
            this.ladoComboBox.TabIndex = 11;
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
            // estacionamentoTableAdapter
            // 
            this.estacionamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstacionamentoTableAdapter = this.estacionamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProvaFiscal.provaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estacionamentoDataGridView
            // 
            this.estacionamentoDataGridView.AutoGenerateColumns = false;
            this.estacionamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estacionamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.estacionamentoDataGridView.DataSource = this.estacionamentoBindingSource;
            this.estacionamentoDataGridView.Location = new System.Drawing.Point(0, 67);
            this.estacionamentoDataGridView.Name = "estacionamentoDataGridView";
            this.estacionamentoDataGridView.Size = new System.Drawing.Size(884, 382);
            this.estacionamentoDataGridView.TabIndex = 12;
            // 
            // dataEstacionamento
            // 
            this.dataEstacionamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEstacionamento.Location = new System.Drawing.Point(264, 28);
            this.dataEstacionamento.Name = "dataEstacionamento";
            this.dataEstacionamento.Size = new System.Drawing.Size(200, 20);
            this.dataEstacionamento.TabIndex = 13;
            this.dataEstacionamento.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data do estacionamento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(523, 9);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 14;
            horaLabel.Text = "Hora:";
            horaLabel.Click += new System.EventHandler(this.horaLabel_Click);
            // 
            // horaComboBox
            // 
            this.horaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "hora", true));
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
            "23",
            "24"});
            this.horaComboBox.Location = new System.Drawing.Point(481, 28);
            this.horaComboBox.Name = "horaComboBox";
            this.horaComboBox.Size = new System.Drawing.Size(121, 21);
            this.horaComboBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Veiculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Veiculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaSemana";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiaSemana";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Diames";
            this.dataGridViewTextBoxColumn4.HeaderText = "Diames";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn8.HeaderText = "hora";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 469);
            this.Controls.Add(this.horaComboBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEstacionamento);
            this.Controls.Add(this.estacionamentoDataGridView);
            this.Controls.Add(this.ladoComboBox);
            this.Controls.Add(veiculoLabel);
            this.Controls.Add(this.veiculoTextBox);
            this.Controls.Add(ladoLabel);
            this.Controls.Add(this.estacionamentoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).EndInit();
            this.estacionamentoBindingNavigator.ResumeLayout(false);
            this.estacionamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private provaDataSet provaDataSet;
        private System.Windows.Forms.BindingSource estacionamentoBindingSource;
        private provaDataSetTableAdapters.EstacionamentoTableAdapter estacionamentoTableAdapter;
        private provaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estacionamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton estacionamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox veiculoTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox ladoComboBox;
        private System.Windows.Forms.DataGridView estacionamentoDataGridView;
        private System.Windows.Forms.DateTimePicker dataEstacionamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox horaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

