namespace WinForms_Relatorios
{
    partial class FrmPrincipal
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
            this.btnRelatorioSimples = new System.Windows.Forms.Button();
            this.btnRelatorioCompleto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelatorioSimples
            // 
            this.btnRelatorioSimples.Location = new System.Drawing.Point(9, 12);
            this.btnRelatorioSimples.Name = "btnRelatorioSimples";
            this.btnRelatorioSimples.Size = new System.Drawing.Size(121, 46);
            this.btnRelatorioSimples.TabIndex = 0;
            this.btnRelatorioSimples.Text = "Relatório Simples";
            this.btnRelatorioSimples.UseVisualStyleBackColor = true;
            this.btnRelatorioSimples.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnRelatorioCompleto
            // 
            this.btnRelatorioCompleto.Location = new System.Drawing.Point(136, 12);
            this.btnRelatorioCompleto.Name = "btnRelatorioCompleto";
            this.btnRelatorioCompleto.Size = new System.Drawing.Size(121, 46);
            this.btnRelatorioCompleto.TabIndex = 5;
            this.btnRelatorioCompleto.Text = "Relatório Completo";
            this.btnRelatorioCompleto.UseVisualStyleBackColor = true;
            this.btnRelatorioCompleto.Click += new System.EventHandler(this.btnRelatorioCompleto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 72);
            this.Controls.Add(this.btnRelatorioCompleto);
            this.Controls.Add(this.btnRelatorioSimples);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioSimples;
        private System.Windows.Forms.Button btnRelatorioCompleto;
    }
}

