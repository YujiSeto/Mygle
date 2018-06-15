﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mygle.Negocio.Persistencia;

namespace Mygle.Grafico
{
    public partial class TelaLoginMygle : Form
    {
        private const string Usuario="Usuário";
        private const string Senha = "Senha";

        public TelaLoginMygle()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Logar();
            }
        }

        private void TelaLoginMygle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
        private void Logar()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;
            
            TelaGerenteResumo tela = new TelaGerenteResumo();
            TelaUsuarioResumo tela2 = new TelaUsuarioResumo();

            if (Program.Gerenciador.ValidaUsuarioSenha(usuario, senha))
            {
                if (tbUsuario.Text == "admin")
                {
                    tela.Show();
                }
                else
                {
                    tela2.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Usuário e senha incorretos");
            }            
        }

        private void TelaLoginMygle_Load(object sender, EventArgs e)
        {

        }
    }
}
