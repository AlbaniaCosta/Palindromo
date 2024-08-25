using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite uma palavra: ");
            
            string palavra = Console.ReadLine();

            palavra = palavra.Replace(" ", "").ToLower();

            int tamanho = palavra.Length - 1, verificador = 0;

            for (int i = 0; i < palavra.Length; i++, tamanho--)

            {

                if (palavra[i] == palavra[tamanho])

                {

                    verificador++;

                }

            }

            if (verificador == palavra.Length)

            {

                Console.WriteLine("É palíndromo");

            }

            else

            {

                Console.WriteLine("Não é palindromo");

            }
        }
    }
}
