using System.Globalization;
namespace Exercicio1Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
        }

        /* 1- Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
            velha.*/ 
        static void Exercicio1() 
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite os dados da Primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da Segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
            }


        }

        static void Exercicio2()
        {
            double salarioMedio;
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro Funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo Funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario medio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
