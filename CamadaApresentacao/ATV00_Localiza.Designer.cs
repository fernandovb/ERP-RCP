namespace CamadaApresentacao
{
    partial class ATV00_Localiza
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtConfirma = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtPesquisas = new System.Windows.Forms.Button();
            this.TcPesquisa = new System.Windows.Forms.TabControl();
            this.TpPropriedades = new System.Windows.Forms.TabPage();
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.TbAtividade = new System.Windows.Forms.TextBox();
            this.LbDescricao = new System.Windows.Forms.Label();
            this.LbAtividade = new System.Windows.Forms.Label();
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SslMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.DsPesquisa = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PnBotoes.SuspendLayout();
            this.TcPesquisa.SuspendLayout();
            this.TpPropriedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PnBotoes);
            this.splitContainer1.Panel1.Controls.Add(this.TcPesquisa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgResultado);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(492, 321);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtConfirma);
            this.PnBotoes.Controls.Add(this.BtCancelar);
            this.PnBotoes.Controls.Add(this.BtPesquisas);
            this.PnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBotoes.Location = new System.Drawing.Point(0, 85);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(492, 46);
            this.PnBotoes.TabIndex = 4;
            // 
            // BtConfirma
            // 
            this.BtConfirma.Enabled = false;
            this.BtConfirma.Location = new System.Drawing.Point(188, 12);
            this.BtConfirma.Name = "BtConfirma";
            this.BtConfirma.Size = new System.Drawing.Size(113, 23);
            this.BtConfirma.TabIndex = 3;
            this.BtConfirma.Text = "Carregar";
            this.BtConfirma.UseVisualStyleBackColor = true;
            this.BtConfirma.Click += new System.EventHandler(this.BtConfirma_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(359, 12);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(113, 23);
            this.BtCancelar.TabIndex = 1;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtPesquisas
            // 
            this.BtPesquisas.Location = new System.Drawing.Point(12, 12);
            this.BtPesquisas.Name = "BtPesquisas";
            this.BtPesquisas.Size = new System.Drawing.Size(113, 23);
            this.BtPesquisas.TabIndex = 0;
            this.BtPesquisas.Text = "Pesquisar";
            this.BtPesquisas.UseVisualStyleBackColor = true;
            this.BtPesquisas.Click += new System.EventHandler(this.BtPesquisas_Click);
            // 
            // TcPesquisa
            // 
            this.TcPesquisa.Controls.Add(this.TpPropriedades);
            this.TcPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPesquisa.Location = new System.Drawing.Point(0, 0);
            this.TcPesquisa.Name = "TcPesquisa";
            this.TcPesquisa.SelectedIndex = 0;
            this.TcPesquisa.Size = new System.Drawing.Size(492, 131);
            this.TcPesquisa.TabIndex = 0;
            // 
            // TpPropriedades
            // 
            this.TpPropriedades.Controls.Add(this.TbDescricao);
            this.TpPropriedades.Controls.Add(this.TbAtividade);
            this.TpPropriedades.Controls.Add(this.LbDescricao);
            this.TpPropriedades.Controls.Add(this.LbAtividade);
            this.TpPropriedades.Location = new System.Drawing.Point(4, 22);
            this.TpPropriedades.Name = "TpPropriedades";
            this.TpPropriedades.Padding = new System.Windows.Forms.Padding(3);
            this.TpPropriedades.Size = new System.Drawing.Size(484, 105);
            this.TpPropriedades.TabIndex = 1;
            this.TpPropriedades.Text = "Propriedades";
            this.TpPropriedades.UseVisualStyleBackColor = true;
            // 
            // TbDescricao
            // 
            this.TbDescricao.Location = new System.Drawing.Point(110, 34);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(317, 20);
            this.TbDescricao.TabIndex = 7;
            // 
            // TbAtividade
            // 
            this.TbAtividade.Location = new System.Drawing.Point(110, 8);
            this.TbAtividade.Name = "TbAtividade";
            this.TbAtividade.Size = new System.Drawing.Size(138, 20);
            this.TbAtividade.TabIndex = 5;
            // 
            // LbDescricao
            // 
            this.LbDescricao.Location = new System.Drawing.Point(6, 34);
            this.LbDescricao.Name = "LbDescricao";
            this.LbDescricao.Size = new System.Drawing.Size(100, 20);
            this.LbDescricao.TabIndex = 6;
            this.LbDescricao.Text = "Descrição";
            this.LbDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbAtividade
            // 
            this.LbAtividade.Location = new System.Drawing.Point(6, 8);
            this.LbAtividade.Name = "LbAtividade";
            this.LbAtividade.Size = new System.Drawing.Size(100, 20);
            this.LbAtividade.TabIndex = 4;
            this.LbAtividade.Text = "Atividade";
            this.LbAtividade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DgResultado
            // 
            this.DgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgResultado.Location = new System.Drawing.Point(0, 0);
            this.DgResultado.MultiSelect = false;
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.Size = new System.Drawing.Size(492, 164);
            this.DgResultado.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SslMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 164);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SslMensagem
            // 
            this.SslMensagem.Name = "SslMensagem";
            this.SslMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // DsPesquisa
            // 
            this.DsPesquisa.DataSetName = "NewDataSet";
            // 
            // ATV00_Localiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ATV00_Localiza";
            this.Text = "Localizar Atividade";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PnBotoes.ResumeLayout(false);
            this.TcPesquisa.ResumeLayout(false);
            this.TpPropriedades.ResumeLayout(false);
            this.TpPropriedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TcPesquisa;
        private System.Windows.Forms.TabPage TpPropriedades;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SslMensagem;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.TextBox TbAtividade;
        private System.Windows.Forms.Label LbDescricao;
        private System.Windows.Forms.Label LbAtividade;
        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Button BtConfirma;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtPesquisas;
        private System.Windows.Forms.DataGridView DgResultado;
        private System.Data.DataSet DsPesquisa;
    }
}