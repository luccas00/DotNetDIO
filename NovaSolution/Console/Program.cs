using NovaBibliotecaDeClasses;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using Common;
using ClassesBancarias;
using Interfaces;

namespace NovaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");

            Telefone t1 = new Nokia("31988770099", "NK01");
            Telefone t2 = new Apple("11977551212", "iPhone", 128);

            t1.InstalarAplicativo("CandyCrush");
            t1.InstalarAplicativo("Telegram");
            t1.InstalarAplicativo("Youtube");
            t1.InstalarAplicativo("Instagram");
            t2.InstalarAplicativo("WhatssApp");
            t2.InstalarAplicativo("Telegram");
            t2.InstalarAplicativo("Instagram");
            t2.InstalarAplicativo("Youtube");

            t1.GetInfo();
            t2.GetInfo();

            CalculadoraPadrao cal = new CalculadoraPadrao();
            CalculadoraCientifica c2 = new CalculadoraCientifica();

            c2.Subtrair(9, 0);
            cal.Somar(3, 4);

            ExtentionsEHeranca();
            ClassesAnonimasEDinamicas();
            TuplasEDesconstrutor();
        }

        /// <summary>
        /// Metodo para agrupar os exemplos de Extenions e Herança
        /// </summary>
        public static void ExtentionsEHeranca()
        {
            //Herança
            Console.WriteLine("Hello, World!");

            Conta c1 = new ContaCorrente();
            Conta c2 = new ContaPoupanca();

            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            

            contaCorrente.Depositar(700);
            contaCorrente.Depositar(1000);
            contaPoupanca.Depositar(3000);

            Investimento i1 = new Investimento(900, 1000, 5000);
            Investimento i2 = new Investimento(111, 41000, 95000);
            Investimento i3 = new Investimento(3001, 5000, 1295000);

            contaCorrente.investimentos.Add(i1);
            contaCorrente.investimentos.Add(i2);
            contaCorrente.investimentos.Add(i3);

            contaCorrente.GetExtrato();
            Console.WriteLine();
            contaPoupanca.GetExtrato();

            c1.GetExtrato();
            Console.WriteLine();
            c1.ExibirSaldo();
            Console.WriteLine();
            c2.ExibirSaldo();

            string serializar = JsonConvert.SerializeObject(contaCorrente, Formatting.Indented);
            string serializar2 = JsonConvert.SerializeObject(contaCorrente, Formatting.Indented);

            File.WriteAllText(@"C:\DIODotNet\NovaSolution\Serializar.json", serializar);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\Serializar2.json", serializar2);

            HashSet<ContaCorrente> novoHash = new HashSet<ContaCorrente>();

            novoHash.Add(contaCorrente);


            string linhas = JsonConvert.SerializeObject(novoHash, Formatting.Indented);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\NovoHash.json", linhas);

            Aluno a1 = new Aluno();
            Pessoa p2 = new Professor(1000, "Professor");
            Pessoa p3 = new Aluno(7.5, "NovoAluno");
            Pessoa p4 = new Pessoa("Luccas", 24);

            a1.Apresentar();
            p2.Apresentar();
            p3.Apresentar();
            p4.Apresentar();


            //Extentions
            int numero = 15;
            string nome = "Luccas";
            Class1 cl1 = new Class1();

            cl1.price = 0;
            cl1.name = "Luccas";
            cl1.id = "000";

            Console.WriteLine(nome.EhLuccas());

            Console.WriteLine(numero.EhPar());

            Console.WriteLine(cl1.EhEscolhido());

            MeuArray<int> arrayInt = new MeuArray<int>();
            MeuArray<string> arrayString = new MeuArray<string>();

            arrayInt.AdicionarElemento(1);
            arrayInt.AdicionarElemento(10);
            arrayInt.AdicionarElemento(90);

            arrayString.AdicionarElemento("Luccas");
            arrayString.AdicionarElemento("Carneiro");


            Console.WriteLine(arrayInt[0]);
            Console.WriteLine(arrayInt[1]);
            Console.WriteLine(arrayInt[2]);

            Console.WriteLine(arrayString[0]);
            Console.WriteLine(arrayString[1]);



            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para agrupar os exemplos de Variaveis Anonimas e Dinamicas
        /// </summary>
        public static void ClassesAnonimasEDinamicas()
        {
            //Classes Dinamicas
            dynamic meuNome = true;
            Console.WriteLine(meuNome);

            meuNome = 99;
            Console.WriteLine(meuNome);

            meuNome = "Luccas";
            Console.WriteLine(meuNome);

            meuNome = 0000000.782394623647236471394134123;
            Console.WriteLine(meuNome);

            Class1 cl1 = new Class1(0, "Luccas", 24, 1841, "Estudante", "000");
            Class1 cl2 = new Class1(9, "Joao", 01, 777, "Teste", "999");
            Class1 cl3 = new Class1(8, "Maria", 02, 888, "NovoTeste", "888");
            Class1 cl4 = new Class1(7, "Paulo", 03, 991, "TesteNovoNovo", "746");

            meuNome = new HashSet<Class1>() { cl1, cl2, cl3, cl4 };
            Console.WriteLine(meuNome);

            foreach (Class1 c in meuNome)
            {
                Console.WriteLine(c);
            }

            string conteudo = File.ReadAllText("C:\\DIODotNet\\NovaSolution\\s1.json");

            List<Class1> lista = JsonConvert.DeserializeObject<List<Class1>>(conteudo);

            foreach (Class1 c in lista)
            {
                Console.WriteLine(c);
            }

            //Variaveis Anonimas
            var listaAnonimo = lista.Select(x => new { x.price, x.name });

            foreach (var c in listaAnonimo)
            {
                Console.WriteLine(c);
            }

            string anon = JsonConvert.SerializeObject(listaAnonimo, Formatting.Indented);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\listaAnonimo.json", anon);

            Class1 aux = JsonConvert.DeserializeObject<Class1>(conteudo);

            Console.WriteLine(aux);

            HashSet<Class1> listClass1 = new HashSet<Class1>();

            listClass1.Add(cl2);
            listClass1.Add(cl3);
            listClass1.Add(cl4);

            cl2.data = DateTime.Now;
            cl3.data = DateTime.Now;
            cl4.data = DateTime.Now;

            string s1 = JsonConvert.SerializeObject(listClass1, Formatting.Indented);
            string s2 = JsonConvert.SerializeObject(cl1, Formatting.Indented);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s1.txt", s1);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s1.json", s1);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s1.csv", s1);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s2.csv", s2);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s2.txt", s2);
            File.WriteAllText(@"C:\DIODotNet\NovaSolution\s2.json", s2);


            List<string> list = new List<string>();
            int a = 10;
            double b = 22.2;
            string nomea = "Luccas";

            cl1 = new Class1();

            cl1.number = a;

            Console.WriteLine($"Nome: {nomea}\nInt: {a}\nDouble: {b}\n");
            Console.WriteLine(cl1.ToString());
            Console.WriteLine(cl1.Somar(4, 3));



            Console.ReadKey();
        }

        //Exemplo para Tuplas e Desconstrutor
        public static void TuplasEDesconstrutor()
        {
            int a = 10;
            double b = 22.2;
            string nomea = "Luccas";

            Class1 cl1 = new Class1();

            cl1.number = a;

            Console.WriteLine($"Nome: {nomea}\nInt: {a}\nDouble: {b}\n");
            Console.WriteLine(cl1.ToString());
            Console.WriteLine(cl1.Somar(4, 3));

            //Tuplas
            (int, string, double) tupla = (0, "Luccas", 77.7);
            Tuple<int, string, double> tupla2 = new Tuple<int, string, double>(11, "Carneiro", 0.93);

            Console.WriteLine(tupla2.ToString());
            Console.WriteLine(tupla.ToString());

            //Descontrutor
            (int? number, string nome2) = cl1;

            Console.WriteLine($"{number} {nome2}");

            Console.ReadKey();
        }


    }
}


