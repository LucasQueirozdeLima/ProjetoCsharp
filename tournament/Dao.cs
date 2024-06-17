using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.SqlClient;
using MySqlX.XDevAPI;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace tournament
{
    internal class Dao
    {
        public string connectionstring = "Server=localhost;Port=3306;Database=tourtest;Uid=root;Pwd='';";

        public void inserirUsuario(string usuario, string senha, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();

                    Console.WriteLine("Inserir Dados\n\n");

                    string sql = "insert into login(usuario, senha, email) values('"+usuario+"','"+senha+"','"+email+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Erro ao se cadastrar");
                    }
                    else
                    {
                        Form1 login = new Form1();
                        login.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir usuário: " + ex.Message);
            }
        }

        public void verificaLogin(string usuario,string senha)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "Select * from login where usuario='"+usuario+"' and senha='"+senha+"'";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                int rowsAffected = cmd.ExecuteNonQuery();

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount == Convert.ToInt32(cmd.ExecuteScalar()))
                {
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao logar");   
                }
            }      
        }

        public void inserirTorneio(string nome, int Nparticipantes, string descricao, string verificador)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();
                    Console.WriteLine("Inserir Dados\n\n");

                    string sql = "insert into Tournament(tournament_name, tournament_description, email) values('" + usuario + "','" + senha + "','" + email + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Erro ao criar torneio");
                    }
                    else
                    {
                        TorneioForm torneioForm = new TorneioForm();
                        torneioForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir usuário: " + ex.Message);
            }
        }
    }
}
