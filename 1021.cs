using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

            
        var valor = Console.ReadLine();
        var inteiro = int.Parse(valor.Split('.')[0]);
        var decimall = int.Parse(valor.Split('.')[1]);

        var notas = new List<int>{100, 50, 20, 10, 5, 2, 1};
        var moedas = new List<int>{50, 25, 10, 5, 1};
        var notas_resultado = new List<int>();
        var moedas_resultado = new List<int>();
        //var resto = valor;

        foreach(var nota in notas)
        {
            var parte_inteira = inteiro/nota;
            notas_resultado.Add(parte_inteira);
            inteiro %= nota;               
        }

        foreach(var moeda in moedas)
        {
            var parte_inteira = decimall/moeda;
            moedas_resultado.Add(parte_inteira);
            decimall %= moeda;               
        }

        var index = 0;
        var aux_1 = 0;
        Console.WriteLine("NOTAS:");
        foreach(var nota in notas_resultado)
        {
            if(notas[index]!=1)
            {
                Console.WriteLine($"{nota} nota(s) de R$ {notas[index]}.00");
            }
            else
            {
                aux_1 = nota;
            }

            index += 1;
        }

        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{aux_1} moeda(s) de R$ 1.00");
        index = 0;
        foreach(var moeda in moedas_resultado)
        {
            Console.WriteLine($"{moeda} moeda(s) de R$ 0.{moedas[index]:D2}");
            index += 1;
        }
        
    }
}