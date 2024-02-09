﻿using FastReport;
using FastReport.Export.PdfSimple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Relatorios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void GerarRelatorio_NomeEmail()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_NomeEmail.frx");
            Report report = Report.FromFile(filePath);

            report.SetParameterValue("nome", "Gabriela Moraes");
            report.SetParameterValue("email", "gabriela.moraes@email.com.br");

            report.Prepare();

            using (var pdfExport = new PDFSimpleExport())
            using (var mStream = new MemoryStream())
            {
                pdfExport.Export(report, mStream);

                File.WriteAllBytes(@"Relatorios\Relatorio_NomeEmail.PDF", mStream.ToArray());
            }
        }
    }
}