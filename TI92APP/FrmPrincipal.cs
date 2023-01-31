using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI92APP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnGravar.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text!= string.Empty)
            { 
                btnGravar.Enabled = true;
            }
            else
            { 
                btnGravar.Enabled = false; 
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                string nome = txtNome.Text;
                string cpf = txtCpf.Text;
                int num = lstResultado.Items.Add(nome + " - "+ cpf);
              //  MessageBox.Show(num.ToString());
                lstResultado.Items.Add(nome + " - " + cpf);
                txtCpf.Clear();
                txtNome.Clear();
            }
            // Regra de negócio
            // 1 - apenas um cliente por CPF na lista
            // 2 - minimizar clicks
            // 3 - todas as letras do nome em maiúsculas
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelecao.Text = lstResultado.SelectedItem.ToString();
        }
    }
}
