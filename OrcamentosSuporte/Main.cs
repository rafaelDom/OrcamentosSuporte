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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            servico.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gerarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarPDFView gerarPDFView = new GerarPDFView();
            gerarPDFView.Show();
        }
    }
}
