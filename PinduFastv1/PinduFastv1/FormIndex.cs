using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PinduFastv1
{
    public partial class FormIndex : Form
    {
        public string ConnectionString { get; } = "Data Source=LAPTOP-VAPQNIBG\\SQLEXPRESS01;Initial Catalog=Pindufast;Integrated Security=True;Connect Timeout=30;";




        public FormIndex()
        {
            InitializeComponent();
            CarregarDados();
        }
        public void CarregarDados()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Id, Placa, Nome, Portas, Preco, DataPublicacao, Ativo FROM Carro";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        public void AdicionarProduto(int id, string placa, string nome, int portas, decimal preco, DateTime dataPublicacao, bool ativo)
        {
            dataGridView1.Rows.Add(id, placa, nome, portas, preco.ToString("C"), dataPublicacao.ToShortDateString(), ativo);
        }
       

       


        private void label1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(ConnectionString);
            formAdd.ShowDialog();
            CarregarDados();


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecione uma linha para deletar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];

                // Abre caixas de diálogo para cada campo
                linhaSelecionada.Cells["Id"].Value = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Editar ID:", "Editar", linhaSelecionada.Cells["Id"].Value.ToString()));
                linhaSelecionada.Cells["Placa"].Value = Microsoft.VisualBasic.Interaction.InputBox("Editar Placa:", "Editar", linhaSelecionada.Cells["Placa"].Value.ToString());
                linhaSelecionada.Cells["Nome"].Value = Microsoft.VisualBasic.Interaction.InputBox("Editar Nome:", "Editar", linhaSelecionada.Cells["Nome"].Value.ToString());
                linhaSelecionada.Cells["Portas"].Value = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Editar Portas:", "Editar", linhaSelecionada.Cells["Portas"].Value.ToString()));
                linhaSelecionada.Cells["Preco"].Value = decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Editar Preço:", "Editar", linhaSelecionada.Cells["Preco"].Value.ToString()));
                linhaSelecionada.Cells["DataPublicacao"].Value = DateTime.Parse(Microsoft.VisualBasic.Interaction.InputBox("Editar Data de Publicação:", "Editar", linhaSelecionada.Cells["DataPublicacao"].Value.ToString()));
                linhaSelecionada.Cells["Ativo"].Value = bool.Parse(Microsoft.VisualBasic.Interaction.InputBox("Editar Ativo (true/false):", "Editar", linhaSelecionada.Cells["Ativo"].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];

                // Função auxiliar para tratar valores nulos
                string ObterValorCelula(DataGridViewCell cell) => cell.Value?.ToString() ?? "N/A";

                // Lê os valores das colunas, usando a função para tratar nulos
                string id = ObterValorCelula(linhaSelecionada.Cells["Id"]);
                string placa = ObterValorCelula(linhaSelecionada.Cells["Placa"]);
                string nome = ObterValorCelula(linhaSelecionada.Cells["Nome"]);
                string portas = ObterValorCelula(linhaSelecionada.Cells["Portas"]);
                string preco = ObterValorCelula(linhaSelecionada.Cells["Preco"]);
                string dataPublicacao = ObterValorCelula(linhaSelecionada.Cells["DataPublicacao"]);

                // Trata o campo "Ativo" especificamente para valores booleanos
                string ativo = linhaSelecionada.Cells["Ativo"].Value != null && (bool)linhaSelecionada.Cells["Ativo"].Value ? "Ativo" : "Inativo";

                // Exibe os valores em uma mensagem
                MessageBox.Show($"ID: {id}\nPlaca: {placa}\nNome: {nome}\nPortas: {portas}\nPreço: {preco}\nData de Publicação: {dataPublicacao}\nAtivo: {ativo}", "Informações do Produto");
            }
            else{
                MessageBox.Show("Selecione uma linha para ler os dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
