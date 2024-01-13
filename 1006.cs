using System; 

class URI {

    static void Main(string[] args) { 

    float a = float.Parse(Console.ReadLine());
    float b = float.Parse(Console.ReadLine());
    float c = float.Parse(Console.ReadLine());
    float media = (a*2+b*3+c*5)/10;
    Console.WriteLine($"MEDIA = {media:F1}");

    }

}
