using System; 

class URI {

    static void Main(string[] args) { 
        

        int horas = int.Parse(Console.ReadLine());
        var velocidade = int.Parse(Console.ReadLine());
        var distancia = velocidade*horas;
        double resultado = distancia/12d;
        Console.WriteLine(resultado.ToString("F3").Replace(",", "."));

    }
}