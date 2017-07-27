using Biblioteca;
using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pessoa
{
   public class DadosPessoa : ConexaoSqlServer, InterfacePessoa
    {
        public void Insert(Pessoa pessoa)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "insert into Pessoa (nome,telefone,cpf) values(@nome,@telefone,@cpf)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = pessoa.Nome;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = pessoa.Telefone;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = pessoa.Cpf;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public void Update(Pessoa pessoa)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update Pessoa set nome = @nome, telefone = @telefone , cpf = @cpf, where cpf = @cpf2";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = pessoa.Nome;

                cmd.Parameters.Add("@telefone", SqlDbType.VarChar);
                cmd.Parameters["@telefone"].Value = pessoa.Telefone;

                cmd.Parameters.Add("@cpf2", SqlDbType.VarChar);
                cmd.Parameters["@cpf2"].Value = pessoa.Cpf;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public void Delete(Pessoa pessoa)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from Pessoa where cpf = @cpf";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = pessoa.Cpf;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e remover " + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Pessoa pessoa)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT nome, telefone, cpf FROM Pessoa where cpf = @cpf";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = pessoa.Cpf;
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
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
        public List<Pessoa> Select(Pessoa filtro)
        {
            List<Pessoa> retorno = new List<Pessoa>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT nome FROM Pessoa where nome = @nome ";
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    sql += " and nome like '%" + filtro.Nome.Trim() + "%'";
                }


                //se foi passada um cpf válido, este cpf entrará como critério de filtro
                if (filtro.Cpf != null && filtro.Cpf.Trim().Equals("") == false)
                {
                    sql += " and cpf = @cpf";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada um telefone válido, esta telefone entrará como critério de filtro
                if (filtro.Telefone !=null && filtro.Telefone.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@telefone", SqlDbType.VarBinary);
                    cmd.Parameters["@telefone"].Value = filtro.Telefone;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                /*if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = filtro.Nome;

                }*/
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    //acessando os valores das colunas do resultado
                    //pessoa.Matricula = DbReader.GetInt32(DbReader.GetOrdinal("matricula"));
                    pessoa.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    pessoa.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    pessoa.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
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
