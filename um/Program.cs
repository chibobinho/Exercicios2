using System;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notaValida = false;

            do
            {
                Console.WriteLine("Insira uma nota de 0 a 10:");
                float nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10){
                Console.WriteLine("boa, " + nota + " é uma nota válida!");
                notaValida = true;
            } else{
                Console.WriteLine(nota + " não é uma nota válida!");
            }
            } while (notaValida == false);
        }
    }
}
