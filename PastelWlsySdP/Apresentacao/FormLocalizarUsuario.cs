﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Aplicacao;

namespace PastelWlsySdP.Apresentacao
{
    public partial class FormLocalizarUsuario : Form
    {
        
        ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();
        ClassUsuario_Apl usuario_Apl = new ClassUsuario_Apl();
        public string varLoc = "";
        public DataTable selecao = new DataTable();

        public FormLocalizarUsuario()
        {
            InitializeComponent();
        }

        private void codigoTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "codigo";
            
            if (codigoTextBox.Text != null && codigoTextBox.Text != "")
            {
                usuario_Dom.Codigo = int.Parse(codigoTextBox.Text);
                localizarButton_Click(sender, e);
            }                 
        }

        private void localizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                usuario_Apl.sqlConnection = sqlConnection;
                switch (varLoc)
                {
                    case "codigo":
                        codigoDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), varLoc);
                        break;
                    case "identificador":
                        identificadorDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Identificador, varLoc);
                        break;
                    case "nome":
                        nomeDataGridView.DataSource = usuario_Apl.Localizar(usuario_Dom.Nome, varLoc);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inexperado, entrar em contato com o suporte. Para mais informações acesse o Sobre do sistema.\n\n" + error.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {

            }            
        }

        private void nomeTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "nome";

            if (nomeTextBox.Text != null && nomeTextBox.Text != "")
            {
                usuario_Dom.Nome = nomeTextBox.Text.Trim();
                localizarButton_Click(sender, e);
            }
        }

        private void identificadorTextBox_Leave(object sender, EventArgs e)
        {
            varLoc = "identificador";

            if (identificadorTextBox.Text != null && identificadorTextBox.Text != "")
            {
                usuario_Dom.Identificador = identificadorTextBox.Text.Trim();
                localizarButton_Click(sender, e);
            }
        }

        private void exibirButton_Click(object sender, EventArgs e)
        {
            selecao = new DataTable();

            try
            {
                switch (varLoc)
                {
                    case "codigo":
                        usuario_Dom.Codigo = int.Parse(codigoDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");

                        //usuario_Dom.Nome = codigoDataGridView.CurrentRow.Cells[1].Value.ToString();
                        //usuario_Dom.Identificador = codigoDataGridView.CurrentRow.Cells[2].Value.ToString();
                        //usuario_Dom.Senha = codigoDataGridView.CurrentRow.Cells[3].Value.ToString();
                        //usuario_Dom.Tipo = int.Parse(codigoDataGridView.CurrentRow.Cells[4].Value.ToString());
                        //usuario_Dom.Dt_nascimento = DateTime.Parse(codigoDataGridView.CurrentRow.Cells[5].Value.ToString());
                        //usuario_Dom.Tel = codigoDataGridView.CurrentRow.Cells[6].Value.ToString();
                        //usuario_Dom.Cel = codigoDataGridView.CurrentRow.Cells[7].Value.ToString();
                        //usuario_Dom.Email = codigoDataGridView.CurrentRow.Cells[8].Value.ToString();
                        //usuario_Dom.Logradouro = codigoDataGridView.CurrentRow.Cells[9].Value.ToString();
                        //usuario_Dom.Bairro = codigoDataGridView.CurrentRow.Cells[10].Value.ToString();
                        //usuario_Dom.Cidade = codigoDataGridView.CurrentRow.Cells[11].Value.ToString();
                        //usuario_Dom.Uf = codigoDataGridView.CurrentRow.Cells[12].Value.ToString();
                        //usuario_Dom.Cep = codigoDataGridView.CurrentRow.Cells[13].Value.ToString();
                        //usuario_Dom.Foto = codigoDataGridView.CurrentRow.Cells[14].Value.ToString();
                        break;
                    case "identificador":
                        usuario_Dom.Codigo = int.Parse(identificadorDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");

                        //usuario_Dom.Nome = identificadorDataGridView.CurrentRow.Cells[1].Value.ToString();
                        //usuario_Dom.Identificador = identificadorDataGridView.CurrentRow.Cells[2].Value.ToString();
                        //usuario_Dom.Senha = identificadorDataGridView.CurrentRow.Cells[3].Value.ToString();
                        //usuario_Dom.Tipo = int.Parse(identificadorDataGridView.CurrentRow.Cells[4].Value.ToString());
                        //usuario_Dom.Dt_nascimento = DateTime.Parse(identificadorDataGridView.CurrentRow.Cells[5].Value.ToString());
                        //usuario_Dom.Tel = identificadorDataGridView.CurrentRow.Cells[6].Value.ToString();
                        //usuario_Dom.Cel = identificadorDataGridView.CurrentRow.Cells[7].Value.ToString();
                        //usuario_Dom.Email = identificadorDataGridView.CurrentRow.Cells[8].Value.ToString();
                        //usuario_Dom.Logradouro = identificadorDataGridView.CurrentRow.Cells[9].Value.ToString();
                        //usuario_Dom.Bairro = identificadorDataGridView.CurrentRow.Cells[10].Value.ToString();
                        //usuario_Dom.Cidade = identificadorDataGridView.CurrentRow.Cells[11].Value.ToString();
                        //usuario_Dom.Uf = identificadorDataGridView.CurrentRow.Cells[12].Value.ToString();
                        //usuario_Dom.Cep = identificadorDataGridView.CurrentRow.Cells[13].Value.ToString();
                        //usuario_Dom.Foto = identificadorDataGridView.CurrentRow.Cells[14].Value.ToString();
                        break;
                    case "nome":
                        usuario_Dom.Codigo = int.Parse(nomeDataGridView.CurrentRow.Cells[0].Value.ToString());
                        selecao = usuario_Apl.Localizar(usuario_Dom.Codigo.ToString(), "codigo");

                        //usuario_Dom.Nome = nomeDataGridView.CurrentRow.Cells[1].Value.ToString();
                        //usuario_Dom.Identificador = nomeDataGridView.CurrentRow.Cells[2].Value.ToString();
                        //usuario_Dom.Senha = nomeDataGridView.CurrentRow.Cells[3].Value.ToString();
                        //usuario_Dom.Tipo = int.Parse(nomeDataGridView.CurrentRow.Cells[4].Value.ToString());
                        //usuario_Dom.Dt_nascimento = DateTime.Parse(nomeDataGridView.CurrentRow.Cells[5].Value.ToString());
                        //usuario_Dom.Tel = nomeDataGridView.CurrentRow.Cells[6].Value.ToString();
                        //usuario_Dom.Cel = nomeDataGridView.CurrentRow.Cells[7].Value.ToString();
                        //usuario_Dom.Email = nomeDataGridView.CurrentRow.Cells[8].Value.ToString();
                        //usuario_Dom.Logradouro = nomeDataGridView.CurrentRow.Cells[9].Value.ToString();
                        //usuario_Dom.Bairro = nomeDataGridView.CurrentRow.Cells[10].Value.ToString();
                        //usuario_Dom.Cidade = nomeDataGridView.CurrentRow.Cells[11].Value.ToString();
                        //usuario_Dom.Uf = nomeDataGridView.CurrentRow.Cells[12].Value.ToString();
                        //usuario_Dom.Cep = nomeDataGridView.CurrentRow.Cells[13].Value.ToString();
                        //usuario_Dom.Foto = nomeDataGridView.CurrentRow.Cells[14].Value.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro inexperado, entrar em contato com o suporte. Para mais informações acesse o Sobre do sistema.\n\n" + error.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
