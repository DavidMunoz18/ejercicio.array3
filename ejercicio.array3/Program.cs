using System.Collections;

namespace ejercicio.array3
{
    class program
    {
        public static void Main(String[] args) 
        {
            int[] arrayEnteros = { 1, 2, 3, 4, 5, 6, 7, 8, };

            ArrayList arrayPaises = new ArrayList();

            string[] provinciasAndalucia = { "Almería", "Córdoba", "Cádiz", "Granada", "Huelva", "Jaén", "Málaga", "Sevilla" };
            
            arrayPaises.AddRange(provinciasAndalucia);

            arrayPaises.Sort();

            
            int x = 0;
           for(int i = 0;  i < arrayEnteros.Length; i++)
            {
                arrayPaises.Insert(x, arrayEnteros[i]);
                x = x + 2;
            }

           foreach(var intercalado in  arrayPaises)
            {
                Console.WriteLine(intercalado);
            }

          
        }
    }
}
