using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace petshop
{
    public partial class verpets : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public verpets()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=bdpets;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            atualiza_lista();
        }

        private void atualiza_lista()
        {
            try
            {

                conexao.Open();

                comando.CommandText = "SELECT * FROM tbl_pets;";
                MySqlDataAdapter adaptadorpets = new MySqlDataAdapter(comando);
                DataTable tabelapets = new DataTable();
                adaptadorpets.Fill(tabelapets);
                dataGridViewpets2.DataSource = tabelapets;



            }
            catch (Exception erro_mysql)
            {

                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                conexao.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telamenu = new menu();
            telamenu.Closed += (s, args) => this.Close();
            telamenu.Show();
        }

        public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void buttonpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPESQUISA.Text == "")
                {
                    atualiza_lista();
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT * FROM tbl_pets WHERE nome LIKE '%" + textBoxPESQUISA.Text + "%';";
                    MySqlDataAdapter adaptadorpets = new MySqlDataAdapter(comando);
                    DataTable tabelapets = new DataTable();
                    adaptadorpets.Fill(tabelapets);

                    dataGridViewpets2.DataSource = tabelapets;

                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
