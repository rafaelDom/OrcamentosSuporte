using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrcamentosSuporte;

namespace OrcamentosSuporte
{
    class OrcamentoCRUD
    {
        public void inserir(OrcamentoModel orcamentoModel)
        {

            string sql = "INSERT INTO Orcamento(empresa, equipamento, data_orc, servico_realizado, valor, garantia, responsavel, email, telefone) VALUES (@empresa, @equipamento, @data_orc, @servico_realizado, @valor, @garantia, @responsavel, @email, @telefone)";


            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@empresa", orcamentoModel.Empresa));
            cmd.Parameters.Add(new SqlParameter("@equipamento", orcamentoModel.Equipamento));
            cmd.Parameters.Add(new SqlParameter("@data_orc", orcamentoModel.Data_orc));
            cmd.Parameters.Add(new SqlParameter("@servico_realizado", orcamentoModel.Servico_realizado));
            cmd.Parameters.Add(new SqlParameter("@valor", orcamentoModel.Valor));
            cmd.Parameters.Add(new SqlParameter("@garantia", orcamentoModel.Garantia));
            cmd.Parameters.Add(new SqlParameter("@responsavel", orcamentoModel.Responsavel));
            cmd.Parameters.Add(new SqlParameter("@email", orcamentoModel.Email));
            cmd.Parameters.Add(new SqlParameter("@telefone", orcamentoModel.Telefone));


            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro incluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void alterar(String id, OrcamentoModel orcamentoModel)
        {
            int idconvertida = Convert.ToInt32(id);
            string sql = "UPDATE Orcamento set empresa = @empresa, equipamento = @equipamento, data_orc = @data_orc, servico_realizado = @servico_realizado, valor = @valor, garantia = @garantia, responsavel = @responsavel, email = @email, telefone = @telefone where id=@id";


            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@id", idconvertida));
            cmd.Parameters.Add(new SqlParameter("@empresa", orcamentoModel.Empresa));
            cmd.Parameters.Add(new SqlParameter("@equipamento", orcamentoModel.Equipamento));
            cmd.Parameters.Add(new SqlParameter("@data_orc", orcamentoModel.Data_orc));
            cmd.Parameters.Add(new SqlParameter("@servico_realizado", orcamentoModel.Servico_realizado));
            cmd.Parameters.Add(new SqlParameter("@valor", orcamentoModel.Valor));
            cmd.Parameters.Add(new SqlParameter("@garantia", orcamentoModel.Garantia));
            cmd.Parameters.Add(new SqlParameter("@responsavel", orcamentoModel.Responsavel));
            cmd.Parameters.Add(new SqlParameter("@email", orcamentoModel.Email));
            cmd.Parameters.Add(new SqlParameter("@telefone", orcamentoModel.Telefone));

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void excluir(String id)
        {
            int idconvertida = Convert.ToInt32(id);
            string sql = "DELETE FROM Orcamento where id=@id";


            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@id", idconvertida));

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
       
}
