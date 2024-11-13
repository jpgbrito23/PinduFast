namespace PinduFastv1
{
    partial class FormIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Portas = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            DataPublicacao = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            btnLer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 44);
            label1.Name = "label1";
            label1.Size = new Size(280, 24);
            label1.TabIndex = 0;
            label1.Text = "Carros Disponíveis";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Placa, Nome, Portas, Preco, DataPublicacao, Ativo });
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 150);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Portas
            // 
            Portas.HeaderText = "Portas";
            Portas.Name = "Portas";
            // 
            // Preco
            // 
            Preco.HeaderText = "Preço";
            Preco.Name = "Preco";
            // 
            // DataPublicacao
            // 
            DataPublicacao.HeaderText = "Data de Publicação";
            DataPublicacao.Name = "DataPublicacao";
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(680, 315);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(450, 324);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar ";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += label1_Click;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(228, 324);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(75, 23);
            btnLer.TabIndex = 5;
            btnLer.Text = "Ler";
            btnLer.UseVisualStyleBackColor = true;
            btnLer.Click += btnLer_Click;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLer);
            Controls.Add(btnEditar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormIndex";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnAdd;
        private Button btnLer;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Portas;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn DataPublicacao;
        private DataGridViewTextBoxColumn Ativo;
    }
}
