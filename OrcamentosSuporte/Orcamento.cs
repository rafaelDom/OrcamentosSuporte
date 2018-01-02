using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosSuporte
{
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
            carregarOrcamentoBD();
            
        }


        private void carregarOrcamentoBD()
        {
            string sql = "SELECT id, data_orc, empresa from Orcamento";
            // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;


            SqlDataAdapter objAdp = new SqlDataAdapter(cmd);

            DataTable dtlista = new DataTable();
            objAdp.Fill(dtlista);

            dataGridView1.DataSource = dtlista;

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrcamentoIncluirAlterar orcamentoIncluirAlterar = new OrcamentoIncluirAlterar();
            this.Close();
            orcamentoIncluirAlterar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, data_orc, empresa from Orcamento WHERE empresa LIKE '%'+ @empresa + '%'";
            // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@empresa", txtdescricaopesquisa.Text.Trim()));

            SqlDataAdapter objAdp = new SqlDataAdapter(cmd);

            DataTable dtlista = new DataTable();
            objAdp.Fill(dtlista);

            dataGridView1.DataSource = dtlista;

            try
            {
                int i = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {

                String id_alterar = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                OrcamentoIncluirAlterar orcamentoIncluirAlterar = new OrcamentoIncluirAlterar();
                orcamentoIncluirAlterar.idalterar.Text = id_alterar;
                Close();
                orcamentoIncluirAlterar.Show();
                orcamentoIncluirAlterar.carregarDadosAlterar();
            }
            else
            {
                MessageBox.Show("Favor selecionar um item para alteração!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrcamentoCRUD orcamentoCRUD = new OrcamentoCRUD();
           
            if (dataGridView1.RowCount > 1)
            {
                String empresa_excluir = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                String id_excluir = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                DialogResult confirm = MessageBox.Show("Deseja excluir o serviço\n" + empresa_excluir + " ?", "Exclusão de orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        orcamentoCRUD.excluir(id_excluir);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                }
                else
                {
                    MessageBox.Show("Favor selecionar um item para exclusão!");
                }
            }else
            {
                MessageBox.Show("Favor selecionar um item para exclusão!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
