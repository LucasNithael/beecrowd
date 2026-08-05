using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        var valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        
        var notas = new List<int>{100, 50, 20, 10, 5, 2, 1};
        var notas_resultado = new List<int>();
        //var resto = valor;

        foreach(var nota in notas)
        {
            var parte_inteira = valor/nota;
            notas_resultado.Add(parte_inteira);
            valor %= nota;               
        }

        var index = 0;
        foreach(var nota in notas_resultado)
        {
            Console.WriteLine($"{nota} nota(s) de R$ {notas[index]},00");
            index += 1;
        }

    }
}