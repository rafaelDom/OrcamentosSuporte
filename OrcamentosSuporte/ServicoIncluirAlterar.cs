using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosSuporte
{
    public partial class ServicoIncluirAlterar : Form
    {
        public ServicoIncluirAlterar(string id_alterar, string descricao_alterar)
        {        
            InitializeComponent();
            idalterar.Text = id_alterar;
            txtdescricao.Text = descricao_alterar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            Close();
            servico.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ServicoCRUD servicoCRUD = new ServicoCRUD();
            ServicoValidation servicoValidation = new ServicoValidation();

            if (servicoValidation.validar(txtdescricao.Text) == true && idalterar.Text=="") {
                servicoCRUD.inserir(txtdescricao.Text);
                txtdescricao.Text = "";
                this.Close();
                Servico servico = new Servico();
                servico.Show();

            } else if(servicoValidation.validar(txtdescricao.Text) == true && idalterar.Text != "")
            {
                servicoCRUD.alterar(idalterar.Text,txtdescricao.Text);
                this.Close();
                Servico servico = new Servico();
                servico.Show();
            }
                
            else{
                MessageBox.Show("Favor preencher o campo descrição!");
            }
        
        }
    }
}
