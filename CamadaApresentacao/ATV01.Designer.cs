namespace CamadaApresentacao
{
    partial class ATV01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATV01));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SslMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtGravar = new System.Windows.Forms.ToolStripButton();
            this.BtCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtAuditoria = new System.Windows.Forms.ToolStripButton();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.LbDescricao = new System.Windows.Forms.Label();
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.TbObservacao = new System.Windows.Forms.TextBox();
            this.LbObservacao = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SslMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(437, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SslMensagem
            // 
            this.SslMensagem.Name = "SslMensagem";
            this.SslMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtGravar,
            this.BtCancelar,
            this.BtSair,
            this.toolStripSeparator1,
            this.BtAuditoria});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtGravar
            // 
            this.BtGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtGravar.Image = ((System.Drawing.Image)(resources.GetObject("BtGravar.Image")));
            this.BtGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(23, 22);
            this.BtGravar.Text = "Gravar Dados";
            this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtCancelar.Image")));
            this.BtCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(23, 22);
            this.BtCancelar.Text = "Cancelar Alterações";
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtSair
            // 
            this.BtSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtSair.Image = ((System.Drawing.Image)(resources.GetObject("BtSair.Image")));
            this.BtSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(23, 22);
            this.BtSair.Text = "Sair da Transação";
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtAuditoria
            // 
            this.BtAuditoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtAuditoria.Image = ((System.Drawing.Image)(resources.GetObject("BtAuditoria.Image")));
            this.BtAuditoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtAuditoria.Name = "BtAuditoria";
            this.BtAuditoria.Size = new System.Drawing.Size(23, 22);
            this.BtAuditoria.Tag = "Auditoria de dados";
            this.BtAuditoria.Text = "Auditoria de Dados";
            this.BtAuditoria.Click += new System.EventHandler(this.BtAuditoria_Click);
            // 
            // LbCodigo
            // 
            this.LbCodigo.Location = new System.Drawing.Point(14, 34);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(80, 16);
            this.LbCodigo.TabIndex = 2;
            this.LbCodigo.Text = "Atividade";
            this.LbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(100, 33);
            this.TbCodigo.Mask = "00,00-0";
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(73, 20);
            this.TbCodigo.TabIndex = 3;
            this.TbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // LbDescricao
            // 
            this.LbDescricao.Location = new System.Drawing.Point(14, 61);
            this.LbDescricao.Name = "LbDescricao";
            this.LbDescricao.Size = new System.Drawing.Size(80, 16);
            this.LbDescricao.TabIndex = 4;
            this.LbDescricao.Text = "Descrição";
            this.LbDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbDescricao
            // 
            this.TbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbDescricao.Location = new System.Drawing.Point(100, 61);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(322, 20);
            this.TbDescricao.TabIndex = 5;
            this.TbDescricao.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // TbObservacao
            // 
            this.TbObservacao.Location = new System.Drawing.Point(100, 87);
            this.TbObservacao.Multiline = true;
            this.TbObservacao.Name = "TbObservacao";
            this.TbObservacao.Size = new System.Drawing.Size(322, 122);
            this.TbObservacao.TabIndex = 7;
            this.TbObservacao.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // LbObservacao
            // 
            this.LbObservacao.Location = new System.Drawing.Point(14, 87);
            this.LbObservacao.Name = "LbObservacao";
            this.LbObservacao.Size = new System.Drawing.Size(80, 16);
            this.LbObservacao.TabIndex = 6;
            this.LbObservacao.Text = "Observação";
            this.LbObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ATV01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 242);
            this.Controls.Add(this.TbObservacao);
            this.Controls.Add(this.LbObservacao);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.LbDescricao);
            this.Controls.Add(this.TbCodigo);
            this.Controls.Add(this.LbCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ATV01";
            this.Text = "Incluir Atividades";
            this.Shown += new System.EventHandler(this.ATV01_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SslMensagem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtGravar;
        private System.Windows.Forms.ToolStripButton BtCancelar;
        private System.Windows.Forms.ToolStripButton BtSair;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.MaskedTextBox TbCodigo;
        private System.Windows.Forms.Label LbDescricao;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.TextBox TbObservacao;
        private System.Windows.Forms.Label LbObservacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtAuditoria;
    }
}