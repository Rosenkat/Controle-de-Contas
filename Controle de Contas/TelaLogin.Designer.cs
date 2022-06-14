namespace Controle_de_Contas
{
    partial class TelaLogin
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
            this.CaixaPrincipal = new System.Windows.Forms.Panel();
            this.ExibeSenha = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.CaixaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaixaPrincipal
            // 
            this.CaixaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CaixaPrincipal.Controls.Add(this.ExibeSenha);
            this.CaixaPrincipal.Controls.Add(this.btnSair);
            this.CaixaPrincipal.Controls.Add(this.btnAcessar);
            this.CaixaPrincipal.Controls.Add(this.txtSenha);
            this.CaixaPrincipal.Controls.Add(this.txtLogin);
            this.CaixaPrincipal.Controls.Add(this.lblSenha);
            this.CaixaPrincipal.Controls.Add(this.lblLogin);
            this.CaixaPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.CaixaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaixaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.CaixaPrincipal.Name = "CaixaPrincipal";
            this.CaixaPrincipal.Size = new System.Drawing.Size(506, 483);
            this.CaixaPrincipal.TabIndex = 0;
            // 
            // ExibeSenha
            // 
            this.ExibeSenha.AutoSize = true;
            this.ExibeSenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExibeSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExibeSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExibeSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExibeSenha.ForeColor = System.Drawing.Color.White;
            this.ExibeSenha.Location = new System.Drawing.Point(226, 255);
            this.ExibeSenha.Name = "ExibeSenha";
            this.ExibeSenha.Size = new System.Drawing.Size(107, 23);
            this.ExibeSenha.TabIndex = 5;
            this.ExibeSenha.Text = "Exibir senha";
            this.ExibeSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExibeSenha.UseVisualStyleBackColor = true;
            this.ExibeSenha.CheckedChanged += new System.EventHandler(this.ExibeSenha_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(136)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnSair.Location = new System.Drawing.Point(199, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 34);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(136)))));
            this.btnAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(156)))));
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAcessar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.btnAcessar.Location = new System.Drawing.Point(199, 297);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(109, 34);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.txtSenha.Location = new System.Drawing.Point(177, 217);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(156, 32);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(88)))));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.txtLogin.Location = new System.Drawing.Point(177, 123);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(156, 32);
            this.txtLogin.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.lblSenha.Location = new System.Drawing.Point(171, 178);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(102, 40);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.lblLogin.Location = new System.Drawing.Point(171, 84);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(91, 40);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // TelaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.CaixaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Acesso";
            this.CaixaPrincipal.ResumeLayout(false);
            this.CaixaPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CaixaPrincipal;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox ExibeSenha;
    }
}

