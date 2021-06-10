using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'provaDataSet.Estacionamento' table. You can move, or remove it, as needed.
            this.estacionamentoTableAdapter.Fill(this.provaDataSet.Estacionamento);

        }

        private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estacionamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.provaDataSet);

        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void estacionamentoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void estacionamentoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void horaLabel_Click(object sender, EventArgs e)
        {

        }

        private void ladoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            //teste.Text = dtfi.GetDayName(dataEstacionamento.Value.Date.DayOfWeek);
            teste.Text = ladoComboBox.Text;
              

           

        }
    }
}
