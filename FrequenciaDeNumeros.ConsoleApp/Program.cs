using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        //array.sort
        static void Main(string[] args)
        {
            Console.WriteLine("Frequencia de Numeros!!!");
            Console.WriteLine("Digite a quantidade de numeros:");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());
            int [] numeros = new int [quantidadeNumeros];
            string[] apresentação = new string [quantidadeNumeros];
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.WriteLine("Digite o numero da posição " + (i + 1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.Clear();
            
            for (int i = 0; i < numeros.Length; i++)
            {
                int quantidadeVezes = 0;
                for (int j = i; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        quantidadeVezes++;
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                
                apresentação[i] = ("O nº " + numeros[i] + " aparece " + quantidadeVezes + " vez(es)");
                i += quantidadeVezes-1;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue; 
            for (int i = 0; i < apresentação.Length; i++)
            {
                if(apresentação [i] != null)
                Console.WriteLine(apresentação[i]);
            }
            /*
            while (i < array.Length)
            {
                int numero = array[i];
                int quantidadeVezes = 0;

                while (array[i] == array[j])
                {
                    quantidadeVezes++;
                    j++;

                    if (j == array.Length) //se é o ultimo elemento
                        break;
                }

                //verificar concordância
                string sufixo = (quantidadeVezes > 1) ? " vezes" : " vez";

                Console.WriteLine(numero + " apareceu " + quantidadeVezes + sufixo);

                //em algum lugar modificar o valor de "i"
                i = j;
            }*/
            Console.ReadLine();

        }
    }
}
