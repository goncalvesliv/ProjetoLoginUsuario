﻿using ProjetoLoginUsuario.Apresentacao;
using ProjetoLoginUsuario.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLoginUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
