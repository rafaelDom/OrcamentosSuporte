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
    public partial class GerarPDFView : Form
    {
        public GerarPDFView()
        {
            InitializeComponent();
            carregarOrcamentoBD();

        }

        private void carregarOrcamentoBD()
        {
            string sql = "SELECT id, data_orc, empresa, nf from Orcamento";
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

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, data_orc, empresa, nf from Orcamento WHERE empresa LIKE '%'+ @empresa + '%'";
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 1)
            {
                String id_alterar = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                string sql = "SELECT empresa, servico_realizado, responsavel, equipamento, valor, nf FROM Orcamento WHERE id=@id";
                string empresa;
                string servico_realizado;
                string responsavel;
                string modelo;
                string valor;
                string nf;


                // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

                SqlConnection con = ConexaoSQLServer.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", id_alterar.ToString()));

                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);

                DataTable dtlista = new DataTable();
                objAdp.Fill(dtlista);


                empresa = dtlista.Rows[0]["empresa"].ToString();
                servico_realizado = dtlista.Rows[0]["servico_realizado"].ToString();
                responsavel = dtlista.Rows[0]["responsavel"].ToString();
                modelo = dtlista.Rows[0]["equipamento"].ToString();
                valor = dtlista.Rows[0]["valor"].ToString();
                nf = dtlista.Rows[0]["nf"].ToString();

                GerarPDF gerarPDF = new GerarPDF();
                gerarPDF.gerarPDF(empresa, servico_realizado,responsavel, modelo, valor, nf);
            }else
            {
                MessageBox.Show("Favor selecionar um orçamento para gerar em .pdf!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
