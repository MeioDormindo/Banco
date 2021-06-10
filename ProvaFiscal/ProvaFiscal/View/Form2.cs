using ProvaFiscal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFiscal.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {
            
            String veiculo = veiculoTextBox.Text;
            String lado = ladoComboBox.Text;
            String dataRegistro = DateTime.Now.ToString("dd-MM-yyyy");
            int hora = Convert.ToInt32(horaComboBox.Text);
            String data_estacionamento = dateTimePicker1.Value.ToShortDateString();
            Estacionamento estacionamento = new Estacionamento(veiculo, lado, dataRegistro, hora,data_estacionamento);

            estacionamento.Cadastro(estacionamento);
            MessageBox.Show(estacionamento.Mensagem);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'provaDataSet.Estacionamento' table. You can move, or remove it, as needed.
            this.estacionamentoTableAdapter.Fill(this.provaDataSet.Estacionamento);

        }
    }
}
