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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerTorneios verTorneios = new VerTorneios();
            verTorneios.Show();
            this.Close();
        }

        private void buttonCriarTorneio_Click(object sender, EventArgs e)
        {
            CriarTorneio criarTorneio = new CriarTorneio();
            criarTorneio.Show();
            this.Close();
        }

        private void informacoesDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoUser infoUser = new InfoUser();
            infoUser.Show();
            this.Close();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalhes detalhes = new Detalhes();
            detalhes.Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
