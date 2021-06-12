using ProvaFiscal.DAO;
using ProvaFiscal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFiscal.View
{

    public partial class Cadastro : Form
    {
        int tipoMulta;

        public Cadastro()
        {
            InitializeComponent();
           CarreTabela();
            horaComboBox.MaxLength = (2);
        }

        public void CarreTabela()
        {
             Conexao conexa = new Conexao();
             SqlCommand cmd = new SqlCommand();
             DataSet dados = new DataSet();

             cmd.CommandText = " select * from Estacionamento order by DataRegistro desc";

            
            cmd.Connection = conexa.conectar();
            

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;


            adapter.Fill(dados);
            dataGridView1.DataSource = dados;
            dataGridView1.DataMember = dados.Tables[0].TableName;

            conexa.desconectar();


        }
        public bool CampoVazio(Control controle, String campo)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("O campo " + campo + " é obrigatortio");
                controle.Focus();
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool campoLado()
        {
            if (ladoComboBox.Text == "Direito") {
                return true;
            }
            else if(ladoComboBox.Text == "Esquerdo"){

                return true;
                }
            else{
                MessageBox.Show("O campo Lado Estacionado está incorreto.");
                
                return false;

            }


            }

            private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {

            String data_estacionamento = "";

            if (CampoVazio(veiculoTextBox, "Veiculo"))
            {
                return;
            }
            else if (CampoVazio(horaComboBox, "Hora"))
            {
                return;
            }
            else if (CampoVazio(ladoComboBox, "Lado Estacionamento"))
            {
                return;
            }

            else
            {

                String veiculo = "Veiculo " + veiculoTextBox.Text;
                String lado = ladoComboBox.Text;
                String dataRegistro = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                int hora = Convert.ToInt32(horaComboBox.Text);
                data_estacionamento = dateTimePicker1.Value.ToShortDateString();

                if (dateTimePicker1.Value > DateTime.Now)
                {
                    MessageBox.Show("Data de estacionamento maior que data atual! Por favor ajuste.");

                }
                else
                {

                    if ((hora >= 0 & hora <= 23))
                    {
                        if (campoLado())
                        {


                            DialogResult confirm = MessageBox.Show("Deseja Cadastrar realmente?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                            if (confirm.ToString().ToUpper() == "YES")
                            {

                                Estacionamento estacionamento = new Estacionamento(veiculo, lado, dataRegistro, hora, data_estacionamento, tipoMulta);

                                estacionamento.Cadastro(estacionamento);

                                MessageBox.Show(estacionamento.ReceberMenssagem());
                                CarreTabela();
                                Desativar();
                            }
                            else
                            {
                                MessageBox.Show("Cadastro Cancelado");
                                Desativar();
                            }



                        }
                    }
                    else
                    {
                        MessageBox.Show("Hora invalida!!!");
                    }

                }
            }

            
        }

       
        private void Desativar()
        {
            estacionamentoBindingNavigatorSaveItem.Enabled = false;
            veiculoTextBox.Enabled = false;
            ladoComboBox.Enabled = false;
            horaComboBox.Enabled = false;
            dateTimePicker1.Enabled = false;

            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;

            
        }
        private void Ativar()
        {
            estacionamentoBindingNavigatorSaveItem.Enabled = true;
            veiculoTextBox.Enabled = true;
            ladoComboBox.Enabled = true;
            horaComboBox.Enabled = true;
            dateTimePicker1.Enabled = true;
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = true;

            veiculoTextBox.Text = "";
            ladoComboBox.Text = "";
            horaComboBox.Text = "";

        }


        private void horaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Multas baseadas no dia da semana selecione (SIM), se selecionado NÂO as multas será baseadas no dia.", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                Ativar();
                tipoMulta = 1;
            }
            else
            {
                tipoMulta = 2;
                Ativar();
            }
               
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Desativar();
        }

        private void veiculoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
        }

        
    

