using System;
using Biblioteca.comanda;
using Biblioteca.produto;
using Biblioteca.item;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.item
{
   public class DadosItem : ConexaoSqlServer
    {
        public void InserirProdutosItem(Item item)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                foreach (Produto p in item.produtos)
                {
                    string sql = "insert into Produto (nome, descricao, preco, quantidade)";
                    sql += "values(@nome, @descricao, @preco, @quantidade)";
                    //instrucao a ser executada
                    SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = p.Nome;

                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                    cmd.Parameters["@descricao"].Value = p.Descricao;

                    cmd.Parameters.Add("@preco", SqlDbType.Float);
                    cmd.Parameters["@preco"].Value = p.Preco;

                    cmd.Parameters.Add("@quantidade", SqlDbType.Int);
                    cmd.Parameters["@quantidade"].Value = p.Quantidade;

                    //executando a instrucao 
                    cmd.ExecuteNonQuery();
                    //liberando a memoria 
                    cmd.Dispose();
                }


                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }


        }

        public List<Produto> SelectProdutoPorItem(Produto produto)
        {
            List<Produto> retorno = new List<Produto>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "select produto.produtoId, produto.nome, produto.descricao, produto.preco, produto.quantidade";
                sql += " from produto ";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);


                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Produto p = new Produto();
                    //acessando os valores das colunas do resultado
                    p.ProdutoId = DbReader.GetInt32(DbReader.GetOrdinal("produtoId"));
                    p.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    p.Descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    //Double teste = DbReader.GetFloat(3);
                    p.Preco = DbReader.GetDouble(DbReader.GetOrdinal("preco"));
                    //p.Preco = DbReader.GetFloat(Convert.ToInt32(DbReader.GetOrdinal("preco")));
                    //p.Preco = DbReader.GetFloat(3);
                    p.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("quantidade"));
                    retorno.Add(p);
                    
                }
                //fechando o leitor de resultados
                //DbReader.Close();
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
