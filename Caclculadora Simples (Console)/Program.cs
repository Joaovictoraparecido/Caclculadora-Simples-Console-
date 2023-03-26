
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensagem de boas-vindas
            Console.WriteLine("Bem-vindo à calculadora!");

            // Pedindo o primeiro número
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            // Pedindo o segundo número
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // Pedindo a operação desejada
            Console.Write("Digite a operação desejada (+, -, *, /): ");
            string operacao = Console.ReadLine();

            // Verificando a operação desejada e calculando o resultado
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

            // Exibindo o resultado
            Console.WriteLine("O resultado da operação é: " + resultado);

            // Esperando o usuário pressionar qualquer tecla para encerrar o programa
            Console.WriteLine("Pressione qualquer tecla para encerrar o programa.");
            Console.ReadKey();
        }
    }
}


// AUTOR JOÃO VICTOR APARECIDO
// DATA  20/03/2023
//PROJETO PARA TREINAR
//OBRIGADO POR BAIXAR O MEU PROJETO