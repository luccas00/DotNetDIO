using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ProjetoMVC.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? CPF { get; private set; }
        public bool? CreditoAtivo { get; set; }
        public List<Investimento>? Investimentos { get; set; }

        public Cliente()
        {
            this.Investimentos = new List<Investimento>();
            this.CreditoAtivo = false;
            this.CPF = GerarCPF();
        }
        public Cliente(string nome, string cpf)
        {
            this.Investimentos = new List<Investimento>();
            this.CreditoAtivo = false;
            this.Nome = nome;
            this.CPF = cpf;
        }

        public Cliente(string cpf)
        {
            this.Investimentos = new List<Investimento>();
            this.CreditoAtivo = false;
            this.CPF = cpf;
        }

        private string GerarCPF()
        {
            Random random = new Random();
            int[] cpf = new int[9];

            // Gere os 9 primeiros dígitos aleatoriamente
            for (int i = 0; i < 9; i++)
            {
                cpf[i] = random.Next(10);
            }

            // Calcule o primeiro dígito verificador
            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += cpf[i] * (i + 1);
            }
            int digito1 = soma1 % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            // Calcule o segundo dígito verificador
            int soma2 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma2 += cpf[i] * (i);
            }
            soma2 += digito1 * 9;
            int digito2 = soma2 % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            // Construa a string do CPF
            StringBuilder cpfBuilder = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                cpfBuilder.Append(cpf[i]);
            }
            cpfBuilder.Append(digito1);
            cpfBuilder.Append(digito2);

            return cpfBuilder.ToString();
        }
    }
}
