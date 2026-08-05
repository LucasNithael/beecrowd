using System; 

class URI {

    static void Main(string[] args) { 

        var segundos = int.Parse(Console.ReadLine());
        var horas = segundos/3600;
        var resto = segundos%3600;
        var minutos = resto/60;
        resto %= 60;

        Console.WriteLine($"{horas}:{minutos}:{resto}");

    }
}