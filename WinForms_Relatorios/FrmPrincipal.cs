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
            GerarRelatorio_ListaNomeEmail();
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

        private void GerarRelatorio_ListaNomeEmail()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Relatorios\Relatorio_ListaNomeEmail.frx");
            Report report = Report.FromFile(filePath);

            var lista = new List<Usuario>
            {
                new Usuario() { Tipo = 1, TituloTipo = "Tipo 1", Nome = "Nome do usuário", Email = "nome.usuarop@email.com" },
                new Usuario() { Tipo = 1, TituloTipo = "Tipo 1", Nome = "Nome do usuário", Email = "nome.usuarop@email.com" },
                new Usuario() { Tipo = 1, TituloTipo = "Tipo 1", Nome = "Nome do usuário", Email = "nome.usuarop@email.com" },
                new Usuario() { Tipo = 1, TituloTipo = "Tipo 1", Nome = "Nome do usuário", Email = "nome.usuarop@email.com" },
                new Usuario() { Tipo = 1, TituloTipo = "Tipo 1", Nome = "Nome do usuário", Email = "nome.usuarop@email.com" }
            };

            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo", typeof(int));
            dt.Columns.Add("TituloTipo", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            foreach (var usuario in lista)
            {
                dt.Rows.Add(usuario.Tipo, usuario.TituloTipo, usuario.Nome, usuario.Email);
            }

            report.RegisterData(dt, "Usuario");
            report.Prepare();

            string pdfFilePath = @"Relatorios\Relatorio_ListaNomeEmail.PDF"; // Caminho do arquivo PDF

            using (var pdfExport = new PDFSimpleExport())
            {
                pdfExport.Export(report, pdfFilePath);
            }

            // Abrir o PDF após salvar
            Process.Start(pdfFilePath);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text))
                return;

            registros.Add(new Registro { Nome = txtNome.Text.Trim(), Email = txtEmail.Text.Trim() });

            dtgPrincipal.DataSource = registros.Select(i => new
            {
                Nome = i.Nome,
                Email = i.Email,
            })
                .ToList();
        }
    }
}

public class Usuario
{
    public int Tipo { get; set; }
    public string TituloTipo { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}