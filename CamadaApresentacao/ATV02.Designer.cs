namespace CamadaApresentacao
{
    partial class ATV02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATV02));
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtAbrir = new System.Windows.Forms.Button();
            this.BtBusca = new System.Windows.Forms.Button();
            this.LbPessoa = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SslMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.TbAtividade = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(149, 48);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(96, 23);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtAbrir
            // 
            this.BtAbrir.Location = new System.Drawing.Point(14, 48);
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.Size = new System.Drawing.Size(96, 23);
            this.BtAbrir.TabIndex = 3;
            this.BtAbrir.Text = "Carregar";
            this.BtAbrir.UseVisualStyleBackColor = true;
            this.BtAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // BtBusca
            // 
            this.BtBusca.Image = ((System.Drawing.Image)(resources.GetObject("BtBusca.Image")));
            this.BtBusca.Location = new System.Drawing.Point(220, 9);
            this.BtBusca.Name = "BtBusca";
            this.BtBusca.Size = new System.Drawing.Size(24, 24);
            this.BtBusca.TabIndex = 2;
            this.BtBusca.UseVisualStyleBackColor = true;
            this.BtBusca.Click += new System.EventHandler(this.BtBusca_Click);
            // 
            // LbPessoa
            // 
            this.LbPessoa.Location = new System.Drawing.Point(8, 12);
            this.LbPessoa.Name = "LbPessoa";
            this.LbPessoa.Size = new System.Drawing.Size(103, 17);
            this.LbPessoa.TabIndex = 0;
            this.LbPessoa.Text = "Atividade";
            this.LbPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SslMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 79);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(269, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SslMensagem
            // 
            this.SslMensagem.Name = "SslMensagem";
            this.SslMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // TbAtividade
            // 
            this.TbAtividade.Location = new System.Drawing.Point(117, 11);
            this.TbAtividade.Name = "TbAtividade";
            this.TbAtividade.Size = new System.Drawing.Size(100, 20);
            this.TbAtividade.TabIndex = 1;
            // 
            // ATV02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 101);
            this.Controls.Add(this.TbAtividade);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtAbrir);
            this.Controls.Add(this.BtBusca);
            this.Controls.Add(this.LbPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ATV02";
            this.Text = "Modificar Atividade";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtAbrir;
        private System.Windows.Forms.Button BtBusca;
        private System.Windows.Forms.Label LbPessoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SslMensagem;
        private System.Windows.Forms.MaskedTextBox TbAtividade;
    }
}