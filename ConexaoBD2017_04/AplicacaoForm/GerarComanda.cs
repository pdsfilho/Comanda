using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.comanda;
using Biblioteca;
using Biblioteca.item;
using Biblioteca.cliente;
using Biblioteca.funcionario;
using Biblioteca.produto;
using System.Xml;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Biblioteca.pessoa;

namespace Biblioteca
{
    public partial class GerarComanda : Form
    {
        private Item item;
        
             
        public static string mensagemCliente = "em espera";
        private string nomeArquivo;
        private List<Produto> listaProdutosLocais;
        
        private double acumulador = 0;
        private List<string> conteudoIni;
        //lendo arquivo de configuração ini aonde todos os paramtros sao usados
        private void LerArquivoIni()
        {
            
            //criando caminho do arquivo ini caso não exista caminho esse caminho do arquivo fica aonde estáo executavel do projeto
            //FileInfo arquivoIniExistente = new FileInfo(Application.StartupPath + "\\arquivo.ini");
            /*caso o arquivo ini fisico não exista o arquivo será criado vazio e 
            depois preenchido com as configurações de uso com o conteudoIni carregado pronto para ser usado pela aplicacao
             */
            if(File.Exists(Application.StartupPath + "\\arquivo.ini")==false)
            {
                
                Stream arquivoIniCriadoCarregando = new FileStream(Application.StartupPath + "\\arquivo.ini", FileMode.Append, FileAccess.Write);
                StreamWriter escreverArquivoIniCriadoCarregado = new StreamWriter(arquivoIniCriadoCarregando, Encoding.GetEncoding("iso-8859-1"));
                escreverArquivoIniCriadoCarregado.WriteLine("------------arquivo de configuracao-----------------------");
                escreverArquivoIniCriadoCarregado.WriteLine("ip servidor");
                escreverArquivoIniCriadoCarregado.WriteLine("192.168.1.116");
                escreverArquivoIniCriadoCarregado.WriteLine("ip cliente");
                escreverArquivoIniCriadoCarregado.WriteLine("192.168.1.116");
                escreverArquivoIniCriadoCarregado.WriteLine("pasta para ler xml");
                escreverArquivoIniCriadoCarregado.WriteLine(@"c:\webservice");
                escreverArquivoIniCriadoCarregado.WriteLine("pasta para arquivos xml lidos");
                escreverArquivoIniCriadoCarregado.WriteLine(@"c:\webservice\arquivos_xml_lidos");
                escreverArquivoIniCriadoCarregado.WriteLine("tempo de checagem web service");
                escreverArquivoIniCriadoCarregado.WriteLine("1000");
                escreverArquivoIniCriadoCarregado.WriteLine("--------------fim da configuração--------------------------");
                arquivoIniCriadoCarregando.Flush();
                escreverArquivoIniCriadoCarregado.Dispose();
                arquivoIniCriadoCarregando.Dispose();                
            }
            if (conteudoIni.Count == 0)
            {
                Stream arquivoIni = new FileStream(Application.StartupPath + "\\arquivo.ini", FileMode.Open, FileAccess.Read);
                StreamReader lendo = new StreamReader(arquivoIni, Encoding.GetEncoding("iso-8859-1"));
                string linha = lendo.ReadLine();
                while (linha != null)
                {
                    conteudoIni.Add(linha);
                    linha = lendo.ReadLine();
                }
                arquivoIni.Flush();
                lendo.Dispose();
                arquivoIni.Dispose();
            }
                                    
        }
        //aqui vão ser carregados cliente,funcionario, Produto na tela de comanda com as configurações fornecidas pelo arquivo ini
        public GerarComanda()
        {
            InitializeComponent();
            conteudoIni = new List<string>();
            LerArquivoIni();
            CarregarCombos();
            CarregarProdutos();                      
        }
        //carregando produtos aqui nesse         
        private void CarregarProdutos()
        {
            try
            {
                DadosItem dados;
                dados = new DadosItem();
                item = new Item();
                item.produtos = dados.SelectProdutoPorItem(new Produto());
                
                listaProdutosLocais = new List<Produto>();
                
                foreach (Produto p in item.produtos )
                {
                    
                    p.Quantidade = 0;
                    listaProdutosLocais.Add(p);
                }
                //DataSource preisa ser um array para receber info na tela.
                dataGridView1.DataSource = listaProdutosLocais;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //aqui é a tela aonde serão passadas as informações da tela Comanda, para gerar Comanda e os itens da comanda. 
            if ((comboFuncionario.SelectedItem.ToString() != "") && (comboCliente.SelectedItem.ToString() != "")||(rbPendente.Checked)||(rbCancelada.Checked)||(rbPaga.Checked))
            {
                //caminho para salvar o arquivo xml lido no arquivo de configuração chamado arquivo ini
                nomeArquivo = conteudoIni[6] +"//"+ comboFuncionario.SelectedItem.ToString() + comboCliente.SelectedItem.ToString() + DateTime.Now.ToString().Replace(":", "").Replace("/", "") + ".xml";
                CriarXml(nomeArquivo);
                Cliente();
                MessageBox.Show("Arquivo Xml Gerado", "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Favor Verificar os campos: \n Código do Funcionário \n Código do Cliente \n Satus Comanda","Falta de Campos Obrigatórios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //enviar arquivos via socket
        private void Cliente()
        {                             
            try
            {
                string strEnderecoIP =conteudoIni[2];
                IPEndPoint ipEnd_cliente = new IPEndPoint(IPAddress.Parse(strEnderecoIP), 5656);
                Socket clientSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                string caminhoArquivo = "";
                nomeArquivo = nomeArquivo.Replace("\\", "/");
                while (nomeArquivo.IndexOf("/") > -1)
                {
                    caminhoArquivo += nomeArquivo.Substring(0, nomeArquivo.IndexOf("/") + 1);
                    nomeArquivo = nomeArquivo.Substring(nomeArquivo.IndexOf("/") + 1);
                }
                //informar o tamanho do XML pela rede
                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(nomeArquivo);
                if (nomeArquivoByte.Length > 5000 * 1024)
                {
                    mensagemCliente = "O tamanho do arquivo é maior que 5Mb, tente um arquivo menor.";
                    return;
                }
                string caminhoCompleto = caminhoArquivo + nomeArquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);
                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                clientSock_cliente.Connect(ipEnd_cliente);
                clientSock_cliente.Send(clientData, 0, clientData.Length, 0);
                clientSock_cliente.Close();
                mensagemCliente = "Arquivo [" + caminhoCompleto + "] transferido.";
            }
            catch (Exception ex)
            {
                mensagemCliente = ex.Message + " " + "\nFalha, pois o Servidor não esta atendendo....";
            }
        
    }
        
        //gerarxml
        private void CriarXml(string caminho)
        {
            try
            {
                //numeromesa+garson+cliente;
                //Encoding classe com metodo usado para escrita de caractere sespeciais em aquivos
                XmlTextWriter writer = new XmlTextWriter(@caminho, Encoding.GetEncoding("iso-8859-1"));

                //inicia o documento xml
                writer.WriteStartDocument();
                //escreve o elmento raiz
                writer.WriteStartElement("dados");
                //Escreve os sub-elementos
                writer.WriteElementString("CodigoFuncionario", comboFuncionario.SelectedItem.ToString());
                writer.WriteElementString("CodigoCliente", comboCliente.SelectedItem.ToString());
                if (rbPendente.Checked)
                {
                    writer.WriteElementString("StatusDaComanda", "1");
                }
                if (rbCancelada.Checked)
                {
                    writer.WriteElementString("StatusDaComanda", "2");
                }
                if(rbPaga.Checked)
                {
                    writer.WriteElementString("StatusDaComanda", "3");
                }
                writer.WriteElementString("ComandaTotal", label4.Text.Replace("Total.:R$ ","").Replace(",","."));
                foreach (Produto p in listaProdutosLocais)
                {
                    if (p.Quantidade != 0)
                    {
                        writer.WriteElementString("ProdutoDescricao", p.Descricao);
                        writer.WriteElementString("ProdutoNome", p.Nome);
                        writer.WriteElementString("ProdutoPreco", p.Preco.ToString().Replace(",", "."));
                        writer.WriteElementString("ProdutoQuantidade", p.Quantidade.ToString());
                    }
                }
                // encerra o elemento raiz
                writer.WriteEndElement();
                //Escreve o XML para o arquivo e fecha o objeto escritor
                writer.Close();
                
             //   MessageBox.Show("Arquivo XML gerado com sucesso.");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

          
        }
        private void CarregarCombos()
        {
            // MessageBox.Show("entrou no combobox");
            DadosFuncionario dadosFuncionario = new DadosFuncionario();
            foreach (Pessoa p in dadosFuncionario.Select("funcionario"))
            {
                comboFuncionario.Items.Add(p.Cpf);
            }
            foreach (Pessoa p in dadosFuncionario.Select("cliente"))
            {
                comboCliente.Items.Add(p.Cpf);
            }
        }
        private void CaculcularTotalComanda()
        {

        }
        //atualiza as informações do grid de quantidade
        private void button3_Click(object sender, EventArgs e)
        {

            //codigo indice linha do grid e indice do vetor
            int linha = dataGridView1.SelectedCells[0].RowIndex;
          

            double qtd=Convert.ToInt32(txtQuantidade.Text.Replace(",","."));
            if(qtd<0)
            {
                qtd = 0;
            }
            listaProdutosLocais[linha].Quantidade = Convert.ToInt32(qtd);
            
            
            
            dataGridView1.Refresh();
            dataGridView1.DataSource = listaProdutosLocais;
            dataGridView1.Refresh();
            List<double> total = new List<double>();
            foreach(Produto p in listaProdutosLocais)
            {                
                acumulador = p.Quantidade * p.Preco;
                total.Add(acumulador);
            }
            acumulador = 0;
            foreach(double p2 in total)
            {
                acumulador += p2;
            }

            label4.Text="Total.:R$ "+acumulador.ToString();

            


        }
        //tela bloqueada assim que o usuario clica no botão novo ou editar, essa opcao desbloqueia
        private void HabilitarOperacoes(bool habilita)
        {


            comboFuncionario.Enabled = habilita;
            comboCliente.Enabled = habilita;
            rbCancelada.Enabled = habilita;
            rbPaga.Enabled = habilita;
            rbPendente.Enabled = habilita;
            txtQuantidade.Enabled = habilita;
            btEditar.Enabled = habilita;
            btAtualizar.Enabled = habilita;
            btFechar.Enabled = habilita;
            
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitarOperacoes(true);
        }

        
        

        

        
    }
}
