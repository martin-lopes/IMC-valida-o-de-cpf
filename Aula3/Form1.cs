using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            string genero = combobox_genero.Text;
            
            string txpeso = tx_peso.Text;
            string txaltura = tx_altura.Text;
            string txidade = tx_idade.Text;
            //MessageBox.Show(" " + txpeso);
            double peso = Convert.ToDouble(txpeso);
            double altura = Convert.ToDouble(txaltura);
            double idade = Convert.ToDouble(txidade);

            Pessoa p = new Pessoa(nome, cpf, genero, peso, altura, idade);
            
            (double imc, string classificacao, string obesidade) = p.IMC();
            
            tx_resultado.Text = $"Seu IMC é: {imc.ToString("0.00")}\n" +
                $"Sua classificação é: {classificacao}\n" +
                $"Seu nível de obesidade é: {obesidade}";

            if((Validacao.ValidaCpf(cpf)) == true)
            {
                MessageBox.Show("CPF válido! ");
            }

            else
            {
                MessageBox.Show("CPF inválido! ");
            }

            //MessageBox.Show(Convert.ToString(Validacao.ValidaCpf(cpf)));
        }

        private void tx_resultado_Click(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
