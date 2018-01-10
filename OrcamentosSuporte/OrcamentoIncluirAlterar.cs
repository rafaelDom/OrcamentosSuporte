using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosSuporte
{
    public partial class OrcamentoIncluirAlterar : Form
    {
        public OrcamentoIncluirAlterar()
        {
            InitializeComponent();
            carregarListaBD();
            

        }
        private void carregarListaBD()
        {
            string sql = "SELECT descricao FROM Servico";
            // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter objAdp = new SqlDataAdapter(cmd);

            DataTable dtlista = new DataTable();
            objAdp.Fill(dtlista);

            for (int i = 0; i < dtlista.Rows.Count; i++)
            {
                string data1 = dtlista.Rows[i]["descricao"].ToString();
                lstdisponiveis.Items.Add(data1);
            }


            try
            {
                int i = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            Close();
            orcamento.Show();
        }


        private void btnconcluir_Click(object sender, EventArgs e)
        {
            OrcamentoModel orcamentoModel = new OrcamentoModel();
            OrcamentoCRUD orcamentoCRUD = new OrcamentoCRUD();
            OrcamentoValidation orcamentoValidation = new OrcamentoValidation();

            orcamentoModel.Empresa = txtempresa.Text;
            orcamentoModel.Equipamento= txtequipamento.Text;
            orcamentoModel.Data_orc = dtorcamento.Text;


            for (int x=0; x<lstselecionados.Items.Count;x++)
            {
                if (x == lstselecionados.Items.Count-1)
                {
                    orcamentoModel.Servico_realizado = orcamentoModel.Servico_realizado + lstselecionados.Items[x].ToString().Trim();
                }
                else
                {
                    orcamentoModel.Servico_realizado = orcamentoModel.Servico_realizado + lstselecionados.Items[x].ToString().Trim() + "; ";
                }
            }

            //orcamentoModel.Servico_realizado = lstselecionados.Text;


            orcamentoModel.Valor = txtvalor.Text;


            if (ckgarantia.Checked)
            {
                orcamentoModel.Garantia = "1";
            }else
            {
                orcamentoModel.Garantia = "0";
            }

            orcamentoModel.Responsavel = txtresponsavel.Text;
            orcamentoModel.Email = txtemail.Text;
            orcamentoModel.Telefone = mktelefone.Text;
            orcamentoModel.Nf = txtnf.Text;
            orcamentoModel.N_serie = txtn_serie.Text;
            orcamentoModel.Observacao = txtobservacao.Text;



            if (orcamentoValidation.validar(orcamentoModel) == true && idalterar.Text == "")
            {

                
                orcamentoCRUD.inserir(orcamentoModel);
                txtempresa.Text="";
                txtequipamento.Text="";
                dtorcamento.Text="";
                lstselecionados.Text="";
                txtvalor.Text="";
                ckgarantia.Checked = false;
                txtresponsavel.Text="";
                txtemail.Text="";
                mktelefone.Text="";
                this.Close();
                Orcamento orcamento = new Orcamento();
                orcamento.Show();

            }
            else if (orcamentoValidation.validar(orcamentoModel) == true && idalterar.Text != "")
            {
                orcamentoCRUD.alterar(idalterar.Text, orcamentoModel);
                this.Close();
                Orcamento orcamento = new Orcamento();
                orcamento.Show();
            }

            else
            {
                MessageBox.Show("Os seguintes campos são obrigatórios:\n*Empresa\n*Equipamento\n*Data Orçam\n*Responsável");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lstdisponiveis.SelectedIndex>=0)
            {
                lstselecionados.Items.Add(lstdisponiveis.SelectedItem.ToString());
                lstdisponiveis.Items.Remove(lstdisponiveis.SelectedItem.ToString());
            }else
            {
                MessageBox.Show("Favor selecionar um serviço!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lstselecionados.SelectedIndex>=0)
            {
                lstdisponiveis.Items.Add(lstselecionados.SelectedItem.ToString());
                lstselecionados.Items.Remove(lstselecionados.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Favor selecionar um serviço!");
            }
        }

        public void carregarDadosAlterar()
        {
            string sql = "SELECT * FROM Orcamento WHERE id=@id";
            string listaBD;
            string items="";
          
            // string sql = "SELECT * FROM Servico WHERE descricao = 'teste'";

            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@id", idalterar.Text));

            SqlDataAdapter objAdp = new SqlDataAdapter(cmd);

            DataTable dtlista = new DataTable();
            objAdp.Fill(dtlista);

            for (int i = 0; i < dtlista.Rows.Count; i++)
            {
                txtempresa.Text= dtlista.Rows[i]["empresa"].ToString();
                txtequipamento.Text = dtlista.Rows[i]["equipamento"].ToString();
                dtorcamento.Text = dtlista.Rows[i]["data_orc"].ToString();
                txtvalor.Text = dtlista.Rows[i]["valor"].ToString();
                if (dtlista.Rows[i]["garantia"].ToString() == "1")
                {
                    ckgarantia.Checked = true;
                }
                txtresponsavel.Text = dtlista.Rows[i]["responsavel"].ToString();
                txtemail.Text = dtlista.Rows[i]["email"].ToString();
                mktelefone.Text = dtlista.Rows[i]["telefone"].ToString();
                txtnf.Text = dtlista.Rows[i]["nf"].ToString();
                txtn_serie.Text = dtlista.Rows[i]["n_serie"].ToString();
                txtobservacao.Text = dtlista.Rows[i]["observacao"].ToString();
                listaBD = dtlista.Rows[i]["servico_realizado"].ToString();
                listaBD = listaBD.Replace(" ","");

                
                var a = ';';
                int total = listaBD.Length-1;
               
                for (int posicao=0; total >= posicao;posicao++) {
                    if (listaBD[posicao].ToString() != a.ToString() && posicao < total)
                    {
                        items += listaBD[posicao].ToString();
                    }else if (listaBD[posicao].ToString() != a.ToString() && posicao == total)
                    {
                        items += listaBD[posicao].ToString();
                        lstselecionados.Items.Add(items);
                    }
                    else
                    {
                        lstselecionados.Items.Add(items);
                        items = "";
                    }
                }

            }


            try
            {
                int i = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
