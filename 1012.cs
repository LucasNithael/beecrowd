using System; 

class URI {

    static void Main(string[] args) { 

        string y = Console.ReadLine();
        string[] x = y.Split(' '); 
        double a = double.Parse(x[0]);
        double b = double.Parse(x[1]);
        double c = double.Parse(x[2]);
        
        double tri = a*c/2;
        double cir = c*c*3.14159;
        double tra = (a+b)*c/2;
        double qua = b*b;
        double ret = a*b;
        
        Console.WriteLine($"TRIANGULO: {tri:F3}");
        Console.WriteLine($"CIRCULO: {cir:F3}");
        Console.WriteLine($"TRAPEZIO: {tra:F3}");
        Console.WriteLine($"QUADRADO: {qua:F3}");
        Console.WriteLine($"RETANGULO: {ret:F3}");


    }

}
