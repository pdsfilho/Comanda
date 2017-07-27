namespace AplicacaoForm
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btRegPedido = new System.Windows.Forms.Button();
            this.btFecharComanda = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btFecharComanda);
            this.groupBox2.Controls.Add(this.btRegPedido);
            this.groupBox2.Controls.Add(this.btProduto);
            this.groupBox2.Controls.Add(this.btCliente);
            this.groupBox2.Controls.Add(this.btFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(209, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastro";
            this.toolTip1.SetToolTip(this.button1, "Cadastro");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.Location = new System.Drawing.Point(37, 41);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(75, 53);
            this.btFuncionario.TabIndex = 1;
            this.btFuncionario.Text = "Funcionario";
            this.toolTip1.SetToolTip(this.btFuncionario, "Cadastrar Funcionario");
            this.btFuncionario.UseVisualStyleBackColor = true;
            this.btFuncionario.Visible = false;
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(182, 41);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(75, 53);
            this.btCliente.TabIndex = 2;
            this.btCliente.Text = "Cliente";
            this.toolTip1.SetToolTip(this.btCliente, "Cadastrar Cliente");
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Visible = false;
            // 
            // btProduto
            // 
            this.btProduto.Location = new System.Drawing.Point(322, 41);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(75, 53);
            this.btProduto.TabIndex = 3;
            this.btProduto.Text = "Produto";
            this.toolTip1.SetToolTip(this.btProduto, "Cadastrar Produto");
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(47, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 53);
            this.button5.TabIndex = 1;
            this.button5.Text = "Consumos";
            this.toolTip1.SetToolTip(this.button5, "Consumos");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btRegPedido
            // 
            this.btRegPedido.Location = new System.Drawing.Point(37, 123);
            this.btRegPedido.Name = "btRegPedido";
            this.btRegPedido.Size = new System.Drawing.Size(75, 53);
            this.btRegPedido.TabIndex = 2;
            this.btRegPedido.Text = "Registrar Pedidos";
            this.toolTip1.SetToolTip(this.btRegPedido, "Gerar Comanda");
            this.btRegPedido.UseVisualStyleBackColor = true;
            this.btRegPedido.Visible = false;
            this.btRegPedido.Click += new System.EventHandler(this.btRegPedido_Click);
            // 
            // btFecharComanda
            // 
            this.btFecharComanda.Location = new System.Drawing.Point(182, 123);
            this.btFecharComanda.Name = "btFecharComanda";
            this.btFecharComanda.Size = new System.Drawing.Size(75, 53);
            this.btFecharComanda.TabIndex = 4;
            this.btFecharComanda.Text = "Fechar Comanda";
            this.toolTip1.SetToolTip(this.btFecharComanda, "Finalizar Consumos");
            this.btFecharComanda.UseVisualStyleBackColor = true;
            this.btFecharComanda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btFecharComanda;
        private System.Windows.Forms.Button btRegPedido;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}