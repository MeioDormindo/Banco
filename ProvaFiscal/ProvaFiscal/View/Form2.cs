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
        public Cadastro()
        {
            InitializeComponent();
           CarreTabela();
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

            private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {

            if (CampoVazio(veiculoTextBox, "Veiculo"))
            {
                return;
            }
            else if (CampoVazio(horaComboBox, "Hora"))
            {
                return;
            }
            else if (CampoVazio(ladoComboBox, "Lado Estacionamento")){
                return;
            }
            


            else {


                String veiculo = veiculoTextBox.Text;
                String lado = ladoComboBox.Text;
                String dataRegistro = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                int hora = Convert.ToInt32(horaComboBox.Text);
                String data_estacionamento = dateTimePicker1.Value.ToShortDateString();

                if (hora >= 0 & hora <= 23)
                {
                    Estacionamento estacionamento = new Estacionamento(veiculo, lado, dataRegistro, hora, data_estacionamento);

                    estacionamento.Cadastro(estacionamento);

                    MessageBox.Show(estacionamento.Mensagem);
                    CarreTabela();

                    veiculoTextBox.Text = "";
                    ladoComboBox.Text = "";
                    horaComboBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Hora invalida!!!");
                }
                
            }

            
        }
            }
        }

        
    

