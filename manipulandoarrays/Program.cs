using System;

namespace manipulandoarrays
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] sequencianumeros = new int[] { 10, 20, 30, 50, 60, -4,-12,-9};

            MostrarNaTela("A sequencia de numero:" + String.Join(",",  sequencianumeros));

            int maiorNumero = EncontrarMaiorNumero(sequencianumeros);

            MostrarNaTela("O maior número é: " + maiorNumero);

            int menorNumero = EncontrarMenorNumero(sequencianumeros);

            MostrarNaTela("O menor numero é: "+ menorNumero);

            decimal valorMedio = EncontrarValorMedio(sequencianumeros);

            MostrarNaTela("O valor medio da sequencia eh: " + valorMedio);

            int[] tresMaiores = TresMaioresValores(sequencianumeros);

            MostrarNaTela("Os tres maiores numeros sao:" + String.Join(", ",tresMaiores));

            int[] valoresnegativos = ValoresNegativosDaSequencia(sequencianumeros);

            MostrarNaTela("Os valores negativos são: " + String.Join(", ", valoresnegativos));

            Console.ReadLine();
        }
        static int[] ValoresNegativosDaSequencia(int[] numeros)
        {
            int quantnumeronegativo = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    quantnumeronegativo++;
                }
            }
            int[] valoresnegativos = new int [quantnumeronegativo];
            int j = 0;
            for(int i = 0;i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    valoresnegativos[j] = numeros[i];
                    j++;
                }
            }
            return valoresnegativos;
           
        }
        static int[] TresMaioresValores(int[] numeros)
        {
            //Ordenar a sequencia decrecente
            Array.Reverse(numeros);
            //Pegar somente os tres maiores
            int[] tresMaiores = new int[3];

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                 tresMaiores[i] = numeros[i];
            }
            return tresMaiores;
        }

        static decimal EncontrarValorMedio(int[] numeros)
        {
            decimal valorTotal = 0;
            decimal valorMedio = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                valorTotal = valorTotal + numeros[i];
                valorMedio = valorTotal / numeros.Length;
            }

            return valorMedio;
        }

        static int EncontrarMenorNumero(int [] numeros)
        {
            int menorNumero = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }
            return menorNumero;

        }

        static void MostrarNaTela(string mensagem)
        {
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();

        }
        static int EncontrarMaiorNumero(int[] numeros)
        {
            int maiorNumero = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];

                }
                
            }
            return maiorNumero;
        }

        
    }
    
}
