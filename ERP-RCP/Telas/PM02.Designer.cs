namespace ERP_RCP.Telas
{
    partial class PM02
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
            this.LbPessoa = new System.Windows.Forms.Label();
            this.TbCodPessoa = new System.Windows.Forms.TextBox();
            this.BtBusca = new System.Windows.Forms.Button();
            this.BtAbrir = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbPessoa
            // 
            this.LbPessoa.Location = new System.Drawing.Point(15, 16);
            this.LbPessoa.Name = "LbPessoa";
            this.LbPessoa.Size = new System.Drawing.Size(103, 17);
            this.LbPessoa.TabIndex = 0;
            this.LbPessoa.Text = "Código da Pessoa";
            this.LbPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbCodPessoa
            // 
            this.TbCodPessoa.Location = new System.Drawing.Point(124, 13);
            this.TbCodPessoa.Name = "TbCodPessoa";
            this.TbCodPessoa.Size = new System.Drawing.Size(100, 20);
            this.TbCodPessoa.TabIndex = 1;
            // 
            // BtBusca
            // 
            this.BtBusca.Location = new System.Drawing.Point(227, 12);
            this.BtBusca.Name = "BtBusca";
            this.BtBusca.Size = new System.Drawing.Size(22, 22);
            this.BtBusca.TabIndex = 2;
            this.BtBusca.Text = "P";
            this.BtBusca.UseVisualStyleBackColor = true;
            this.BtBusca.Click += new System.EventHandler(this.BtBusca_Click);
            // 
            // BtAbrir
            // 
            this.BtAbrir.Location = new System.Drawing.Point(18, 49);
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.Size = new System.Drawing.Size(96, 23);
            this.BtAbrir.TabIndex = 3;
            this.BtAbrir.Text = "Carregar";
            this.BtAbrir.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(153, 49);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(96, 23);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // PM02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 85);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtAbrir);
            this.Controls.Add(this.BtBusca);
            this.Controls.Add(this.TbCodPessoa);
            this.Controls.Add(this.LbPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PM02";
            this.Text = "Consulta Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPessoa;
        private System.Windows.Forms.TextBox TbCodPessoa;
        private System.Windows.Forms.Button BtBusca;
        private System.Windows.Forms.Button BtAbrir;
        private System.Windows.Forms.Button BtCancelar;
    }
}