using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using ProvaFiscal.DAO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFiscal.Model
{
    class Estacionamento
    {

        private Conexao conexa = new Conexao();
        private SqlCommand cmd = new SqlCommand();

        private String mensagem;
        private String veiculo;
        private String data_estacionamento;
        private int hora;
        private String lado;
        private String situacao;
        private String dataRegistro;
        private int existe;
        private String Regra;
        private int tipo;



        public Estacionamento(String veiculo, String lado, String dataRegistro, int hora, String data_estacionamento, int tipoMulta)
        {

            this.veiculo = veiculo;
            this.lado = lado;
            this.hora = hora;
            this.data_estacionamento = data_estacionamento;
            this.dataRegistro = dataRegistro;
            this.tipo = tipoMulta;

            if (this.tipo == 1)
            {
                
                this.Regra = "Dia da semana";
                Atualizarsituacao2();
            }
            if (this.tipo == 2) 
            {
                this.Regra = "Número do dia";
                Atualizarsituacao();

            }
            else
            {
                this.mensagem =("Erro");
            }

        }

        public Estacionamento()
        {

        }

        public String ConverteHora(int hora)
        {
            return hora + ":00h";
        }


        public void Cadastro(Estacionamento estacionamento)
        {
            verificarExiste();
            

            if (this.existe == 1)
            {
                // comando sql insert
                cmd.CommandText = "insert into estacionamento (Veiculo, Data_estacionamento, Lado, Situacao, DataRegistro, hora, Regra)  values(@veiculo, @Data_estacionamento,  @lado, @situacao, @DataRegistro, @hora, @Regra) ";

                // parametros
                cmd.Parameters.AddWithValue("veiculo", this.veiculo);
                cmd.Parameters.AddWithValue("Data_estacionamento", converterData(this.data_estacionamento));
                cmd.Parameters.AddWithValue("lado", this.lado);
                cmd.Parameters.AddWithValue("situacao", this.situacao);
                cmd.Parameters.AddWithValue("DataRegistro", this.dataRegistro);
                cmd.Parameters.AddWithValue("hora", this.ConverteHora(this.hora));
                cmd.Parameters.AddWithValue("Regra", this.Regra);

                try
                {
                    // conecta com o banco
                    cmd.Connection = conexa.conectar();
                    // executa o comando 
                    cmd.ExecuteNonQuery();
                    //desconectar
                    conexa.desconectar();
                    // msg positiva
                    this.mensagem = "O " + this.veiculo + " Cadastrado com sucesso!";
                    this.situacao = "";

                }
                catch (SqlException e)
                {
                    this.mensagem = "Erro ao tentar se conectar ao banco";
                }
            }
        }

        public String converterData(String data)
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime date = Convert.ToDateTime(data);
            String novadata = date.ToString("dddd") + ", dia " + date.ToString("dd") + " de " + date.ToString("MMMM");
            return novadata;
        }

        public string ReceberMenssagem()
        {
            return this.mensagem;
        }


        public void Atualizarsituacao()
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime oDate = Convert.ToDateTime(this.data_estacionamento);
            String dia = convertedata.GetDayName(oDate.Date.DayOfWeek);

            if (this.hora >= 7 && this.hora <= 20)
            {

                if (dia.Contains("domingo"))
                {

                    this.situacao = "Regular";

                }
                else if (dia.Contains("segunda"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.lado == "Direito")

                            this.situacao = "Irregular";
                        else
                            this.situacao = "Regular";
                    }
                    else
                        if (this.lado == "Direito")
                    {

                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";

                }
                else if (dia.Contains("terça"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.lado == "Direito")
                        {

                            this.situacao = "Irregular";
                        }
                        else
                            this.situacao = "Regular";

                    }
                    else
                        if (this.lado == "Direito")
                    {

                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";
                }
                else if (dia.Contains("quar"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.lado == "Direito")
                        {
                            this.situacao = "Irregular";
                        }
                        else
                            this.situacao = "Regular";

                    }
                    else
                        if (this.lado == "Direito")
                    {

                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";
                }
                else if (dia.Contains("quinta"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.lado == "Direito")
                            this.situacao = "Irregular";
                        else
                            this.situacao = "Regular";

                    }
                    else
                        if (this.lado == "Direito")
                    {

                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";
                }
                else if (dia.Contains("sexta"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.lado == "Direito")
                            this.situacao = "Irregular";
                        else
                            this.situacao = "Regular";

                    }
                    else
                        if (this.lado == "Direito")
                    {

                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";
                }
                else if (dia.Contains("sábado"))
                {

                    this.situacao = "Regular";

                }
               
            }
            else
                this.situacao = "Regular";
        }

        public void verificarExiste()
        {
            try
            {
                cmd.CommandText = @"SELECT COUNT(1) FROM estacionamento WHERE Veiculo = @veiculo2 and hora like @hora2 and Data_estacionamento = @Data_estacionamento2";
                cmd.Parameters.AddWithValue("hora2", this.ConverteHora(this.hora));
                cmd.Parameters.AddWithValue("veiculo2", this.veiculo);
                cmd.Parameters.AddWithValue("Data_estacionamento2", converterData(this.data_estacionamento));
                cmd.Connection = conexa.conectar();

                string result = cmd.ExecuteScalar().ToString();
                
                
                string[] dadosDoCadastro = result.Split(':');

                if (Int16.Parse(dadosDoCadastro[0]) >= 1)
                {
                    this.mensagem = ("O " + this.veiculo + ", já esta cadastrado as " + this.ConverteHora(this.hora) + " horas. Por favor cadastrar outro horario.");

                    this.existe = 2;
                    conexa.desconectar();
                }
                else
                {
                    conexa.desconectar();
                    this.existe = 1;
                }
            }
            catch (SqlException e)
            {
                conexa.desconectar();
                this.mensagem = ("Erro ao executar verificador e " + cmd.ExecuteScalar() + "");
            }
        }


        public void Atualizarsituacao2()
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime oDate = Convert.ToDateTime(this.data_estacionamento);
            String dia = convertedata.GetDayName(oDate.Date.DayOfWeek);

            if (this.hora >= 7 && this.hora <= 20)
            {

                if (dia.Contains("domingo"))
                {

                    this.situacao = "Regular";

                }
                else if (dia.Contains("segunda"))
                {

                    if (this.lado == "Direito")

                        this.situacao = "Regular";
                    else
                        this.situacao = "Irregular";

                }
                else if (dia.Contains("terça"))
                {

                    if (this.lado == "Direito")
                    {

                        this.situacao = "Irregular";
                    }
                    else
                        this.situacao = "Regular";


                }
                else if (dia.Contains("quar"))
                {

                    if (this.lado == "Direito")
                    {
                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";

                }
                else if (dia.Contains("quinta"))
                {

                    if (this.lado == "Direito")
                        this.situacao = "Irregular";
                    else
                        this.situacao = "Regular";



                }
                else if (dia.Contains("sexta"))
                {

                    if (this.lado == "Direito")
                        this.situacao = "Regular";
                    else
                        this.situacao = "Irregular";


                }
                else if (dia.Contains("sábado"))
                {

                    this.situacao = "Regular";

                }
                
            }
            else
                this.situacao = "Regular";
        }
    }




}











                
                
    
