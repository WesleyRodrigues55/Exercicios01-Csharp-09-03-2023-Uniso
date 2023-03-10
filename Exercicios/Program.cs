using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercico1();
            exercico2();
            exercicio3();
        }

        static void exercico1()
        {
            int convidadosNoivo = 0;
            int convidadosNoiva = 0;
            int convidadosPresentesNoivo = 0;
            int convidadosPresentesNoiva = 0;

            Console.WriteLine("Digite a quantidade de convidados do noivo:");
            convidadosNoivo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de convidados do noiva:");
            convidadosNoiva = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de convidados presentes do noivo:");
            convidadosPresentesNoivo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de convidados presentes da noiva:");
            convidadosPresentesNoiva = Convert.ToInt16(Console.ReadLine());

            if (convidadosNoiva < convidadosNoivo)
            {
                Console.WriteLine("O número de convidados do noivo são maiores do que o do noiva!");
            }
            else if (convidadosNoiva > convidadosNoivo)
            {
                Console.WriteLine("O número de convidados da noiva são maiores do que o do noivo!");
            } else
            {
                Console.WriteLine("O número de convidados da noiva e do noivo são iguais");
            }

            if (convidadosNoivo < convidadosPresentesNoivo)
            {
                Console.WriteLine("Há penetras na festa presentes da parte do noivo!");
            }
            else
            {
                Console.WriteLine("Não há penetras na festa presentes da parte do noivo!");
            }

            if (convidadosNoiva < convidadosPresentesNoiva)
            {
                Console.WriteLine("Há penetras na festa presentes da parte da noiva!");
            }
            else
            {
                Console.WriteLine("Não há penetras na festa presentes da parte da noiva!");
            }
        }

        static void exercico2()
        {
            // com um array
            string[] convidadosArray = new string[4];
            convidadosArray[0] = "Grazieli";
            convidadosArray[1] = "Wesley Rodrigues";
            convidadosArray[2] = "João Oliveira";
            convidadosArray[3] = "Wesley Pontes";
            Console.WriteLine("Convidados feito com array: \n");
            for (int i = 0; i < convidadosArray.Length; i++)
            {
                Console.WriteLine($"Convidado {i + 1}: {convidadosArray[i]}");
            }

            // com a lista
            List<string> convidadosLista = new List<string>();
            convidadosLista.Add("Grazieli");
            convidadosLista.Add("Wesley Rodrigues");
            convidadosLista.Add("João Oliveira");
            convidadosLista.Add("Wesley Pontes");

            Console.WriteLine("\n\n");
            Console.WriteLine("Convidados feito com lista: \n");
            for (int i = 0; i < convidadosLista.Count; i++)
            {
                Console.WriteLine($"Convidado {i + 1}: {convidadosLista[i]}");
            }
        }

        static void exercicio3()
        {
            List<string> frutas = new List<string>();
            int count = 0;
            do
            {
                Console.WriteLine("Digite 1 para adicionar uma fruta \n" +
                    "Digite 0(zero) para exibir a lista e finalizar!");
                string entrada = Console.ReadLine();

                if (entrada == "1")
                {
                    Console.WriteLine("\n Digite o nome de uma fruta: ");
                    string entrada2 = Console.ReadLine();
                    string entradaMinisculo = entrada2.ToLower();
                    string entradaPrimeiraLetra = entradaMinisculo.Substring(0, 1).ToUpper();
                    string entradaRestante = entradaMinisculo.Substring(1);
                    string entradaFinal = entradaPrimeiraLetra + entradaRestante;
                    
                    frutas.Add(entradaFinal);
                    Console.WriteLine("Fruta adicionada! \n");

                   

                } else if (entrada == "0")
                {
                    Console.WriteLine("A lista de frutas é: \n");
                    for (int i = 0; i < frutas.Count;i++)
                    {
                        Console.WriteLine(frutas[i]);
                    }
                    count = 1;
                }
            } while (count != 1);
            

        }
    }
}
