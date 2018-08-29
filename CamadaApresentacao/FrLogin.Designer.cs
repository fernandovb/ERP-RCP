namespace CamadaApresentacao
{
    partial class LOG00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG00));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbServer
            // 
            this.LbServer.Location = new System.Drawing.Point(12, 186);
            this.LbServer.Name = "LbServer";
            this.LbServer.Size = new System.Drawing.Size(59, 18);
            this.LbServer.TabIndex = 0;
            this.LbServer.Text = "Servidor";
            this.LbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbServer
            // 
            this.TbServer.Location = new System.Drawing.Point(77, 184);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(103, 20);
            this.TbServer.TabIndex = 1;
            this.TbServer.Text = "localhost";
            this.TbServer.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // TbDatabase
            // 
            this.TbDatabase.Location = new System.Drawing.Point(77, 210);
            this.TbDatabase.Name = "TbDatabase";
            this.TbDatabase.Size = new System.Drawing.Size(103, 20);
            this.TbDatabase.TabIndex = 3;
            this.TbDatabase.Text = "erp_rcp";
            this.TbDatabase.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // LbDatabase
            // 
            this.LbDatabase.Location = new System.Drawing.Point(12, 212);
            this.LbDatabase.Name = "LbDatabase";
            this.LbDatabase.Size = new System.Drawing.Size(59, 18);
            this.LbDatabase.TabIndex = 2;
            this.LbDatabase.Text = "Database";
            this.LbDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(77, 236);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(103, 20);
            this.TbUser.TabIndex = 5;
            this.TbUser.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // LbUser
            // 
            this.LbUser.Location = new System.Drawing.Point(12, 238);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(59, 18);
            this.LbUser.TabIndex = 4;
            this.LbUser.Text = "Usuário";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbSenha
            // 
            this.LbSenha.Location = new System.Drawing.Point(12, 264);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(59, 18);
            this.LbSenha.TabIndex = 6;
            this.LbSenha.Text = "Senha";
            this.LbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbEmpresa
            // 
            this.LbEmpresa.Location = new System.Drawing.Point(12, 290);
            this.LbEmpresa.Name = "LbEmpresa";
            this.LbEmpresa.Size = new System.Drawing.Size(59, 18);
            this.LbEmpresa.TabIndex = 8;
            this.LbEmpresa.Text = "Empresa";
            this.LbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbSenha
            // 
            this.TbSenha.Location = new System.Drawing.Point(77, 262);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.PasswordChar = '*';
            this.TbSenha.Size = new System.Drawing.Size(103, 20);
            this.TbSenha.TabIndex = 7;
            this.TbSenha.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // BtLogin
            // 
            this.BtLogin.Enabled = false;
            this.BtLogin.Location = new System.Drawing.Point(8, 322);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(82, 23);
            this.BtLogin.TabIndex = 10;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(98, 322);
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
            this.LbMensagem.Location = new System.Drawing.Point(0, 358);
            this.LbMensagem.Name = "LbMensagem";
            this.LbMensagem.Size = new System.Drawing.Size(192, 111);
            this.LbMensagem.TabIndex = 12;
            // 
            // TbEmpresa
            // 
            this.TbEmpresa.Location = new System.Drawing.Point(77, 288);
            this.TbEmpresa.Mask = "0000";
            this.TbEmpresa.Name = "TbEmpresa";
            this.TbEmpresa.Size = new System.Drawing.Size(103, 20);
            this.TbEmpresa.TabIndex = 9;
            this.TbEmpresa.ValidatingType = typeof(int);
            this.TbEmpresa.Leave += new System.EventHandler(this.TbServer_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(2, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bem vindo ao RCP. Entre com as suas credenciais para utilizar o sistema.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LOG00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 469);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LOG00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}