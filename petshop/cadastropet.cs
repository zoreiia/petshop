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

namespace petshop
{
    public partial class cadastropet : Form
    {
       
            string servidor;
            MySqlConnection conexao;
            MySqlCommand comando;
            string id;
            

            public cadastropet()
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
                dataGridViewpets.DataSource = tabelapets;
                


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




        private void buttonmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telamenu = new menu();
            telamenu.Closed += (s, args) => this.Close();
            telamenu.Show();
        }

        private void cadastropet_Load(object sender, EventArgs e)
        {

        }

        private void buttoncadastropet_Click(object sender, EventArgs e)
        {
            try
            {
                string op = "" ;

                if (radioButtonm.Checked)
                {
                    op = "Masculino";
                }
                if (radioButtonf.Checked)
                {
                    op = "Feminino";
                }



                if (textBoxnomepet.Text != "" && textBoxnomec.Text != "")
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_pets(nome,especie,celular_dono,raca,sexo,peso,data_de_nasc,nome_dono,obs,porte) VALUES('" + textBoxnomepet.Text + "', '" + comboBoxespecie.Text + "', '" + textBoxcelular.Text + "', '" + textBoxraca.Text + "', '" + op + "', '" + textBoxpeso.Text + "', '" + textBoxdata.Text + "', '" + textBoxnomec.Text + "', '" + textBoxobs.Text + "', '" + textBoxporte.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado");

                }
                else
                {
                    MessageBox.Show("Campos Nomes obrigatórios.");
                }


            }
            catch (Exception erro_mysql)
            {
                //MessageBox.Show(erro_mysql.Message);
                MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {
                textBoxnomepet.Clear(); textBoxdata.Clear(); textBoxobs.Clear(); textBoxporte.Clear(); textBoxnomec.Clear(); textBoxpeso.Clear(); textBoxraca.Clear(); textBoxcelular.Clear(); 
                conexao.Close();
            }
            atualiza_lista();


        }

        public void dataGridViewpets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewpets.CurrentRow.Cells[3].Value.ToString() == "Masculino")
            {
                radioButtonm.Checked = true;
            } else
            {
                radioButtonf.Checked = true;
            }
            
            id = dataGridViewpets.CurrentRow.Cells[0].Value.ToString();
            comboBoxespecie.Text = dataGridViewpets.CurrentRow.Cells[1].Value.ToString();
            textBoxraca.Text = dataGridViewpets.CurrentRow.Cells[2].Value.ToString();

            textBoxpeso.Text = dataGridViewpets.CurrentRow.Cells[4].Value.ToString();
            textBoxporte.Text = dataGridViewpets.CurrentRow.Cells[5].Value.ToString();
            textBoxnomepet.Text = dataGridViewpets.CurrentRow.Cells[6].Value.ToString();
            textBoxdata.Text = dataGridViewpets.CurrentRow.Cells[7].Value.ToString();
            textBoxnomec.Text = dataGridViewpets.CurrentRow.Cells[8].Value.ToString();
            textBoxcelular.Text = dataGridViewpets.CurrentRow.Cells[9].Value.ToString();
            textBoxobs.Text = dataGridViewpets.CurrentRow.Cells[10].Value.ToString();
        }

        private void buttonatualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string op = "";

                if (radioButtonm.Checked)
                    {
                        op = "Masculino";
                    }
                if (radioButtonf.Checked)
                {
                    op = "Feminino";
                }


                try
                {

                    conexao.Open();
                    comando.CommandText = "UPDATE tbl_pets SET nome = '" + textBoxnomepet.Text + "', celular_dono = '" + textBoxcelular.Text + "', especie = '" + comboBoxespecie.Text + "', raca = '" + textBoxraca.Text + "', sexo = '" + op + "', peso = '" + textBoxpeso.Text + "', data_de_nasc = '" + textBoxdata.Text+ "', nome_dono = '" + textBoxnomec.Text + "', celular_dono = '" + textBoxcelular.Text + "', obs = '" + textBoxobs.Text + "' WHERE  id = " + id + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contato(s) Atualizado(s) com Sucesso! - " + resultado + " Registro(s) Alterado(s)...");
                    }
                    else
                    {
                        MessageBox.Show("Contato não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show(erro_mysql.Message);

                }
                finally
                {

                    textBoxnomepet.Clear(); textBoxdata.Clear(); textBoxobs.Clear(); textBoxporte.Clear(); textBoxnomec.Clear(); textBoxpeso.Clear(); textBoxraca.Clear(); textBoxcelular.Clear();
                    conexao.Close();

                }
                atualiza_lista();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void buttonexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {

                    conexao.Open();
                    comando.CommandText = "DELETE FROM tbl_pets WHERE id = " + id + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Pet(s) Removido(s) com Sucesso! - " + resultado + "Registros Removidos...");
                    }
                    else
                    {
                        MessageBox.Show("Pet não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show("Erro de Sistema. Informe o suporte");

                }
                finally
                {

                    textBoxnomepet.Clear(); textBoxdata.Clear(); textBoxobs.Clear(); textBoxporte.Clear(); textBoxnomec.Clear(); textBoxpeso.Clear(); textBoxraca.Clear(); textBoxcelular.Clear();
                    conexao.Close();

                }
                atualiza_lista();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void dataGridViewpets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
