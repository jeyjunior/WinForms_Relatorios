using FastReport;
using FastReport.Export.PdfSimple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Relatorios.Model;

namespace WinForms_Relatorios
{
    public partial class FrmPrincipal : Form
    {
        private List<Registro> registros = new List<Registro>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio_NomeEmail();
        }
        private void btnRelatorioCompleto_Click(object sender, EventArgs e)
        {
            GerarRelatorio_ListaNomeEmail();
        }

        private void GerarRelatorio_NomeEmail()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_NomeEmail.frx");
            Report report = Report.FromFile(filePath);

            report.SetParameterValue("nome", "Nome do usuário");
            report.SetParameterValue("email", "nome.usuario@email.com.br");

            report.Prepare();

            string pdfFilePath = @"Relatorios\Relatorio_NomeEmail.PDF";

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            Process.Start(pdfFilePath);
        }

        private void GerarRelatorio_ListaNomeEmail()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_ListaNomeEmail.frx");
            Report report = Report.FromFile(filePath);

            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo", typeof(int));
            dt.Columns.Add("TituloTipo", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            dt.Rows.Add(1, "Tipo 1", "Nome do usuário 1", "nome.usuario_1@email.com");
            dt.Rows.Add(1, "Tipo 1", "Nome do usuário 1", "nome.usuario_1@email.com");
            dt.Rows.Add(2, "Tipo 2", "Nome do usuário 2", "nome.usuario_2@email.com");
            dt.Rows.Add(2, "Tipo 2", "Nome do usuário 2", "nome.usuario_2@email.com");
            dt.Rows.Add(3, "Tipo 3", "Nome do usuário 3", "nome.usuario_3@email.com");

            report.RegisterData(dt, "Usuario");
            report.Prepare();

            string pdfFilePath = @"Relatorios\Relatorio_ListaNomeEmail.PDF"; 

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            Process.Start(pdfFilePath);
        }
    }
}
