namespace PinduFastv1
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPlaca = new TextBox();
            btnEnviar = new Button();
            txtNome = new TextBox();
            txtPortas = new TextBox();
            txtPreco = new TextBox();
            chkAtivo = new CheckBox();
            txtDataPublicacao = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(138, 74);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(138, 347);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 122);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPortas
            // 
            txtPortas.Location = new Point(138, 168);
            txtPortas.Name = "txtPortas";
            txtPortas.Size = new Size(100, 23);
            txtPortas.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(138, 209);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 5;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(138, 307);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 7;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDataPublicacao
            // 
            txtDataPublicacao.Location = new Point(138, 268);
            txtDataPublicacao.Name = "txtDataPublicacao";
            txtDataPublicacao.Size = new Size(100, 23);
            txtDataPublicacao.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 82);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 11;
            label3.Text = "Placa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 130);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 176);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 13;
            label5.Text = "Portas";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 217);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 14;
            label6.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 274);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 10;
            label2.Text = "Data de Publicação";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(262, 20);
            label8.Name = "label8";
            label8.Size = new Size(235, 24);
            label8.TabIndex = 16;
            label8.Text = "Cadastro Carros";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDataPublicacao);
            Controls.Add(chkAtivo);
            Controls.Add(txtPreco);
            Controls.Add(txtPortas);
            Controls.Add(txtNome);
            Controls.Add(btnEnviar);
            Controls.Add(txtPlaca);
            Name = "FormAdd";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPlaca;
        private Button btnEnviar;
        private TextBox txtNome;
        private TextBox txtPortas;
        private TextBox txtPreco;
        private CheckBox chkAtivo;
        private DateTimePicker txtDataPublicacao;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label8;
    }
}