using Biblioteca.item;
using Biblioteca.funcionario;
using Biblioteca.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.comanda
{
   public class DadosComanda : ConexaoSqlServer

    {
        #region segunda forma de passar parametros
        /*
                // Use AddWithValue to assign Demographics.
                // SQL Server will implicitly convert strings into XML.
                cmd.Parameters.AddWithValue("@demographics", demoXml);
                 */
        #endregion
        public void Insert(Comanda comanda)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "insert into comanda (FK_funcionarioId, FK_clienteId, data,status,total, FK_itemId) values(@FK_funcionarioId,@FK_clienteId,@data,@status,@total,@FK_itemId)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@FK_funcionarioId", SqlDbType.Int);
                cmd.Parameters["@FK_funcionarioId"].Value = comanda.Funcionario.FuncionarioId;

                cmd.Parameters.Add("FK_clienteId", SqlDbType.Int);
                cmd.Parameters["@FK_clienteId"].Value = comanda.Cliente.ClienteId;

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = comanda.Data;

                cmd.Parameters.Add("@status", SqlDbType.Int);
                cmd.Parameters["@status"].Value = comanda.Status;

                cmd.Parameters.Add("@total", SqlDbType.Float);
                cmd.Parameters["@total"].Value = comanda.Total;

                cmd.Parameters.Add("FK_itemId", SqlDbType.Int);
                cmd.Parameters["@FK_itemId"].Value = comanda.Item.ItemId;

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
        public List<Comanda> Select()
        {
            List<Comanda> retorno = new List<Comanda>();
            string sql;

            try
            {
                this.abrirConexao();
                //string sql;
                //instrucao a ser executada                                             
                sql = "select comandaId as codigo,FK_clienteId as cod_Cliente,FK_funcionarioId as codigo_Funcionario,data,status,total from Comanda";


                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    //    Funcionario funcionario = new Funcionario();
                    Comanda comanda = new Comanda();
                    //acessando os valores das colunas do resultado
                    //funcionario.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    comanda.ComandaId = DbReader.GetInt32(DbReader.GetOrdinal("codigo"));
                    comanda.Cliente.ClienteId = DbReader.GetInt32(DbReader.GetOrdinal("cod_Cliente"));
                    comanda.Funcionario.FuncionarioId = DbReader.GetInt32(DbReader.GetOrdinal("codigo_Funcionario"));
                    comanda.Data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    comanda.Status = DbReader.GetInt32(DbReader.GetOrdinal("status"));
                    comanda.Total = DbReader.GetDouble(DbReader.GetOrdinal("total"));



                    retorno.Add(comanda);
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


        public void Update(Comanda comanda)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "update comanda set comandaId = @comandaId ,FK_funcionarioId = @FK_funcionarioId, FK_clienteId = @FK_clienteId, data = @data, status = @status, total = @total where comandaId = @comandaId";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@FK_funcionarioId", SqlDbType.Int);
                cmd.Parameters["@FK_funcionarioId"].Value = comanda.Funcionario.FuncionarioId;

                cmd.Parameters.Add("FK_clienteId", SqlDbType.Int);
                cmd.Parameters["@FK_clienteId"].Value = comanda.Cliente.ClienteId;

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = comanda.Data;

                cmd.Parameters.Add("@status", SqlDbType.Int);
                cmd.Parameters["@status"].Value = comanda.Status;

                cmd.Parameters.Add("@total", SqlDbType.Float);
                cmd.Parameters["@total"].Value = comanda.Total;

                cmd.Parameters.Add("FK_itemId", SqlDbType.Int);
                cmd.Parameters["@FK_itemId"].Value = comanda.Item.ItemId;

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

        public void Delete(Comanda comanda)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "delete from comanda where FK_clienteId = @FK_clienteId";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@FK_clienteId", SqlDbType.Int);
                cmd.Parameters["@FK_clienteId"].Value = comanda.Cliente;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

    }
}

       
  