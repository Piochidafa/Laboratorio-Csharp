using System;

namespace HelloWorld;

class Program { 


static void Main()


{
   

       Console.Write("Digite seu nome: ");
        var nome = Console.ReadLine();

        Console.Write("Escolha o Primeiro Numero: ");
        var nu1 = int.Parse(Console.ReadLine());
        
        Console.Write("Escolha o segundo Numero: ");
        var nu2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Deseja qual metodo de calculo:\n (+)  Adição\n (-)  Subtração\n (*) Multiplicação\n (%) - Divisão");
        var escolha = Console.Read();

        Console.Clear();    

        if (escolha == '+')
        {

            Console.Write("\n" + nome + " a resposta será = " + (nu1 + nu2) + "\n");
         
        }

        else if (escolha == '-')
        {


            Console.Write("\n" + nome + " a resposta será = " + (nu1 - nu2) + "\n");


        }

        else if (escolha == '*')
        {

            Console.Write("\n" + nome + " a resposta será = " + (nu1 * nu2) + "\n");


        }

        else if (escolha == '%')
        {
            Console.Write("\n" + nome + " a resposta será = " + (nu1 / nu2) + "\n");
           
        }

        else
        {

            Console.WriteLine("Opção invalida");

        }





}

}
