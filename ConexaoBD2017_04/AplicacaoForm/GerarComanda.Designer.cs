namespace Biblioteca
{
    partial class GerarComanda
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
            this.btFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPaga = new System.Windows.Forms.RadioButton();
            this.rbCancelada = new System.Windows.Forms.RadioButton();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Enabled = false;
            this.btFechar.Location = new System.Drawing.Point(667, 274);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(141, 46);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar Comanda";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPaga);
            this.groupBox1.Controls.Add(this.rbCancelada);
            this.groupBox1.Controls.Add(this.rbPendente);
            this.groupBox1.Location = new System.Drawing.Point(7, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Comanda";
            // 
            // rbPaga
            // 
            this.rbPaga.AutoSize = true;
            this.rbPaga.Enabled = false;
            this.rbPaga.Location = new System.Drawing.Point(4, 68);
            this.rbPaga.Name = "rbPaga";
            this.rbPaga.Size = new System.Drawing.Size(50, 17);
            this.rbPaga.TabIndex = 2;
            this.rbPaga.TabStop = true;
            this.rbPaga.Text = "Paga";
            this.rbPaga.UseVisualStyleBackColor = true;
            // 
            // rbCancelada
            // 
            this.rbCancelada.AutoSize = true;
            this.rbCancelada.Enabled = false;
            this.rbCancelada.Location = new System.Drawing.Point(4, 44);
            this.rbCancelada.Name = "rbCancelada";
            this.rbCancelada.Size = new System.Drawing.Size(76, 17);
            this.rbCancelada.TabIndex = 1;
            this.rbCancelada.TabStop = true;
            this.rbCancelada.Text = "Cancelada";
            this.rbCancelada.UseVisualStyleBackColor = true;
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Enabled = false;
            this.rbPendente.Location = new System.Drawing.Point(4, 20);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(71, 17);
            this.rbPendente.TabIndex = 0;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.Enabled = false;
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(105, 26);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(81, 21);
            this.comboFuncionario.TabIndex = 7;
            this.comboFuncionario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboFuncionario.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.Enabled = false;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(105, 63);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(81, 21);
            this.comboCliente.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(588, 202);
            this.dataGridView1.TabIndex = 10;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Location = new System.Drawing.Point(524, 274);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(122, 46);
            this.btAtualizar.TabIndex = 12;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total.:R$ 0.00";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(350, 242);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(133, 20);
            this.txtQuantidade.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Digite a Quantidade:";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(261, 274);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(106, 46);
            this.btNovo.TabIndex = 16;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(393, 274);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(106, 46);
            this.btEditar.TabIndex = 17;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.button4_Click);
            // 
            // GerarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 339);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.comboFuncionario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFechar);
            this.Name = "GerarComanda";
            this.Text = "Comanda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPaga;
        private System.Windows.Forms.RadioButton rbCancelada;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
    }
}