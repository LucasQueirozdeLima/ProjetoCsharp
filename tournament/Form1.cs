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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCasdatrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = textBoxUsuarioLog.Text;
            senha = textBoxSenhaLog.Text;
            Dao dao = new Dao();
            dao.verificaLogin(usuario, senha);
        }

        private void labelUsuarioLog_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuarioLog_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
