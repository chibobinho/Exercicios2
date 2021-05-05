using System;

namespace dois
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDeUsuario, senha;
            bool repetir = false;

            do
            {
                Console.WriteLine("Tela de cadastro!");
                Console.WriteLine("Digite seu nome de usuario:");
                nomeDeUsuario = Console.ReadLine();

                Console.WriteLine("Agora digite sua senha:");
                senha = Console.ReadLine();

            if (nomeDeUsuario != senha){
                Console.WriteLine("boa, seu cadastro foi realizado");
                repetir = true;
            } else{
                Console.WriteLine("ERROR! Seu nome de usúario é igual a sua senha, se cadastre novamente!");
            }
            } while (repetir == false);
        }
    }
}
