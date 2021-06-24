using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoDiamantes.ConsoleApp
{
    class Program
    {
        static Dictionary<int, char> numerosLetras = new Dictionary<int, char>();
        static void Main(string[] args)
        {
            AdicionarLetras();


            //ParteDeCimaDiamante('D');
              ParteBaixa('Z');

            Console.ReadLine();
        }
        public static void AdicionarLetras()
        {
            numerosLetras.Add(1, 'A');
            numerosLetras.Add(2, 'B');
            numerosLetras.Add(3, 'C');
            numerosLetras.Add(4, 'D');
            numerosLetras.Add(5, 'E');
            numerosLetras.Add(6, 'F');
            numerosLetras.Add(7, 'G');
            numerosLetras.Add(8, 'H');
            numerosLetras.Add(9, 'I');
            numerosLetras.Add(10, 'J');
            numerosLetras.Add(11, 'K');
            numerosLetras.Add(12, 'L');
            numerosLetras.Add(13, 'M');
            numerosLetras.Add(14, 'N');
            numerosLetras.Add(15, 'O');
            numerosLetras.Add(16, 'P');
            numerosLetras.Add(17, 'Q');
            numerosLetras.Add(18, 'R');
            numerosLetras.Add(19, 'S');
            numerosLetras.Add(20, 'T');
            numerosLetras.Add(21, 'U');
            numerosLetras.Add(22, 'V');
            numerosLetras.Add(23, 'W');
            numerosLetras.Add(24, 'X');
            numerosLetras.Add(25, 'Y');
            numerosLetras.Add(26, 'Z');
        }

        public static int RetornaChaveLetra(char letra)
        {
            
            int numeroDeEspacos = 0;
            foreach (KeyValuePair<int, char> item in numerosLetras)
            {
                if (item.Value==letra)
                    numeroDeEspacos = item.Key;
            }
            return numeroDeEspacos;
        }
        public static char RetornaLetra(int numero)
        {
            char letra='o';
            foreach (KeyValuePair<int, char> item in numerosLetras)
            {
                if (item.Key == numero)
                    letra = item.Value;
            }
            return letra;
        }
        public static void ParteBaixa(char letra)
        {
            int numeroLetra = RetornaChaveLetra(letra);
            int numeroEspacoDentro = ParteDeCimaDiamante(letra);
            //parte de baixo
            for (int i = numeroLetra -1; i >= 1; i--)
            {
                //espaço de inicio
                for (int j = numeroLetra - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(numerosLetras[i].ToString());

                //espaco do meio

                for (int k = numeroEspacoDentro - 4; k > 0; k--)
                {
                    Console.Write(" ");
                }
                if (i != 1)
                {
                    Console.Write(numerosLetras[i].ToString());
                }
                Console.WriteLine();
                numeroEspacoDentro -= 2;
            }
        }
        
        public static int ParteDeCimaDiamante(char letra)
        {
            int numeroLetra = RetornaChaveLetra(letra),numeroEspacoDentro=-1;
            
            //numero de linhas
            for (int i = 1; i <= numeroLetra; i++)
            {
                //espaço de inicio
                for(int j = numeroLetra-i; j > 0 ;j--)
                {
                    Console.Write(" ");
                }
                Console.Write(numerosLetras[i].ToString());

                //espaco do meio
                
                for (int k = 0; k < numeroEspacoDentro; k++)
                {
                    Console.Write(" ");
                }
                if(i != 1)
                {
                    Console.Write(numerosLetras[i].ToString());
                }
                Console.WriteLine();
                numeroEspacoDentro += 2;
            }
            return numeroEspacoDentro;

        }

       
    }
}
