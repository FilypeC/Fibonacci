
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o numero que deseja consultar: ");

        var consulta = int.Parse(Console.ReadLine());
        int termo1 = 0;
        int termo2 = 1;
        int termo3 = 0;

        while (termo3 <consulta) 
        {
            termo3 = termo1 + termo2;
            termo1 = termo2;
            termo2 = termo3;
        }

        if (consulta == termo3) {
            Console.WriteLine("O valor pertence a sequencia de Fibonacci");
        }
        else Console.WriteLine("O valor não pertence a sequencia de Fibonacci");

    }
}
