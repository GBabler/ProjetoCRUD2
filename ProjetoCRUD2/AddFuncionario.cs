﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoCRUD2
{
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
            /*
            txt_PesqNome.Enabled = false;
            txt_Nome.Enabled = false;
            txt_Cel.Enabled = false;
            txt_Tel.Enabled = false;
            txt_Email.Enabled = false;
            txt_End.Enabled = false;
            txt_Num.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_Rg.Enabled = false;
            txt_Cpf.Enabled = false;
            */
            
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bdProjetoCrud2;Data Source=DESKTOP-1CK831J\SQLEXPRESS";
        private string strSql = string.Empty;
        private void AddFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            txt_PesqNome.Enabled = false;
            txt_Nome.Enabled = true;
            txt_Cel.Enabled = true;
            txt_Tel.Enabled = true;
            txt_Email.Enabled = true;
            txt_End.Enabled = true;
            txt_Num.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Rg.Enabled = true;
            txt_Cpf.Enabled = true;
            */
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //EFETUA A CONEXÃO COM O BANCO DE DADOS
            strSql = "insert into funcionario (nome,telefone,celular,email,endereco,num,bairro,rg,cpf) values (@nome,@telefone,@celular,@email,@endereco,@num,@bairro,@rg,@cpf)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@nome",SqlDbType.VarChar).Value = txt_Nome.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txt_Tel.Text;
            comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = txt_Cel.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_Email.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txt_End.Text;
            comando.Parameters.Add("@num", SqlDbType.VarChar).Value = txt_Num.Text;
            comando.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txt_Bairro.Text;
            comando.Parameters.Add("@rg", SqlDbType.VarChar).Value = txt_Rg.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txt_Cpf.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_pesquisar.Enabled = true;

            txt_Nome.Clear();
            txt_Tel.Clear();
            txt_Cel.Clear();
            txt_Email.Clear();
            txt_End.Clear();
            txt_Num.Clear();
            txt_Bairro.Clear();
            txt_Rg.Clear();
            txt_Cpf.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            strSql = "SELECT TOP 1 * FROM Funcionario WHERE nome = @pesquisa";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_pesquisar.Text;
            try
            {
                if (txt_pesquisar.Text == string.Empty)
                {
                    MessageBox.Show("VOCE NÃO DIGITOU UM NOME E NEM UM CPF.");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows==false)
                {
                    throw new Exception("ESTE NOME NAO ESTA CADASTRADO");
                }

                dr.Read();

                txt_Nome.Text = Convert.ToString(dr["nome"]);
                txt_Tel.Text = Convert.ToString(dr["telefone"]);
                txt_Cel.Text = Convert.ToString(dr["celular"]);
                txt_Email.Text = Convert.ToString(dr["email"]);
                txt_End.Text = Convert.ToString(dr["endereco"]);
                txt_Num.Text = Convert.ToString(dr["num"]);
                txt_Bairro.Text = Convert.ToString(dr["bairro"]);
                txt_Rg.Text = Convert.ToString(dr["rg"]);
                txt_Cpf.Text = Convert.ToString(dr["cpf"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_pesquisar.Clear();
       
        }
    }
}
