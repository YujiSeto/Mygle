﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygle.Grafico
{
    public partial class TelaGerenteResumo : Form
    {
        public TelaGerenteResumo()
        {
            InitializeComponent();
        }

        private void btDetalhe_Click(object sender, EventArgs e)
        {
            TelaGerenteDetalhe tela = new TelaGerenteDetalhe();
            tela.Show();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            TelaGerenteUsuarios tela = new TelaGerenteUsuarios();
            tela.Show();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            TelaGerenteCategorias tela = new TelaGerenteCategorias();
            tela.Show();
        }
    }
}
