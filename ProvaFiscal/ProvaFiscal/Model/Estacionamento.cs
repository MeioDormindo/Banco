using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFiscal.Model
{
    class Estacionamento
    {

        Conexao conexa = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public int id;
        public String Mensagem;
        public String Veiculo;
        public String Data_estacionamento;
        public int Hora;
        public String Lado;
        public String Situacao;
        public String DataRegistro;



        public Estacionamento(String veiculo, String lado, String dataRegistro, int hora, String data_estacionamento)
        {

            this.Veiculo = veiculo;
            this.Lado = lado;
            this.Hora = hora;
            this.Data_estacionamento = data_estacionamento;
            this.DataRegistro = dataRegistro;
            Atualizarsituacao();
        }

        public Estacionamento()
        {

        }

        public void Cadastro(Estacionamento estacionamento)
        {
            // comando sql insert
            cmd.CommandText = "insert into estacionamento (Veiculo, Data_estacionamento, Lado, Situacao, DataRegistro, hora)  values(@veiculo, @Data_estacionamento,  @lado, @situacao, @DataRegistro, @hora) ";

            // parametros
            cmd.Parameters.AddWithValue("veiculo", this.Veiculo);
            cmd.Parameters.AddWithValue("Data_estacionamento", this.Data_estacionamento);
            cmd.Parameters.AddWithValue("lado", this.Lado);
            cmd.Parameters.AddWithValue("situacao", this.Situacao);
            cmd.Parameters.AddWithValue("DataRegistro", this.DataRegistro);
            cmd.Parameters.AddWithValue("hora", this.Hora);

            try
            {
                // conecta com o banco
                cmd.Connection = conexa.conectar();
                // executa o comando 
                cmd.ExecuteNonQuery();
                //desconectar
                conexa.desconectar();
                // msg positiva
                this.Mensagem = "Cadastrado com sucesso";
                this.Situacao = "";

            }
            catch (SqlException e)
            {
                this.Mensagem = "Erro ao tentar se conectar ao banco";
            }
        }

        public void Atualizarsituacao()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            DateTime oDate = Convert.ToDateTime(this.Data_estacionamento);
            String dia = dtfi.GetDayName(oDate.Date.DayOfWeek);

            if (this.Hora >= 7 && this.Hora <= 20)
            {

                if (dia.Contains("domingo"))
                {

                    this.Situacao = "Regular";

                }
                else if (dia.Contains("segunda"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.Lado == "Direito")

                            this.Situacao = "Irregular";
                        else
                            this.Situacao = "Regular";
                    }
                    else
                        if (this.Lado == "Direito")
                    {

                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";

                }
                else if (dia.Contains("terça"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.Lado == "Direito")
                        {

                            this.Situacao = "Irregular";
                        }
                        else
                            this.Situacao = "Regular";

                    }
                    else
                        if (this.Lado == "Direito")
                    {

                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";
                }
                else if (dia.Contains("quar"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.Lado == "Direito")
                        {
                            this.Situacao = "Irregular";
                        }
                        else
                            this.Situacao = "Regular";

                    }
                    else
                        if (this.Lado == "Direito")
                    {

                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";
                }
                else if (dia.Contains("quinta"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.Lado == "Direito")
                            this.Situacao = "Irregular";
                        else
                            this.Situacao = "Regular";

                    }
                    else
                        if (this.Lado == "Direito")
                    {

                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";
                }
                else if (dia.Contains("sexta"))
                {
                    if (oDate.Date.Day % 2 == 0)
                    {
                        if (this.Lado == "Direito")
                            this.Situacao = "Irregular";
                        else
                            this.Situacao = "Regular";

                    }
                    else
                        if (this.Lado == "Direito")
                    {

                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";
                }
                else if (dia.Contains("sabado"))
                {

                    this.Situacao = "Regular";

                }
                else if (dia.Contains("Domingo"))
                {

                    this.Situacao = "Regular";

                }



            }
            else
                this.Situacao = "Regular";
        }
    }
}

                
                
    
