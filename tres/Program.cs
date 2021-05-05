using System;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valido = false;
            bool idadeValida = false;
            bool salarioValido = false;
            bool estadoValido = false;

            string nome, estado;
            int idade, salario;

            do
            {
                Console.WriteLine("Insira seu nome:");
                nome = Console.ReadLine();

            if (nome != ""){
                Console.WriteLine("Boa, " + nome + " é um bom nome!");
                valido = true;
            } else{
                Console.WriteLine("Isso não é um nome válido!");
            }
            } while (valido == false);

                do
                {
                    Console.WriteLine("Insira sua idade:");
                    idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 150){
                    Console.WriteLine("Boa, " + idade + " é uma ótima idade!");
                    idadeValida = true;
                } else{
                    Console.WriteLine(idade + " não é uma idade válida");
                }
                } while (idadeValida == false);

                    do
                    {
                        Console.WriteLine("Insira seu salário:");
                        salario = int.Parse(Console.ReadLine());

                    if (salario > 0){
                        Console.WriteLine("Boa, seu salário é de R$" + salario);
                        salarioValido = true;
                    } else{
                        Console.WriteLine(salario + " não é um salário válida");
                    }
                    } while (salarioValido == false);

                        do
                        {
                            Console.WriteLine("Insira seu estado civil (Solteiro, Casado, Viuvo ou Divorciado):");
                            estado = Console.ReadLine().ToLower();

                        switch (estado)
                        {
                        case "solteiro":
                            Console.WriteLine("Seu estado civil é Solteiro, que benção!");
                            estadoValido = true;
                            break;

                        case "casado":
                            Console.WriteLine("Seu estado civil é Casado, que tristeza!");
                            estadoValido = true;
                            break;
                        
                        case "viuvo":
                            Console.WriteLine("Seu estado civil é Viuvo, meus pesamês!");
                            estadoValido = true;
                            break;

                        case "divorciado":
                            Console.WriteLine("Seu estado civil é Divorciado, se livrou de uma hein!");
                            estadoValido = true;
                            break;
                        default:
                            Console.WriteLine(estado + " não é um estado civil válido!");
                            break;
                        }
                    }

                    while (estadoValido == false);
                            Console.WriteLine("Nome: " + nome);
                            Console.WriteLine("Idade: " + idade);
                            Console.WriteLine("Salario: " + salario);
                            Console.WriteLine("Estado civil: " + estado);
        }
    }
}
