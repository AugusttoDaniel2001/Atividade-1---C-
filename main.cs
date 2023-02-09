using System;

class Program
{
    public static void Main(string[] args)
    {
        int op;
        double num1, num2, num3, soma, subtracao, multiplicacao, divisao;
        double media;
        do
        {
            Console.Clear();
            Console.WriteLine("Qual Operação desaja fazer: \n1-Soma \n2-Subtração  \n3-Multiplicação \n4-Divisão \n5-Média \n6-Sair");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro numero para a soma");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero para a soma");
                    num2 = double.Parse(Console.ReadLine());
                    soma = num1 + num2;
                    Console.WriteLine("O resultado da soma é {0} + {1} = {2}", num1, num2, soma);
                    break;
                case 2:
                    Console.WriteLine("Digite o primeiro numero para a subtração");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero para a subtração");
                    num2 = double.Parse(Console.ReadLine());
                    subtracao = num1 - num2;
                    Console.WriteLine("O resultado da soma é {0} - {1} = {2}", num1, num2, subtracao);
                    break;
                case 3:
                    Console.WriteLine("Digite o primeiro numero para a subtração");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero para a subtração");
                    num2 = double.Parse(Console.ReadLine());
                    multiplicacao = num1 * num2;
                    Console.WriteLine("O resultado da soma é {0} * {1} = {2}", num1, num2, multiplicacao);
                    break;
                case 4:
                    Console.WriteLine("Digite o primeiro numero para a subtração");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero para a subtração");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        divisao = num1 / num2;
                        Console.WriteLine("O resultado da soma é {0} / {1} = {2}", num1, num2, divisao);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel dividir por zero");
                    }
                    break;
                case 5:
                    Console.WriteLine("Digite o primeiro numero para a media");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero para a media");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro numero para a media");
                    num3 = double.Parse(Console.ReadLine());
                    media = ((num1 + num2 + num3) / 3);
                    Console.WriteLine("O resultado da media de {0},{1},{2} = {3}", num1, num2, num3, media);
                    break;
                case 6:
                    break;
              

            }
          Console.Read();
        } while (op != 6);
    }
}