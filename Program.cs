using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula_07._12
{
    internal class Program
    {
        public static int somarNumeros(int n1, int n2)
        {
            int soma = 0;

            soma = n1 + n2;

            return soma;
        }

        public static int subtrairNumeros(int n1, int n2)
        {
            int subtracao = 0;

            subtracao = n1 - n2;

            return subtracao;
        }

        public static int multiplicarNumeros(int n1, int n2)
        {
            int multiplicar = 0;

            multiplicar = n1 * n2;

            return multiplicar;
        }

        public static int dividirNumeros(int n1, int n2)
        {
            int dividir = 0;

            dividir = n1 / n2;

            return dividir;
        }

        public static int quadradoNumero(int n1)
        {
            int quadrado = 0;

            quadrado = n1 * n1;

            return quadrado;
        }

        public static double raizQuadrada(double n1)
        {
            double raiz = 0;

            raiz = Math.Sqrt(n1);

            return raiz;
        }

        static void Main()
        {


            /* Para este exercício use obrigatoriamente as estruturas do ... while e switch. Crie um programa que peça ciclicamente
            dois valores ao utilizador. Seguidamente, este deverá pedir a operação a realizar. Se for introduzido um 0 (zero) no
            menu o programa termina. Operações disponíveis:
            1) Soma, 2) Subtração; 3) Multiplicação; 4) Divisão; ) 0) Sair da calculadora; */

            int operacao = 0;



            do
            {

                Console.WriteLine("Selecione uma operação: 1) Soma, 2) Subtração; 3) Multiplicação; 4) Divisão; 5) Dobro 6)Raiz Quadrada 0) Sair da calculadora");
                operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        { 
                        Console.WriteLine("Introduza o primeiro valor: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduza o segundo valor: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int soma = somarNumeros(num1,num2);
                        Console.WriteLine("A soma é igual a " + soma);
                        break;
                        }
                    case 2:
                        { 
                        Console.WriteLine("Introduza o primeiro valor: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduza o segundo valor: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int subtracao = subtrairNumeros(num1, num2);
                        Console.WriteLine("A subtração é igual a " + subtracao);
                        break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Introduza o primeiro valor: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Introduza o segundo valor: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int multiplicacao = multiplicarNumeros(num1, num2);
                            Console.WriteLine("A multiplicacao de " + num1 + " e " + num2 + " é igual a " + multiplicacao);
                            break;
                        }
                        
                    case 4:
                        {
                            Console.WriteLine("Introduza o primeiro valor: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Introduza o segundo valor: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int divisao = dividirNumeros(num1, num2);
                            Console.WriteLine("A divisao de " + num1 + " e " + num2 + " é igual a " + divisao);
                            break;
                        }
                        
                    case 5:
                        {
                            Console.WriteLine("Introduza um número: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            int quadrado = quadradoNumero(numero);
                            Console.WriteLine("O dobro do numero é igual a " + quadrado);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Introduza um número: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            double raiz = raizQuadrada(numero);
                            Console.WriteLine("O raiz quadrada é igual a " + raiz);
                            break;
                        }


                }
            } while (operacao != 0);

            if (operacao == 0)
            {
                Console.WriteLine("Obrigada por utilizar a calculadora!");

            }

        }
    }
}

    