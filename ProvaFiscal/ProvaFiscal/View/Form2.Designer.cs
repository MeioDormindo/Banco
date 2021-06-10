namespace ProvaFiscal.View
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label veiculoLabel;
            System.Windows.Forms.Label data_estacionamentoLabel;
            System.Windows.Forms.Label ladoLabel;
            System.Windows.Forms.Label horaLabel;
            this.provaDataSet = new ProvaFiscal.provaDataSet();
            this.estacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoTableAdapter = new ProvaFiscal.provaDataSetTableAdapters.EstacionamentoTableAdapter();
            this.tableAdapterManager = new ProvaFiscal.provaDataSetTableAdapters.TableAdapterManager();
            this.estacionamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.estacionamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.estacionamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.horaComboBox = new System.Windows.Forms.ComboBox();
            this.ladoComboBox = new System.Windows.Forms.ComboBox();
            veiculoLabel = new System.Windows.Forms.Label();
            data_estacionamentoLabel = new System.Windows.Forms.Label();
            ladoLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).BeginInit();
            this.estacionamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // provaDataSet
            // 
            this.provaDataSet.DataSetName = "provaDataSet";
            this.provaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estacionamentoBindingSource
            // 
            this.estacionamentoBindingSource.DataMember = "Estacionamento";
            this.estacionamentoBindingSource.DataSource = this.provaDataSet;
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
            // estacionamentoBindingNavigator
            // 
            this.estacionamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estacionamentoBindingNavigator.BindingSource = this.estacionamentoBindingSource;
            this.estacionamentoBindingNavigator.CountItem = null;
            this.estacionamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estacionamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estacionamentoBindingNavigatorSaveItem});
            this.estacionamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estacionamentoBindingNavigator.MoveFirstItem = null;
            this.estacionamentoBindingNavigator.MoveLastItem = null;
            this.estacionamentoBindingNavigator.MoveNextItem = null;
            this.estacionamentoBindingNavigator.MovePreviousItem = null;
            this.estacionamentoBindingNavigator.Name = "estacionamentoBindingNavigator";
            this.estacionamentoBindingNavigator.PositionItem = null;
            this.estacionamentoBindingNavigator.Size = new System.Drawing.Size(809, 25);
            this.estacionamentoBindingNavigator.TabIndex = 0;
            this.estacionamentoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // estacionamentoBindingNavigatorSaveItem
            // 
            this.estacionamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estacionamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estacionamentoBindingNavigatorSaveItem.Image")));
            this.estacionamentoBindingNavigatorSaveItem.Name = "estacionamentoBindingNavigatorSaveItem";
            this.estacionamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.estacionamentoBindingNavigatorSaveItem.Text = "Save Data";
            this.estacionamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.estacionamentoBindingNavigatorSaveItem_Click);
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.estacionamentoDataGridView.DataSource = this.estacionamentoBindingSource;
            this.estacionamentoDataGridView.Location = new System.Drawing.Point(0, 87);
            this.estacionamentoDataGridView.Name = "estacionamentoDataGridView";
            this.estacionamentoDataGridView.Size = new System.Drawing.Size(808, 434);
            this.estacionamentoDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_estacionamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_estacionamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataRegistro";
            this.dataGridViewTextBoxColumn6.HeaderText = "DataRegistro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn7.HeaderText = "hora";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            // veiculoTextBox
            // 
            this.veiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Veiculo", true));
            this.veiculoTextBox.Location = new System.Drawing.Point(0, 41);
            this.veiculoTextBox.Name = "veiculoTextBox";
            this.veiculoTextBox.Size = new System.Drawing.Size(301, 20);
            this.veiculoTextBox.TabIndex = 5;
            // 
            // data_estacionamentoLabel
            // 
            data_estacionamentoLabel.AutoSize = true;
            data_estacionamentoLabel.Location = new System.Drawing.Point(351, 24);
            data_estacionamentoLabel.Name = "data_estacionamentoLabel";
            data_estacionamentoLabel.Size = new System.Drawing.Size(111, 13);
            data_estacionamentoLabel.TabIndex = 6;
            data_estacionamentoLabel.Text = "Data estacionamento:";
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Location = new System.Drawing.Point(667, 24);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new System.Drawing.Size(92, 13);
            ladoLabel.TabIndex = 8;
            ladoLabel.Text = "Lado estacionado";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 16;
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
            this.horaComboBox.Location = new System.Drawing.Point(510, 39);
            this.horaComboBox.Name = "horaComboBox";
            this.horaComboBox.Size = new System.Drawing.Size(121, 21);
            this.horaComboBox.TabIndex = 17;
            // 
            // ladoComboBox
            // 
            this.ladoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Lado", true));
            this.ladoComboBox.FormattingEnabled = true;
            this.ladoComboBox.Items.AddRange(new object[] {
            "Esquerdo",
            "Direito"});
            this.ladoComboBox.Location = new System.Drawing.Point(655, 39);
            this.ladoComboBox.Name = "ladoComboBox";
            this.ladoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ladoComboBox.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 541);
            this.Controls.Add(this.ladoComboBox);
            this.Controls.Add(this.horaComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(veiculoLabel);
            this.Controls.Add(this.veiculoTextBox);
            this.Controls.Add(data_estacionamentoLabel);
            this.Controls.Add(ladoLabel);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.estacionamentoDataGridView);
            this.Controls.Add(this.estacionamentoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).EndInit();
            this.estacionamentoBindingNavigator.ResumeLayout(false);
            this.estacionamentoBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.DataGridView estacionamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox veiculoTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox horaComboBox;
        private System.Windows.Forms.ComboBox ladoComboBox;
    }
}