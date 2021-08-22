using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using GPSys_Desk_APP.Views;
using System.Windows.Forms;

namespace GPSys_Desk_APP.Controls
{
    public class LocalDB
    {
        private static SQLiteConnection sqliteConnection;

        public LocalDB()
        { }

        // Conexão DB
        private static SQLiteConnection DBConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=.\\Data\\ServerInfo.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        // Criar Banco de Dados de Conexão ao servidor
        public static void CreateSQLiteDirAndDB()
        {
            if (Directory.Exists(@".\Data") == false && File.Exists(@".\Data\ServerInfo.sqlite") == false)
            {
                try
                {
                    System.IO.Directory.CreateDirectory(@".\Data");
                    SQLiteConnection.CreateFile(@".\Data\ServerInfo.sqlite");

                }
                catch
                {
                    throw;
                }
            }
        }

        // Criar tabela Principal (DBSettings)
        public static void CreateSQLiteTable()
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS DBSettings(Id INTEGER PRIMARY KEY AUTOINCREMENT, Servidor VARCHAR(30) NOT NULL, Banco VARCHAR(30) NOT NULL, Usuario VARCHAR(30) NOT NULL, Senha VARCHAR(30))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

        // Mostrar dados
        public static DataTable ShowData()
        {
#pragma warning disable IDE0059 // Atribuição desnecessária de um valor
            SQLiteDataAdapter Da = null;
#pragma warning restore IDE0059 // Atribuição desnecessária de um valor
            DataTable Dt = new DataTable();

            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM DBSettings";
                    Da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    Da.Fill(Dt);
                    return Dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Configuracao Padrão
        public static void Add(DBSetGet add)
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO DBSettings(Servidor, Banco, Usuario, Senha) VALUES(@ServerName, @DBName, @DBUser, @DBPassword)";
                    //cmd.Parameters.AddWithValue("@ID", add.ID);
                    cmd.Parameters.AddWithValue("@ServerName", add.ServerName);
                    cmd.Parameters.AddWithValue("@DBName", add.DBName);
                    cmd.Parameters.AddWithValue("@DBUser", add.DBUser);
                    cmd.Parameters.AddWithValue("@DBPassword", add.DBPassword);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DBConnection()))
                {
                    cmd.CommandText = "DELETE FROM DBSettings WHERE Id=@ID";
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Alterar configuração Padrão
        public static void Update(DBSetGet setting)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DBConnection()))
                {
                    if(setting.ID != null)
                    {
                        cmd.CommandText = "UPDATE DBSettings SET Servidor=@ServerName, Banco=@DBName, Usuario=@DBUser, Senha=@DBPassword";
                        cmd.Parameters.AddWithValue("@ServerName", setting.ServerName);
                        cmd.Parameters.AddWithValue("@DBName", setting.DBName);
                        cmd.Parameters.AddWithValue("@DBUser", setting.DBUser);
                        cmd.Parameters.AddWithValue("@DBPassword", setting.DBPassword);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tamanho DB
        public static int SizeRowsDB()
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM DBSettings";
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.HasRows)
                        reader.Read();
                    int RowsResult = reader.StepCount;

                    return RowsResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
