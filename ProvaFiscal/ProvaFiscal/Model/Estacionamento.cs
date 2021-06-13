﻿using System;
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

        private String Mensagem;
        private String Veiculo;
        private String Data_estacionamento;
        private int Hora;
        private String Lado;
        private String Situacao;
        private String DataRegistro;
        private int existe;
        private String Regra;
        private int tipo;



        public Estacionamento(String veiculo, String lado, String dataRegistro, int hora, String data_estacionamento, int tipoMulta)
        {

            this.Veiculo = veiculo;
            this.Lado = lado;
            this.Hora = hora;
            this.Data_estacionamento = data_estacionamento;
            this.DataRegistro = dataRegistro;
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
                this.Mensagem =("Erro");
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
                cmd.Parameters.AddWithValue("veiculo", this.Veiculo);
                cmd.Parameters.AddWithValue("Data_estacionamento", converterData(this.Data_estacionamento));
                cmd.Parameters.AddWithValue("lado", this.Lado);
                cmd.Parameters.AddWithValue("situacao", this.Situacao);
                cmd.Parameters.AddWithValue("DataRegistro", this.DataRegistro);
                cmd.Parameters.AddWithValue("hora", this.ConverteHora(this.Hora));
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
                    this.Mensagem = "O " + this.Veiculo + " Cadastrado com sucesso!";
                    this.Situacao = "";

                }
                catch (SqlException e)
                {
                    this.Mensagem = "Erro ao tentar se conectar ao banco";
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
            return this.Mensagem;
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
                else if (dia.Contains("sábado"))
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
                cmd.CommandText = @"SELECT COUNT(1) FROM estacionamento WHERE Veiculo = @veiculo2 and hora like @hora2 and Data_estacionamento = @Data_estacionamento2";
                cmd.Parameters.AddWithValue("hora2", this.ConverteHora(this.Hora));
                cmd.Parameters.AddWithValue("veiculo2", this.Veiculo);
                cmd.Parameters.AddWithValue("Data_estacionamento2", converterData(this.Data_estacionamento));
                cmd.Connection = conexa.conectar();

                string result = cmd.ExecuteScalar().ToString();
                
                
                string[] dadosDoCadastro = result.Split(':');

                if (Int16.Parse(dadosDoCadastro[0]) >= 1)
                {
                    this.Mensagem = ("O " + this.Veiculo + ", já esta cadastrado as " + this.ConverteHora(this.Hora) + " horas. Por favor cadastrar outro horario.");

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
                this.Mensagem = ("Erro ao executar verificador e " + cmd.ExecuteScalar() + "");
            }
        }


        public void Atualizarsituacao2()
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

                    if (this.Lado == "Direito")

                        this.Situacao = "Regular";
                    else
                        this.Situacao = "Irregular";

                }
                else if (dia.Contains("terça"))
                {

                    if (this.Lado == "Direito")
                    {

                        this.Situacao = "Irregular";
                    }
                    else
                        this.Situacao = "Regular";


                }
                else if (dia.Contains("quar"))
                {

                    if (this.Lado == "Direito")
                    {
                        this.Situacao = "Regular";
                    }
                    else
                        this.Situacao = "Irregular";

                }
                else if (dia.Contains("quinta"))
                {

                    if (this.Lado == "Direito")
                        this.Situacao = "Irregular";
                    else
                        this.Situacao = "Regular";



                }
                else if (dia.Contains("sexta"))
                {

                    if (this.Lado == "Direito")
                        this.Situacao = "Regular";
                    else
                        this.Situacao = "Irregular";


                }
                else if (dia.Contains("sábado"))
                {

                    this.Situacao = "Regular";

                }
                
            }
            else
                this.Situacao = "Regular";
        }
    }




}











                
                
    
