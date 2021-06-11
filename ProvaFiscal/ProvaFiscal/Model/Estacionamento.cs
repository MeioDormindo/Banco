using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using ProvaFiscal.DAO;
using System.Threading.Tasks;

namespace ProvaFiscal.Model
{
    class Estacionamento
    {

        protected Conexao conexa = new Conexao();
        protected SqlCommand cmd = new SqlCommand();

        public int id;
        public String Mensagem;
        public String Veiculo;
        public String Data_estacionamento;
        public int Hora;
        public String Lado;
        public String Situacao;
        public String DataRegistro;
        public int existe;



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

        public String ConverteHora(int hora)
        {
            return  hora + ":00h";
        }


        public void Cadastro(Estacionamento estacionamento)
        {
            verificarExiste();

            if (this.existe == 1)
            {
                // comando sql insert
                cmd.CommandText = "insert into estacionamento (Veiculo, Data_estacionamento, Lado, Situacao, DataRegistro, hora)  values(@veiculo, @Data_estacionamento,  @lado, @situacao, @DataRegistro, @hora) ";

            // parametros
            cmd.Parameters.AddWithValue("veiculo", this.Veiculo);
            cmd.Parameters.AddWithValue("Data_estacionamento", this.Data_estacionamento);
            cmd.Parameters.AddWithValue("lado", this.Lado);
            cmd.Parameters.AddWithValue("situacao", this.Situacao);
            cmd.Parameters.AddWithValue("DataRegistro", this.DataRegistro);
            cmd.Parameters.AddWithValue("hora", this.ConverteHora(this.Hora));
    

                try
                {
                    // conecta com o banco
                    cmd.Connection = conexa.conectar();
                    // executa o comando 
                    cmd.ExecuteNonQuery();
                    //desconectar
                    conexa.desconectar();
                    // msg positiva
                    this.Mensagem = "O "+this.Veiculo+" Cadastrado com sucesso!";
                    this.Situacao = "";

                }
                catch (SqlException e)
                {
                    this.Mensagem = "Erro ao tentar se conectar ao banco";
                }
            }
        }


        public void Atualizarsituacao()
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime oDate = Convert.ToDateTime(this.Data_estacionamento);
            String dia = convertedata.GetDayName(oDate.Date.DayOfWeek);

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

        public void verificarExiste()
        {
            
            
            try
            {
                cmd.CommandText = "SELECT COUNT(1) FROM estacionamento WHERE Veiculo = @veiculo2 and hora = @hora2 and Data_estacionamento = @Data_estacionamento2 ";
                cmd.Parameters.AddWithValue("hora2", this.Hora);
                cmd.Parameters.AddWithValue("veiculo2", this.Veiculo);
                cmd.Parameters.AddWithValue("Data_estacionamento2", this.Data_estacionamento);
                cmd.Connection = conexa.conectar();

                string result = cmd.ExecuteScalar().ToString();

                conexa.desconectar();

                if (Int16.Parse(result) >=  1)
                {
                    this.Mensagem = ("O "+this.Veiculo+", já esta cadastrado as "+this.Hora+" horas. Por favor cadastrar outro horario.");
                   
                    this.existe = 2;
                }
                else
                {
                   
                    this.existe = 1;
                }
            }
            catch (SqlException e)
            {
                this.Mensagem = ("Erro ao executar verificador e "+cmd.ExecuteScalar()+"");
            }
           
        }

    }
}




                
                
    
