using System; 

class URI {

    static void Main(string[] args) { 

        var dias_totais = int.Parse(Console.ReadLine());
        var anos = dias_totais/365;
        var meses = (dias_totais%365)/30;
        var dias = (dias_totais%365)%30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
        
    }
}