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
    public partial class CriarTorneio : Form
    {
        public CriarTorneio()
        {
            InitializeComponent();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length != 0 &&
                textBoxDescricao.Text.Length != 0 &&
                comboBoxNparticipantes.Text.Length != 0 &&
                comboBoxVerificador.Text.Length != 0)
            {
                
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
