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

namespace PinduFastv1
{
    public partial class FormAdd : Form
    {
        private string _connectionString;




        public FormAdd(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string nome = txtNome.Text;
            int portas = int.Parse(txtPortas.Text);
            decimal preco = decimal.Parse(txtPreco.Text);
            DateTime dataPublicacao = txtDataPublicacao.Value;
            bool ativo = chkAtivo.Checked;

            InserirDados(placa, nome, portas, preco, dataPublicacao, ativo);
            this.Close();
        }
        private void InserirDados(string placa, string nome, int portas, decimal preco, DateTime dataPublicacao, bool ativo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Carro (Placa, Nome, Portas, Preco, DataPublicacao, Ativo) VALUES (@Placa, @Nome, @Portas, @Preco, @DataPublicacao, @Ativo)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Placa", placa);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Portas", portas);
                command.Parameters.AddWithValue("@Preco", preco);
                command.Parameters.AddWithValue("@DataPublicacao", dataPublicacao);
                command.Parameters.AddWithValue("@Ativo", ativo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
