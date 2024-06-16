using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tournament
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuarioCad.Text.Length != 0 && 
                textBoxEmailCad.Text.Length != 0 &&
                textBoxSenhaCad.Text.Length != 0 &&
                textBoxConfirmarSenhaCad.Text.Length != 0) 
            {
                if (textBoxSenhaCad.Text == textBoxConfirmarSenhaCad.Text)
                {
                    string usuario = textBoxUsuarioCad.Text;
                    string email = textBoxEmailCad.Text;
                    string senha = textBoxSenhaCad.Text;

                    Dao dao = new Dao();    
                    dao.inserirUsuario(usuario, senha, email);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Os campos (Senha) e (Confirmar senha) devem ser iguais");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
