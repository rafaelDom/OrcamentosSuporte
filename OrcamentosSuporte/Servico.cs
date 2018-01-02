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
    public partial class Servico : Form
    {
        public Servico()
        {
            InitializeComponent();
            carregarServicosBD();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            ServicoIncluirAlterar servicoIncluirAlterar = new ServicoIncluirAlterar("", "");
            servicoIncluirAlterar.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {

                String id_alterar = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                String descricao_alterar = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                ServicoIncluirAlterar servicoIncluirAlterar = new ServicoIncluirAlterar(id_alterar, descricao_alterar);
                Close();
                servicoIncluirAlterar.Show();
            }else
            {
                MessageBox.Show("Favor selecionar um item para alteração!");
            }
        }


   
  

        public void carregarServicosBD()
        {
            string sql = "SELECT id, descricao from Servico";
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


        private void button3_Click_1(object sender, EventArgs e)
        {

            ServicoCRUD servicoCRUD = new ServicoCRUD();
            
            if (dataGridView1.RowCount > 1)
            {
                String descricao_excluir = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                String id_excluir = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                DialogResult confirm = MessageBox.Show("Deseja excluir o serviço\n" + descricao_excluir + " ?", "Exclusão de serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        servicoCRUD.excluir(id_excluir);
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT id, descricao from Servico WHERE descricao LIKE '%'+ @descricao + '%'";
            // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@descricao", txtdescricaopesquisa.Text.Trim()));

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
    }
}
