using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNotas
{
    public partial class Form1 : Form
    {
        float nota1, nota2, nota3, nota4, media;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNota1.Text))
            {
                lblSituacao.Text = "Nota 1 é obrigatória";
                return;
            }

            if (string.IsNullOrEmpty(txtNota2.Text))
            {
                lblSituacao.Text = "Nota 2 é obrigatória";
                return;
            }

            if (string.IsNullOrEmpty(txtNota3.Text))
            {
                lblSituacao.Text = "Nota 3 é obrigatória";
                return;
            }

            if (string.IsNullOrEmpty(txtNota4.Text))
            {
                lblSituacao.Text = "Nota 4 é obrigatória";
                return;
            }

            txtNota1.Text = txtNota1.Text.Replace('.', ',');
            txtNota2.Text = txtNota2.Text.Replace('.', ',');
            txtNota3.Text = txtNota3.Text.Replace('.', ',');
            txtNota4.Text = txtNota4.Text.Replace('.', ',');

            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            txtMedia.Text = Convert.ToString(media);

            if(media >= 7)
            {
                lblSituacao.Text = "APROVADO";
                lblSituacao.ForeColor = Color.Green;
            }
            else
            {
                lblSituacao.Text = "REPROVADO";
                lblSituacao.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtMedia.Clear();
            lblSituacao.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}