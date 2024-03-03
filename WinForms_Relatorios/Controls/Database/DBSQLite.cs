using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using WinForms_Relatorios.Model;

namespace WinForms_Relatorios.Controls.Database
{
    public class DBSQLite
    {
        private string databasePath = Path.Combine(Environment.CurrentDirectory, "Relatorios.sqlite");
        private SQLiteConnection connection;
        public DBSQLite()
        {
            connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
            connection.Open();
        }
        public void AddTabelaUsuario()
        {
            // USUÁRIO
            using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Usuario (PK_Usuario INTEGER PRIMARY KEY AUTOINCREMENT, Nome TEXT, Idade INTEGER, Profissao TEXT)", connection))
            {
                command.ExecuteNonQuery();
            }
            InserirUsuario();
            var resultado = ConsultarUsuarios();
        }
        public void InserirUsuario()
        {
            var usuarios = new List<Usuario>
            {
                new Usuario { Nome = "Antonio", Idade = 30, Profissao = "Engenheiro" },
                new Usuario { Nome = "Fernanda", Idade = 25, Profissao = "Programador" },
                new Usuario { Nome = "Elias", Idade = 40, Profissao = "Professor" },
                new Usuario { Nome = "João", Idade = 35, Profissao = "Engenheiro" },
                new Usuario { Nome = "Maria", Idade = 28, Profissao = "Médico" },
                new Usuario { Nome = "José", Idade = 33, Profissao = "Arquiteto" },
                new Usuario { Nome = "Ana", Idade = 27, Profissao = "Programador" },
                new Usuario { Nome = "Pedro", Idade = 42, Profissao = "Professor" },
                new Usuario { Nome = "Mariana", Idade = 38, Profissao = "Engenheiro" },
                new Usuario { Nome = "Paulo", Idade = 31, Profissao = "Engenheiro" },
                new Usuario { Nome = "Carla", Idade = 29, Profissao = "Programador" },
                new Usuario { Nome = "Ricardo", Idade = 36, Profissao = "Professor" },
                new Usuario { Nome = "Juliana", Idade = 32, Profissao = "Advogado" },
                new Usuario { Nome = "Lucas", Idade = 26, Profissao = "Engenheiro" },
                new Usuario { Nome = "Amanda", Idade = 34, Profissao = "Arquiteto" },
                new Usuario { Nome = "Roberto", Idade = 37, Profissao = "Programador" },
                new Usuario { Nome = "Patrícia", Idade = 39, Profissao = "Médico" },
                new Usuario { Nome = "Daniel", Idade = 41, Profissao = "Professor" },
                new Usuario { Nome = "Vanessa", Idade = 28, Profissao = "Programador" },
                new Usuario { Nome = "Eduardo", Idade = 43, Profissao = "Engenheiro" }
            };

            using (var transaction = connection.BeginTransaction())
            {
                foreach (var usuario in usuarios)
                {
                    using (var command = new SQLiteCommand("INSERT INTO Usuario (Nome, Idade, Profissao) VALUES (@Nome, @Idade, @Profissao)", connection))
                    {
                        command.Parameters.AddWithValue("@Nome", usuario.Nome);
                        command.Parameters.AddWithValue("@Idade", usuario.Idade);
                        command.Parameters.AddWithValue("@Profissao", usuario.Profissao);
                        command.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
        }
        public IEnumerable<Usuario> ConsultarUsuarios()
        {
            var usuarios = new List<Usuario>();
            using (var command = new SQLiteCommand("SELECT * FROM Usuario", connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        PK_Usuario = Convert.ToInt32(reader["PK_Usuario"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Idade = Convert.ToInt32(reader["Idade"]),
                        Profissao = Convert.ToString(reader["Profissao"])
                    });
                }
            }
            return usuarios;
        }
    }
}
