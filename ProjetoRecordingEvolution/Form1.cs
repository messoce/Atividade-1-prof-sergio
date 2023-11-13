using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProjetoRecordingEvolution
{
    public partial class TelaRecordingEvolution : Form
    {
        public TelaRecordingEvolution()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {
            AtualizaCaixaLista();
        }

        private void AtualizaCaixaLista()
        {
            caixaDeLista.Items.Clear();
            foreach (string valor in ConectaAoMySql.GetLista())
            {
                if (!caixaDeLista.Items.Contains(valor))
                {
                    caixaDeLista.Items.Add(valor);
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            

            if (ConectaAoMySql.EstaConectado())
            {
                string nomeDigitado = caixaDeTexto.Text.ToUpper();
                
                if (caixaDeLista.Items.Contains(nomeDigitado))
                {
                    MessageBox.Show("Nome já existe, digite um novo :^)");
                    caixaDeLista.SelectedItem = caixaDeTexto.Text;
                }

                //edita
                else if (caixaDeLista.SelectedItem != null)
                {
                    string nomeSelecionado = Convert.ToString(caixaDeLista.SelectedItem);
                    ConectaAoMySql.MandaComandoProMySQL($" UPDATE nomes SET nome = '{nomeDigitado}' WHERE nome = '{nomeSelecionado}' ");

                    /*caixaDeLista.Items.Insert(caixaDeLista.SelectedIndex, nomeDigitado);
                    caixaDeLista.Items.RemoveAt(caixaDeLista.SelectedIndex);*/
                }

                //acrescenta
                else if (!string.IsNullOrWhiteSpace(caixaDeTexto.Text))
                {
                    ConectaAoMySql.MandaComandoProMySQL($"INSERT INTO nomes VALUES ('{nomeDigitado}')");
                    //caixaDeLista.Items.Add(nomeDigitado);
                }

                else
                {
                    MessageBox.Show("Digite um nome válido");
                }

                caixaDeTexto.ResetText();

                AtualizaCaixaLista();

            }
            else
            {
                MessageBox.Show("vc nao estao conectado bad luck :^(");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string nomeDigitado = caixaDeTexto.Text.ToUpper();

            if (caixaDeLista.Items.Contains(nomeDigitado))
            {
                MessageBox.Show("Nome encontrado ;^)");
                caixaDeLista.SelectedItem = nomeDigitado;
            }

            else
            {
                MessageBox.Show("Nome inexistente");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            ConectaAoMySql.MandaComandoProMySQL($"DELETE FROM nomes WHERE nome = '{caixaDeTexto.Text}'");
            caixaDeLista.Items.Remove(caixaDeLista.SelectedItem);
        }

        private void caixaDeLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            caixaDeTexto.ResetText();

            string itemSelecionado = Convert.ToString(caixaDeLista.SelectedItem);
            caixaDeTexto.AppendText(itemSelecionado);
        }

        private void TelaRecordingEvolution_Click(object sender, EventArgs e)
        {
            caixaDeLista.SelectedItem = null;
        }

        private void TelaRecordingEvolution_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
