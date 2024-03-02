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
            this.btnRelatorioParametros = new System.Windows.Forms.Button();
            this.btnRelatorioTable = new System.Windows.Forms.Button();
            this.btnRelatorioICollection = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelatorioParametros
            // 
            this.btnRelatorioParametros.Location = new System.Drawing.Point(9, 12);
            this.btnRelatorioParametros.Name = "btnRelatorioParametros";
            this.btnRelatorioParametros.Size = new System.Drawing.Size(121, 46);
            this.btnRelatorioParametros.TabIndex = 0;
            this.btnRelatorioParametros.Text = "Relatório Parametros";
            this.btnRelatorioParametros.UseVisualStyleBackColor = true;
            this.btnRelatorioParametros.Click += new System.EventHandler(this.btnRelatorioParametros_Click);
            // 
            // btnRelatorioTable
            // 
            this.btnRelatorioTable.Location = new System.Drawing.Point(136, 12);
            this.btnRelatorioTable.Name = "btnRelatorioTable";
            this.btnRelatorioTable.Size = new System.Drawing.Size(121, 46);
            this.btnRelatorioTable.TabIndex = 5;
            this.btnRelatorioTable.Text = "Relatório Table";
            this.btnRelatorioTable.UseVisualStyleBackColor = true;
            this.btnRelatorioTable.Click += new System.EventHandler(this.btnRelatorioTable_Click);
            // 
            // btnRelatorioICollection
            // 
            this.btnRelatorioICollection.Location = new System.Drawing.Point(263, 12);
            this.btnRelatorioICollection.Name = "btnRelatorioICollection";
            this.btnRelatorioICollection.Size = new System.Drawing.Size(121, 46);
            this.btnRelatorioICollection.TabIndex = 6;
            this.btnRelatorioICollection.Text = "Relatório ICollection";
            this.btnRelatorioICollection.UseVisualStyleBackColor = true;
            this.btnRelatorioICollection.Click += new System.EventHandler(this.btnRelatorioICollection_Click);
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(390, 12);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(121, 46);
            this.btnBase.TabIndex = 7;
            this.btnBase.Text = "Inicializar Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 139);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnRelatorioICollection);
            this.Controls.Add(this.btnRelatorioTable);
            this.Controls.Add(this.btnRelatorioParametros);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioParametros;
        private System.Windows.Forms.Button btnRelatorioTable;
        private System.Windows.Forms.Button btnRelatorioICollection;
        private System.Windows.Forms.Button btnBase;
    }
}

