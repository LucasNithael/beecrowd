using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) { 

            var valores = Console.ReadLine();
            var lista = valores.Split(' ')
            .Select(x => int.Parse(x)).ToList();
            
            // lista[0] = A
            // lista[1] = B
            // lista[2] = C
            // lista[3] = D


            if((lista[1] > lista[2]) && (lista[3] > lista[0]) && (lista[2]+lista[3] > lista[0]+lista[1]) && lista[2] > 0 && lista[3] > 0 && lista[0]%2 == 0)
            {
                Console.WriteLine("Valores aceitos");
                return;
            }

            Console.WriteLine("Valores nao aceitos");
        
    }
}