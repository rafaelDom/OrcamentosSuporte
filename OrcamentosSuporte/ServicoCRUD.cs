using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosSuporte
{
    class ServicoCRUD
    {

        public void inserir(String descricao)
        {

            string sql = "INSERT INTO Servico(descricao) VALUES (@descricao)";


            SqlConnection con = ConexaoSQLServer.obterConexao(); 
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@descricao", descricao));



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

        public void alterar(String id, String descricao)
        {
            int idconvertida = Convert.ToInt32(id);
            string sql = "UPDATE Servico set descricao = @descricao where id=@id";


            SqlConnection con = ConexaoSQLServer.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@id", idconvertida));
            cmd.Parameters.Add(new SqlParameter("@descricao", descricao));

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
            string sql = "DELETE FROM Servico where id=@id";


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
