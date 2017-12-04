using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta = 1;
            double saldo = 100.0;
            double valor = 110.0;
            double saldoAposSaque = saldo - valor;

            if (valor <= saldo && valor >= 0)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else {
                MessageBox.Show("Saldo Insuficiente");
            }
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeMaria = 10 ;
            int idadeJoao = 20;
            int idadeMarcos = 30;

            double media = (idadeJoao + idadeMarcos + idadeMaria) / 3;

            MessageBox.Show("Média: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 5;
            int c = 2;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("a1: " + a1);
            MessageBox.Show("a2: " + a2);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade >= 16 && brasileira == true)
            {
                MessageBox.Show("Pode Votar");
            }
            else {
                MessageBox.Show("Não pode votar");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 2000.0;
            double imposto;

            if (valorDaNotaFiscal < 1000.0) 
            {
                imposto = 0.02;
            }
            else if(valorDaNotaFiscal < 3000.0)
            {
                imposto = 0.025;
            }
            else if(valorDaNotaFiscal < 7000.0)
            {
                imposto = 0.028;
            }
            else {
                imposto = 0.03;
            }

            MessageBox.Show("Imposto Cobrado: " + imposto*100 + "%");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;
            int i = 1;
            //for (int i = 1; i <= 12; i++) 
            //{
            //    valorInvestido *= 1.01;     
            //}
            while (i <= 12)
            {
                valorInvestido *= 1.01;
                i++;
            }
            MessageBox.Show("Valor investido: " + valorInvestido);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++) { 
                soma += i;
            }

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    MessageBox.Show("O número " + i + " é um múltiplo de 3");
                }
            } 
            
            MessageBox.Show("Soma = " + soma);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            MessageBox.Show("O fatorial de 0 é 1");
            for (int n = 1; n <= 10; n++) 
            {
                fatorial = fatorial * n;
                MessageBox.Show("fatorial(" + n + ") = " + fatorial);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";
            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //int numero = 15;
            for (int numero = 1; numero <= 30; numero++ )
                if (numero % 3 == 0 || numero % 4 == 0)
                {
                    MessageBox.Show("Número divisível por 3 ou 4 é " + numero);
                }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 3 != 0) {
                    soma += i;
                }
            }
            MessageBox.Show("Soma = " + soma);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cliente danilo = new Cliente();
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = danilo;
            umaConta.saldo = 2000.0;
            umaConta.titular.cpf = "034.056.351-60";
            umaConta.agencia = 59218;

            //Conta outraConta = new Conta();
            //outraConta.numero = 2;
            //outraConta.clinte = "joaquim José";
            //outraConta.saldo = 2000.0;
            //outraConta.cpf = "034.056.351-60";
            //outraConta.agencia = 59218;

            MessageBox.Show("O saldo da conta" + umaConta.numero + " é: " + umaConta.saldo + " Cpf: " + umaConta.titular.cpf);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cliente danilo = new Cliente();
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            danilo.nome = "Danilo";
            umaConta.saldo = 5000.0;
            danilo.cpf = "034.056.351-60";
            umaConta.agencia = 59218;

            double rendimentoAnual = umaConta.CalculaRendimentoAnual();

            Cliente marcelo = new Cliente();
            Conta outraConta = new Conta();
            outraConta.numero = 2;
            marcelo.nome = "Marcelo";
            outraConta.saldo = 2000.0;
            marcelo.cpf = "031.067.345-83";
            outraConta.agencia = 59218;

            umaConta.Saca(200.0);
            umaConta.Deposita(200.0);
            umaConta.Transfere(200.0, outraConta);

            MessageBox.Show("Saldo de: " + umaConta.saldo);
            MessageBox.Show("Saldo de: " + outraConta.saldo);
            MessageBox.Show("Rendimento da Conta do Danilo " + rendimentoAnual);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            victor.nome = "victor";

            Conta umaConta = new Conta();
            umaConta.titular = victor;

            umaConta.titular.rg = "12345678-9";

            MessageBox.Show(umaConta.titular.nome);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new Conta();
            contaGuilherme.numero = 1;
            contaGuilherme.saldo = 1500.0;

            Cliente clienteGuilherme = new Cliente();
            clienteGuilherme.nome = "Guilherme";
            clienteGuilherme.idade = 18;

            contaGuilherme.titular = clienteGuilherme;

            bool sacou = contaGuilherme.Saca(300.0);//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            }
        }
    }
}
