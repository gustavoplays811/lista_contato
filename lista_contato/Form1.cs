using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_contato
{
    public partial class Form1 : Form
        
    {
        int IdSelecionado = 0;
        // Classe Global:
        Classes.Usuario contato = new Classes.Usuario();
        public Form1()
        {
            InitializeComponent();
            DgvContatos.DataSource = contato.ListarTudo();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    DgvContatos.DataSource = usuario.ListarTudo();
                    // Limpar os campos de edição:
                    txbEmailEdi.Clear();
                    txbNomeEdi.Clear();
                    txbTelEdi.Clear();
                    lblApagar.Text = "Selecione um usuário para apagar.";
                    // Desabilitar os grbs:
                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            // Obter os valores dos txbs:
            usuario.Id = IdSelecionado;
            usuario.Nome = txbNomeEdi.Text;
            usuario.Email = txbEmailEdi.Text;
            usuario.Telefone = txbTelEdi.Text;
            usuario.Data_Aniversario = DateTime.Parse(dtpEdi.Text);


            // Editar:
            if (usuario.Modificar() == true)
            {
                MessageBox.Show("Usuário modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Atualizar o dgv:
                DgvContatos.DataSource = usuario.ListarTudo();
                // Limpar os campos de edição:
                txbEmailEdi.Clear();
                txbNomeEdi.Clear();
                txbTelEdi.Clear();
                lblApagar.Text = "Selecione um usuário para apagar.";
                // Desabilitar os grbs:
                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvContatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvContatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = DgvContatos.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = DgvContatos.Rows[linhaSelecionada];

            // Preencher os campos:
            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = linha.Cells[2].Value.ToString();
            txbTelEdi.Text = linha.Cells[3].Value.ToString();
            dtpEdi.Text = linha.Cells[4].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.Nome = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Telefone = txbTelCad.Text;
            usuario.Data_Aniversario = DateTime.Parse(dtpCad.Text);

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbTelCad.Clear();
                // Atualizar o dgv:
                DgvContatos.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }
    }
}
