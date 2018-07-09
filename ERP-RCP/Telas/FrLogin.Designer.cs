namespace ERP_RCP.Telas
{
    partial class FrLogin
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
            this.LbServer = new System.Windows.Forms.Label();
            this.TbServer = new System.Windows.Forms.TextBox();
            this.TbDatabase = new System.Windows.Forms.TextBox();
            this.LbDatabase = new System.Windows.Forms.Label();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbSenha = new System.Windows.Forms.Label();
            this.LbEmpresa = new System.Windows.Forms.Label();
            this.TbSenha = new System.Windows.Forms.MaskedTextBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.LbMensagem = new System.Windows.Forms.Label();
            this.TbEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LbServer
            // 
            this.LbServer.Location = new System.Drawing.Point(12, 14);
            this.LbServer.Name = "LbServer";
            this.LbServer.Size = new System.Drawing.Size(59, 18);
            this.LbServer.TabIndex = 0;
            this.LbServer.Text = "Servidor";
            this.LbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbServer
            // 
            this.TbServer.Location = new System.Drawing.Point(77, 12);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(103, 20);
            this.TbServer.TabIndex = 1;
            this.TbServer.Text = "localhost";
            this.TbServer.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // TbDatabase
            // 
            this.TbDatabase.Location = new System.Drawing.Point(77, 38);
            this.TbDatabase.Name = "TbDatabase";
            this.TbDatabase.Size = new System.Drawing.Size(103, 20);
            this.TbDatabase.TabIndex = 3;
            this.TbDatabase.Text = "erp_rcp";
            this.TbDatabase.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // LbDatabase
            // 
            this.LbDatabase.Location = new System.Drawing.Point(12, 40);
            this.LbDatabase.Name = "LbDatabase";
            this.LbDatabase.Size = new System.Drawing.Size(59, 18);
            this.LbDatabase.TabIndex = 2;
            this.LbDatabase.Text = "Database";
            this.LbDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(77, 64);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(103, 20);
            this.TbUser.TabIndex = 5;
            this.TbUser.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // LbUser
            // 
            this.LbUser.Location = new System.Drawing.Point(12, 66);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(59, 18);
            this.LbUser.TabIndex = 4;
            this.LbUser.Text = "Usuário";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbSenha
            // 
            this.LbSenha.Location = new System.Drawing.Point(12, 92);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(59, 18);
            this.LbSenha.TabIndex = 6;
            this.LbSenha.Text = "Senha";
            this.LbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbEmpresa
            // 
            this.LbEmpresa.Location = new System.Drawing.Point(12, 118);
            this.LbEmpresa.Name = "LbEmpresa";
            this.LbEmpresa.Size = new System.Drawing.Size(59, 18);
            this.LbEmpresa.TabIndex = 8;
            this.LbEmpresa.Text = "Empresa";
            this.LbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbSenha
            // 
            this.TbSenha.Location = new System.Drawing.Point(77, 90);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.PasswordChar = '*';
            this.TbSenha.Size = new System.Drawing.Size(103, 20);
            this.TbSenha.TabIndex = 7;
            this.TbSenha.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // BtLogin
            // 
            this.BtLogin.Enabled = false;
            this.BtLogin.Location = new System.Drawing.Point(8, 150);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(82, 23);
            this.BtLogin.TabIndex = 10;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(98, 150);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(82, 23);
            this.BtCancel.TabIndex = 11;
            this.BtCancel.Text = "Encerrar";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // LbMensagem
            // 
            this.LbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbMensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbMensagem.Location = new System.Drawing.Point(0, 180);
            this.LbMensagem.Name = "LbMensagem";
            this.LbMensagem.Size = new System.Drawing.Size(192, 111);
            this.LbMensagem.TabIndex = 12;
            // 
            // TbEmpresa
            // 
            this.TbEmpresa.Location = new System.Drawing.Point(77, 116);
            this.TbEmpresa.Mask = "0000";
            this.TbEmpresa.Name = "TbEmpresa";
            this.TbEmpresa.Size = new System.Drawing.Size(103, 20);
            this.TbEmpresa.TabIndex = 9;
            this.TbEmpresa.ValidatingType = typeof(int);
            this.TbEmpresa.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 291);
            this.Controls.Add(this.TbEmpresa);
            this.Controls.Add(this.LbMensagem);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TbSenha);
            this.Controls.Add(this.LbEmpresa);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.TbDatabase);
            this.Controls.Add(this.LbDatabase);
            this.Controls.Add(this.TbServer);
            this.Controls.Add(this.LbServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbServer;
        private System.Windows.Forms.TextBox TbServer;
        private System.Windows.Forms.TextBox TbDatabase;
        private System.Windows.Forms.Label LbDatabase;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.Label LbEmpresa;
        private System.Windows.Forms.MaskedTextBox TbSenha;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Label LbMensagem;
        private System.Windows.Forms.MaskedTextBox TbEmpresa;
    }
}