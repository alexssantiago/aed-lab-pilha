using SensorVertebral.Dominio;
using System;

namespace SensorVertebral
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Pilha pilha = new Pilha();
                Random randNum = new Random();
                double suportado, peso, totalPeso;
                suportado = peso = totalPeso = 0;

                for (int i = 0; i <= 24; i++)
                {
                    Dado vertebra = new Dado(randNum.Next(4, 15), randNum.Next(1, 9));
                    peso = randNum.Next(2, 15);

                    if (suportado < 0)
                        suportado = vertebra.LimiteSuportado(peso + suportado);
                    else
                        suportado = vertebra.LimiteSuportado(peso);

                    totalPeso += peso;

                    pilha.Empilhar(vertebra);
                }
                suportado = VerificaLimite(pilha);

                Console.WriteLine($"Peso suportado pela coluna: {suportado}");
                Console.WriteLine($"\nPeso total empilhado: {totalPeso}");

                if (totalPeso > suportado)
                    Console.WriteLine($"\nO peso empilhado ultrapassou o limite suportado!\nAbaixe a carga!");

            } while (Console.ReadLine() == "");

            Console.ReadKey();
        }

        public static double VerificaLimite(Pilha pilha)
        {
            Elemento atual;
            double limite = 0;
            int vert = 0;
            atual = pilha.Consultar().prox;

            while (atual != null)
            {
                limite += atual.dado.limite;
                atual = atual.prox;
                vert++;
            }

            return limite;
        }
    }
}
