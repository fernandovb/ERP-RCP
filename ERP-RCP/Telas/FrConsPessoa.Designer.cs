namespace ERP_RCP.Telas
{
    partial class FrConsPessoa
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
            this.TbPesquisa = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TbMunicipio = new System.Windows.Forms.TextBox();
            this.LbMunicipio = new System.Windows.Forms.Label();
            this.TbNomeAltern = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TbMunicipal = new System.Windows.Forms.TextBox();
            this.LbMunicipal = new System.Windows.Forms.Label();
            this.TbEstadual = new System.Windows.Forms.TextBox();
            this.LbEstadual = new System.Windows.Forms.Label();
            this.TbFederal = new System.Windows.Forms.TextBox();
            this.LbFederal = new System.Windows.Forms.Label();
            this.DgResultado = new System.Windows.Forms.DataGridView();
            this.DsConsPessoa = new System.Data.DataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SslMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PnBotoes.SuspendLayout();
            this.TbPesquisa.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsConsPessoa)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.TbPesquisa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.DgResultado);
            this.splitContainer1.Size = new System.Drawing.Size(488, 502);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtConfirma);
            this.PnBotoes.Controls.Add(this.BtCancelar);
            this.PnBotoes.Controls.Add(this.BtPesquisas);
            this.PnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBotoes.Location = new System.Drawing.Point(0, 142);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(488, 46);
            this.PnBotoes.TabIndex = 3;
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
            // TbPesquisa
            // 
            this.TbPesquisa.Controls.Add(this.tabPage1);
            this.TbPesquisa.Controls.Add(this.tabPage2);
            this.TbPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPesquisa.Location = new System.Drawing.Point(0, 0);
            this.TbPesquisa.Name = "TbPesquisa";
            this.TbPesquisa.SelectedIndex = 0;
            this.TbPesquisa.Size = new System.Drawing.Size(488, 188);
            this.TbPesquisa.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TbMunicipio);
            this.tabPage1.Controls.Add(this.LbMunicipio);
            this.tabPage1.Controls.Add(this.TbNomeAltern);
            this.tabPage1.Controls.Add(this.TbNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Propriedades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TbMunicipio
            // 
            this.TbMunicipio.Location = new System.Drawing.Point(119, 67);
            this.TbMunicipio.Name = "TbMunicipio";
            this.TbMunicipio.Size = new System.Drawing.Size(253, 20);
            this.TbMunicipio.TabIndex = 5;
            // 
            // LbMunicipio
            // 
            this.LbMunicipio.Location = new System.Drawing.Point(15, 67);
            this.LbMunicipio.Name = "LbMunicipio";
            this.LbMunicipio.Size = new System.Drawing.Size(100, 20);
            this.LbMunicipio.TabIndex = 4;
            this.LbMunicipio.Text = "Município";
            this.LbMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbNomeAltern
            // 
            this.TbNomeAltern.Location = new System.Drawing.Point(119, 41);
            this.TbNomeAltern.Name = "TbNomeAltern";
            this.TbNomeAltern.Size = new System.Drawing.Size(317, 20);
            this.TbNomeAltern.TabIndex = 3;
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(119, 15);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(317, 20);
            this.TbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Alternativo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TbMunicipal);
            this.tabPage2.Controls.Add(this.LbMunicipal);
            this.tabPage2.Controls.Add(this.TbEstadual);
            this.tabPage2.Controls.Add(this.LbEstadual);
            this.tabPage2.Controls.Add(this.TbFederal);
            this.tabPage2.Controls.Add(this.LbFederal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Fiscais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TbMunicipal
            // 
            this.TbMunicipal.Location = new System.Drawing.Point(119, 67);
            this.TbMunicipal.Name = "TbMunicipal";
            this.TbMunicipal.Size = new System.Drawing.Size(173, 20);
            this.TbMunicipal.TabIndex = 7;
            // 
            // LbMunicipal
            // 
            this.LbMunicipal.Location = new System.Drawing.Point(15, 67);
            this.LbMunicipal.Name = "LbMunicipal";
            this.LbMunicipal.Size = new System.Drawing.Size(100, 20);
            this.LbMunicipal.TabIndex = 6;
            this.LbMunicipal.Text = "Cadastro Municipal";
            this.LbMunicipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbEstadual
            // 
            this.TbEstadual.Location = new System.Drawing.Point(119, 41);
            this.TbEstadual.Name = "TbEstadual";
            this.TbEstadual.Size = new System.Drawing.Size(173, 20);
            this.TbEstadual.TabIndex = 5;
            // 
            // LbEstadual
            // 
            this.LbEstadual.Location = new System.Drawing.Point(15, 41);
            this.LbEstadual.Name = "LbEstadual";
            this.LbEstadual.Size = new System.Drawing.Size(100, 20);
            this.LbEstadual.TabIndex = 4;
            this.LbEstadual.Text = "Cadastro Estadual";
            this.LbEstadual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbFederal
            // 
            this.TbFederal.Location = new System.Drawing.Point(119, 15);
            this.TbFederal.Name = "TbFederal";
            this.TbFederal.Size = new System.Drawing.Size(173, 20);
            this.TbFederal.TabIndex = 3;
            // 
            // LbFederal
            // 
            this.LbFederal.Location = new System.Drawing.Point(15, 15);
            this.LbFederal.Name = "LbFederal";
            this.LbFederal.Size = new System.Drawing.Size(100, 20);
            this.LbFederal.TabIndex = 2;
            this.LbFederal.Text = "Cadastro Federal";
            this.LbFederal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DgResultado
            // 
            this.DgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgResultado.Location = new System.Drawing.Point(0, 0);
            this.DgResultado.Name = "DgResultado";
            this.DgResultado.Size = new System.Drawing.Size(488, 310);
            this.DgResultado.TabIndex = 0;
            // 
            // DsConsPessoa
            // 
            this.DsConsPessoa.DataSetName = "NewDataSet";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SslMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SslMensagem
            // 
            this.SslMensagem.Name = "SslMensagem";
            this.SslMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // FrConsPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 502);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrConsPessoa";
            this.Text = "Localizar Pessoas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PnBotoes.ResumeLayout(false);
            this.TbPesquisa.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsConsPessoa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtPesquisas;
        private System.Windows.Forms.TabControl TbPesquisa;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TbMunicipio;
        private System.Windows.Forms.Label LbMunicipio;
        private System.Windows.Forms.TextBox TbNomeAltern;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TbMunicipal;
        private System.Windows.Forms.Label LbMunicipal;
        private System.Windows.Forms.TextBox TbEstadual;
        private System.Windows.Forms.Label LbEstadual;
        private System.Windows.Forms.TextBox TbFederal;
        private System.Windows.Forms.Label LbFederal;
        private System.Windows.Forms.DataGridView DgResultado;
        private System.Windows.Forms.Button BtConfirma;
        private System.Data.DataSet DsConsPessoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SslMensagem;
    }
}