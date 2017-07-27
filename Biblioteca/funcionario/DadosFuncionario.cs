using Biblioteca;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pessoa;


namespace Biblioteca.funcionario
{
   public class DadosFuncionario : ConexaoSqlServer
    {
        private string sql;
        public List<Pessoa> Select(string tipo)
        {
            List<Pessoa> retorno = new List<Pessoa>();
            try
            {
                this.abrirConexao();
                //string sql;
                //instrucao a ser executada
                if (tipo.ToUpper() == "FUNCIONARIO")
                {
                    sql = "select p.cpf from pessoa p inner join funcionario f on f.FK_funcionarioCpf=p.cpf";
                }
                if(tipo.ToUpper()=="CLIENTE")
                {
                     sql = "select p.cpf from Cliente c inner join pessoa p on p.cpf=c.FK_ClienteCpf";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    //    Funcionario funcionario = new Funcionario();
                    Pessoa pessoa = new Pessoa();
                    //acessando os valores das colunas do resultado
                    //funcionario.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    pessoa.Cpf= DbReader.GetString(DbReader.GetOrdinal("cpf"));


                    retorno.Add(pessoa);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }

        
    }
}

