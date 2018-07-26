namespace CamadaApresentacao
{
    partial class RCP00
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCP00));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Favoritos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PM01 - Inclusão de Pessoas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PM02 - Alterar Pessoas");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ATV01 - Incluir atividade");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ATV02 - Modificar atividade");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ATV03 - Consultar atividade");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dados Básicos", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Menu RCP", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode7});
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Separador1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SslEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.Separador2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MiArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SlComando = new System.Windows.Forms.ToolStripLabel();
            this.StbComando = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ScMenu = new System.Windows.Forms.SplitContainer();
            this.TvMenu = new System.Windows.Forms.TreeView();
            this.LbDescMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScMenu)).BeginInit();
            this.ScMenu.Panel1.SuspendLayout();
            this.ScMenu.Panel2.SuspendLayout();
            this.ScMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SslUser,
            this.Separador1,
            this.toolStripStatusLabel2,
            this.SslEmpresa,
            this.Separador2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // SslUser
            // 
            this.SslUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SslUser.Name = "SslUser";
            this.SslUser.Size = new System.Drawing.Size(49, 17);
            this.SslUser.Text = "Usuário";
            // 
            // Separador1
            // 
            this.Separador1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Separador1.Name = "Separador1";
            this.Separador1.Size = new System.Drawing.Size(10, 17);
            this.Separador1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel2.Text = "Empresa:";
            // 
            // SslEmpresa
            // 
            this.SslEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SslEmpresa.Name = "SslEmpresa";
            this.SslEmpresa.Size = new System.Drawing.Size(35, 17);
            this.SslEmpresa.Text = "0000";
            // 
            // Separador2
            // 
            this.Separador2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Separador2.Name = "Separador2";
            this.Separador2.Size = new System.Drawing.Size(10, 17);
            this.Separador2.Text = "|";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MiArquivo
            // 
            this.MiArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.MiArquivo.Name = "MiArquivo";
            this.MiArquivo.Size = new System.Drawing.Size(60, 20);
            this.MiArquivo.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlComando,
            this.StbComando,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SlComando
            // 
            this.SlComando.Name = "SlComando";
            this.SlComando.Size = new System.Drawing.Size(63, 22);
            this.SlComando.Text = "Comando:";
            // 
            // StbComando
            // 
            this.StbComando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StbComando.Name = "StbComando";
            this.StbComando.Size = new System.Drawing.Size(120, 25);
            this.StbComando.Leave += new System.EventHandler(this.StbComando_Leave);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ScMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 379);
            this.splitContainer1.SplitterDistance = 511;
            this.splitContainer1.TabIndex = 3;
            // 
            // ScMenu
            // 
            this.ScMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScMenu.Location = new System.Drawing.Point(0, 0);
            this.ScMenu.Name = "ScMenu";
            this.ScMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScMenu.Panel1
            // 
            this.ScMenu.Panel1.Controls.Add(this.TvMenu);
            // 
            // ScMenu.Panel2
            // 
            this.ScMenu.Panel2.Controls.Add(this.LbDescMenu);
            this.ScMenu.Size = new System.Drawing.Size(511, 379);
            this.ScMenu.SplitterDistance = 310;
            this.ScMenu.TabIndex = 0;
            // 
            // TvMenu
            // 
            this.TvMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvMenu.ItemHeight = 18;
            this.TvMenu.Location = new System.Drawing.Point(0, 0);
            this.TvMenu.Name = "TvMenu";
            treeNode1.Name = "Favoritos";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Favoritos";
            treeNode2.Name = "Incluir Pessoas";
            treeNode2.Tag = "PM01";
            treeNode2.Text = "PM01 - Inclusão de Pessoas";
            treeNode3.Name = "Alterar Pessoas";
            treeNode3.Tag = "PM02";
            treeNode3.Text = "PM02 - Alterar Pessoas";
            treeNode4.Name = "Incluir atividade";
            treeNode4.Tag = "ATV01";
            treeNode4.Text = "ATV01 - Incluir atividade";
            treeNode5.Name = "Modificar atividade";
            treeNode5.Tag = "ATV02";
            treeNode5.Text = "ATV02 - Modificar atividade";
            treeNode6.Name = "Consultar atividade";
            treeNode6.Tag = "ATV03";
            treeNode6.Text = "ATV03 - Consultar atividade";
            treeNode7.Name = "Dados Básicos";
            treeNode7.Tag = "DBA";
            treeNode7.Text = "Dados Básicos";
            treeNode8.Name = "Menu RCP";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "Menu RCP";
            this.TvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode8});
            this.TvMenu.ShowNodeToolTips = true;
            this.TvMenu.Size = new System.Drawing.Size(511, 310);
            this.TvMenu.TabIndex = 0;
            this.TvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvMenu_NodeMouseDoubleClick);
            // 
            // LbDescMenu
            // 
            this.LbDescMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbDescMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbDescMenu.Location = new System.Drawing.Point(0, 0);
            this.LbDescMenu.Name = "LbDescMenu";
            this.LbDescMenu.Size = new System.Drawing.Size(511, 65);
            this.LbDescMenu.TabIndex = 0;
            this.LbDescMenu.Text = "Texto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 379);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RCP00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RCP00";
            this.Text = "ERP-RCP - Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrMenu_FormClosing);
            this.Shown += new System.EventHandler(this.FrMenu_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ScMenu.Panel1.ResumeLayout(false);
            this.ScMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScMenu)).EndInit();
            this.ScMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SlComando;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SslUser;
        private System.Windows.Forms.ToolStripStatusLabel Separador1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel SslEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel Separador2;
        private System.Windows.Forms.ToolStripMenuItem MiArquivo;
        private System.Windows.Forms.ToolStripTextBox StbComando;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer ScMenu;
        private System.Windows.Forms.TreeView TvMenu;
        private System.Windows.Forms.Label LbDescMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

