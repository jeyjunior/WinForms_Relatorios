using FastReport;
using FastReport.Export.PdfSimple;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WinForms_Relatorios.Controls.Database;

namespace WinForms_Relatorios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos
        private void GerarRelatorio_Parametros()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_Parametros.frx");
            Report report = Report.FromFile(filePath);

            report.SetParameterValue("nome", "Nome do usuário");
            report.SetParameterValue("email", "nome.usuario@email.com.br");

            report.Prepare();

            string pdfFilePath = @"Relatorios\Relatorio_Parametros.PDF";

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            Process.Start(pdfFilePath);
        }
        private void GerarRelatorio_Table()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_Table.frx");
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

            string pdfFilePath = @"Relatorios\Relatorio_Table.PDF"; 

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            Process.Start(pdfFilePath);
        }
        private void GerarRelatorio_ICollection()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_ICollection.frx");
            Report report = Report.FromFile(filePath);

            var lista = new List<object>()
            {
                new {Ativo = true, ID = 1000, DataRegistro = DateTime.Today, Descricao = "Descrição do usuário 1000", ObjetoUsuario = new { Nome = "Yara", Idade = 21 } },
                new {Ativo = true, ID = 1001, DataRegistro = DateTime.Today, Descricao = "Descrição do usuário 1001", ObjetoUsuario = new { Nome = "Junior", Idade = 25 } },
                new {Ativo = false, ID = 1002, DataRegistro = DateTime.Today.AddDays(-10), Descricao = "Descrição do usuário 1002", ObjetoUsuario = new { Nome = "Jessica", Idade = 33 } },
                new {Ativo = false, ID = 1003, DataRegistro = DateTime.Today.AddDays(-10), Descricao = "Descrição do usuário 1003", ObjetoUsuario = new { Nome = "Vanessa", Idade = 19 } },
            };

            report.RegisterData(lista, "Usuario");
            report.Prepare();

            string pdfFilePath = @"Relatorios\Relatorio_ICollection.PDF";

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            Process.Start(pdfFilePath);
        }
        #endregion

        #region Eventos
        private void btnRelatorioParametros_Click(object sender, EventArgs e)
        {
            GerarRelatorio_Parametros();
        }
        private void btnRelatorioTable_Click(object sender, EventArgs e)
        {
            GerarRelatorio_Table();
        }
        private void btnRelatorioICollection_Click(object sender, EventArgs e)
        {
            GerarRelatorio_ICollection();
        }
        private void btnBase_Click(object sender, EventArgs e)
        {
            //return;
            var baseDados = new DBSQLite();
            //baseDados.AddTabelaUsuario();
        }
        #endregion
    }
}
