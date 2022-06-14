namespace Controle_de_Contas
{
    partial class EntradasESaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasESaidas));
            this.CaixaPrincipal = new System.Windows.Forms.Panel();
            this.lblTelaInicial = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbbxCartao = new System.Windows.Forms.ComboBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.cbbxContas = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.btnAdicionarEntrada = new System.Windows.Forms.Button();
            this.btnAdicionarGastos = new System.Windows.Forms.Button();
            this.CaixaPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaixaPrincipal
            // 
            this.CaixaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CaixaPrincipal.Controls.Add(this.lblTelaInicial);
            this.CaixaPrincipal.Controls.Add(this.pnlIcon);
            this.CaixaPrincipal.Controls.Add(this.panel2);
            this.CaixaPrincipal.Controls.Add(this.lblDescricao);
            this.CaixaPrincipal.Controls.Add(this.panel1);
            this.CaixaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaixaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.CaixaPrincipal.Name = "CaixaPrincipal";
            this.CaixaPrincipal.Size = new System.Drawing.Size(600, 530);
            this.CaixaPrincipal.TabIndex = 0;
            // 
            // lblTelaInicial
            // 
            this.lblTelaInicial.AutoSize = true;
            this.lblTelaInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblTelaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTelaInicial.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaInicial.ForeColor = System.Drawing.Color.White;
            this.lblTelaInicial.Location = new System.Drawing.Point(57, 504);
            this.lblTelaInicial.Name = "lblTelaInicial";
            this.lblTelaInicial.Size = new System.Drawing.Size(92, 23);
            this.lblTelaInicial.TabIndex = 5;
            this.lblTelaInicial.Text = "Tela Inicial";
            this.lblTelaInicial.Click += new System.EventHandler(this.lblTelaInicial_Click);
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIcon.BackgroundImage")));
            this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlIcon.Location = new System.Drawing.Point(12, 494);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(39, 33);
            this.pnlIcon.TabIndex = 4;
            this.pnlIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIcon_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdicionarGastos);
            this.panel2.Controls.Add(this.lblSaidas);
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cbbxCartao);
            this.panel2.Controls.Add(this.lblCartao);
            this.panel2.Controls.Add(this.txtCategoria);
            this.panel2.Controls.Add(this.lblValorGasto);
            this.panel2.Controls.Add(this.txtValorGasto);
            this.panel2.Location = new System.Drawing.Point(296, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 437);
            this.panel2.TabIndex = 3;
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblSaidas.ForeColor = System.Drawing.Color.White;
            this.lblSaidas.Location = new System.Drawing.Point(98, 9);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(77, 29);
            this.lblSaidas.TabIndex = 2;
            this.lblSaidas.Text = "Saidas";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(3, 159);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 23);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbbxCartao
            // 
            this.cbbxCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbxCartao.FormattingEnabled = true;
            this.cbbxCartao.Items.AddRange(new object[] {
            "Itau",
            "Nubank",
            "Original",
            "Caixa"});
            this.cbbxCartao.Location = new System.Drawing.Point(103, 113);
            this.cbbxCartao.Name = "cbbxCartao";
            this.cbbxCartao.Size = new System.Drawing.Size(121, 28);
            this.cbbxCartao.TabIndex = 4;
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.ForeColor = System.Drawing.Color.White;
            this.lblCartao.Location = new System.Drawing.Point(3, 113);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(67, 23);
            this.lblCartao.TabIndex = 2;
            this.lblCartao.Text = "Cartão:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategoria.Location = new System.Drawing.Point(103, 157);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(159, 26);
            this.txtCategoria.TabIndex = 3;
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.AutoSize = true;
            this.lblValorGasto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGasto.ForeColor = System.Drawing.Color.White;
            this.lblValorGasto.Location = new System.Drawing.Point(3, 65);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(56, 23);
            this.lblValorGasto.TabIndex = 2;
            this.lblValorGasto.Text = "Valor:";
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorGasto.Location = new System.Drawing.Point(103, 63);
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(121, 26);
            this.txtValorGasto.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.lblDescricao.Location = new System.Drawing.Point(127, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(299, 39);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Entradas e Saidas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdicionarEntrada);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblOrigem);
            this.panel1.Controls.Add(this.cbbxContas);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.txtOrigem);
            this.panel1.Controls.Add(this.txtValorEntrada);
            this.panel1.Controls.Add(this.lblConta);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblEntradas);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 437);
            this.panel1.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(16, 204);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 23);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.ForeColor = System.Drawing.Color.White;
            this.lblOrigem.Location = new System.Drawing.Point(16, 159);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(74, 23);
            this.lblOrigem.TabIndex = 5;
            this.lblOrigem.Text = "Origem:";
            // 
            // cbbxContas
            // 
            this.cbbxContas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxContas.FormattingEnabled = true;
            this.cbbxContas.Items.AddRange(new object[] {
            "Itau",
            "Nubank",
            "Original",
            "Caixa"});
            this.cbbxContas.Location = new System.Drawing.Point(95, 113);
            this.cbbxContas.Name = "cbbxContas";
            this.cbbxContas.Size = new System.Drawing.Size(121, 27);
            this.cbbxContas.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(95, 202);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(121, 27);
            this.txtData.TabIndex = 3;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Location = new System.Drawing.Point(95, 157);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(121, 27);
            this.txtOrigem.TabIndex = 3;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrada.Location = new System.Drawing.Point(95, 63);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(121, 27);
            this.txtValorEntrada.TabIndex = 3;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.Color.White;
            this.lblConta.Location = new System.Drawing.Point(16, 113);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(61, 23);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(16, 65);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 23);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.Color.White;
            this.lblEntradas.Location = new System.Drawing.Point(90, 9);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(101, 29);
            this.lblEntradas.TabIndex = 1;
            this.lblEntradas.Text = "Entradas";
            // 
            // btnAdicionarEntrada
            // 
            this.btnAdicionarEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEntrada.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnAdicionarEntrada.Location = new System.Drawing.Point(95, 378);
            this.btnAdicionarEntrada.Name = "btnAdicionarEntrada";
            this.btnAdicionarEntrada.Size = new System.Drawing.Size(106, 42);
            this.btnAdicionarEntrada.TabIndex = 6;
            this.btnAdicionarEntrada.Text = "Adicionar";
            this.btnAdicionarEntrada.UseVisualStyleBackColor = false;
            this.btnAdicionarEntrada.Click += new System.EventHandler(this.btnAdicionarEntrada_Click);
            // 
            // btnAdicionarGastos
            // 
            this.btnAdicionarGastos.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarGastos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnAdicionarGastos.Location = new System.Drawing.Point(103, 378);
            this.btnAdicionarGastos.Name = "btnAdicionarGastos";
            this.btnAdicionarGastos.Size = new System.Drawing.Size(106, 42);
            this.btnAdicionarGastos.TabIndex = 6;
            this.btnAdicionarGastos.Text = "Adicionar";
            this.btnAdicionarGastos.UseVisualStyleBackColor = false;
            this.btnAdicionarGastos.Click += new System.EventHandler(this.btnAdicionarGastos_Click);
            // 
            // EntradasESaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 530);
            this.Controls.Add(this.CaixaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EntradasESaidas";
            this.ShowIcon = false;
            this.Text = "Entradas e Saidas";
            this.CaixaPrincipal.ResumeLayout(false);
            this.CaixaPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CaixaPrincipal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.ComboBox cbbxContas;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblTelaInicial;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbbxCartao;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblValorGasto;
        private System.Windows.Forms.TextBox txtValorGasto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Button btnAdicionarEntrada;
        private System.Windows.Forms.Button btnAdicionarGastos;
    }
}