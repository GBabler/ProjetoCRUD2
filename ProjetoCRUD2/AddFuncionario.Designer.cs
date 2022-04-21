
namespace ProjetoCRUD2
{
    partial class AddFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_PesqNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_End = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Rg = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(112, 182);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(393, 23);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_PesqNome
            // 
            this.txt_PesqNome.Location = new System.Drawing.Point(112, 153);
            this.txt_PesqNome.Name = "txt_PesqNome";
            this.txt_PesqNome.Size = new System.Drawing.Size(393, 23);
            this.txt_PesqNome.TabIndex = 3;
            this.txt_PesqNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesq nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 71);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(415, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(77, 71);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(332, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 71);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(249, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 71);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(166, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 71);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Num";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "CPF";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(112, 246);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(393, 23);
            this.txt_Email.TabIndex = 18;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Tel.Location = new System.Drawing.Point(112, 213);
            this.txt_Tel.Mask = "(00)00000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(135, 23);
            this.txt_Tel.TabIndex = 19;
            // 
            // txt_Cel
            // 
            this.txt_Cel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Cel.Location = new System.Drawing.Point(370, 213);
            this.txt_Cel.Mask = "(00)00000-0000";
            this.txt_Cel.Name = "txt_Cel";
            this.txt_Cel.Size = new System.Drawing.Size(135, 23);
            this.txt_Cel.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Celular";
            // 
            // txt_End
            // 
            this.txt_End.Location = new System.Drawing.Point(112, 277);
            this.txt_End.Name = "txt_End";
            this.txt_End.Size = new System.Drawing.Size(393, 23);
            this.txt_End.TabIndex = 22;
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(112, 308);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(71, 23);
            this.txt_Num.TabIndex = 23;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(248, 308);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(257, 23);
            this.txt_Bairro.TabIndex = 24;
            // 
            // txt_Rg
            // 
            this.txt_Rg.Location = new System.Drawing.Point(112, 342);
            this.txt_Rg.Name = "txt_Rg";
            this.txt_Rg.Size = new System.Drawing.Size(169, 23);
            this.txt_Rg.TabIndex = 25;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(331, 342);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(174, 23);
            this.txt_Cpf.TabIndex = 26;
            // 
            // AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 461);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Rg);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.txt_End);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Cel);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt_PesqNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "AddFuncionario";
            this.Text = "Adicionar Funcionario";
            this.Load += new System.EventHandler(this.AddFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_PesqNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox txt_Tel;
        private System.Windows.Forms.MaskedTextBox txt_Cel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_End;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Rg;
        private System.Windows.Forms.TextBox txt_Cpf;
    }
}