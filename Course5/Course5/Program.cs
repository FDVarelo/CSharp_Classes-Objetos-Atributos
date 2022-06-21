using System;
using System.Globalization;

namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//Verificar quem é mais velha entre duas pessoas utilizando classes
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }*/

            /*//Salário medio
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.Write("Funcionario 1: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.Write("Funcionario 2: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double medio = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salário médio: " + medio.ToString("F2"));*/

            /*// area, perimetro e diagonal de um retangulo
            Console.WriteLine("Entre altura e largura do retângulo:");
            Retangulo ret = new Retangulo();

            ret.altura = double.Parse(Console.ReadLine());
            ret.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + ret.Area().ToString("F2"));
            Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2"));*/

            /*// Aumento de Salário, mostrar salario atual, depois o aumento que é com base no salário bruto, e esse aumento não sofre imposto, e mostrar os dados atualizados
            FuncionarioImposto func = new FuncionarioImposto();
            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"\nFuncionário: {func.nome}, $ {func.salario-func.imposto:F2}");
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"\nDados atualizados: {func.nome}, $ {((func.salario)*(1+(aumento/100)))-func.imposto:F2}");
            */

            /*// MÉDIA ALUNO, SOMA AS TRÊS NOTAS, >= 60 → APROVADO, SE NÃO → REPROVADO, E FALAR QUANTO FALTOU PARA APROVAÇÃO
            Aluno a1 = new Aluno();
            Console.Write("Nome do aluno: ");
            a1.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a1.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double final = a1.NotaFinal();
            Console.WriteLine("NOTA FINAL = " + final.ToString("F2", CultureInfo.InvariantCulture));
            if (final >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO\nFALTARAM = " + (60-final).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }*/
             
             


        }
    }
}