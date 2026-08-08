using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    public class Tabela
    {
        public Tabela(string codigo, string espc, double valor){
            Codigo = codigo;
            Especificacao = espc;
            Valor = valor;
        }
        public string Codigo;
        public string Especificacao;
        public double Valor;
    };

    static void Main(string[] args) { 

            var entrada = Console.ReadLine();
            var tabela = new List<Tabela>{
                new Tabela("1", "Cachorro Quente", 4.00),
                new Tabela("2", "X-Salada", 4.50),
                new Tabela("3", "X-Bacon", 5.00),
                new Tabela("4", "Torrada simples", 2.00),
                new Tabela("5", "Refrigerante", 1.50),
            };

            var codigo = entrada.Split(' ')[0];        
            var quantidade = int.Parse(entrada.Split(' ')[1]);

            var item = tabela.Where(x => x.Codigo == codigo).FirstOrDefault();

            Console.WriteLine($"Total: R$ {(quantidade*item.Valor).ToString("N2").Replace(",", ".")}");        
    }
}