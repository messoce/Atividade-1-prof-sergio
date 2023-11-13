
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProjetoRecordingEvolution
{
    static class ConectaAoMySql
    {
        private static MySqlConnection _Conexao;
        private static MySqlCommand comando;

        private static bool conectado = false;
        static ConectaAoMySql()
        {
            //inicia conexao
            try
            {
                _Conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=testecomcsharp");
                conectado = true;
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha ao conectar" + ex);
                conectado = false;
            }
        }

        public static bool EstaConectado() => conectado;

        public static void MandaComandoProMySQL(string texto)
        {
            _Conexao.Open();

            comando = new MySqlCommand(texto, _Conexao);
            comando.ExecuteNonQuery();

            _Conexao.Close();
        }

        public static List<string> GetLista()
        {
            _Conexao.Open();

            List<string> copiaSql = new List<string>();

            comando = new MySqlCommand("SELECT * FROM nomes", _Conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                copiaSql.Add(leitor["nome"].ToString());
            }

            _Conexao.Close();

            return copiaSql;
        }

    }
}
