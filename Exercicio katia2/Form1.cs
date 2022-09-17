using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_katia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }
        Jogador jog;
        Jogador[] v = new Jogador[5];
        int i = 0;

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            if (i < 5)
            {
                jog = new Jogador();
                jog.Nome = txtNome.Text;
                jog.Peso = double.Parse(txtPeso.Text);
                jog.Altura = double.Parse(txtAltura.Text);  
                jog.idade = int.Parse(txtIdade.Text);   
                jog.Numero = int.Parse(txtNumero.Text);
                jog.Time = txtTime.Text;
                v[i] = jog;
                i++;
            } 
            else
            {
                MessageBox.Show("Não é possivel gravar!");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < 5; x++)
            {
                if (v[x].Nome.Equals(txtNome.Text))
                {
                    txtPeso.Text = v[x].Peso.ToString();
                    txtAltura.Text = v[x].Altura.ToString();    
                    txtIdade.Text = v[x].idade.ToString();
                    txtNumero.Text = v[x].Numero.ToString();
                    txtTime.Text = v[x].Time;
                    x = 4;
                }
                else
                {
                    if (x == 4) MessageBox.Show("Jogador não encontrado!");
                }
            }


        }
    }
}
