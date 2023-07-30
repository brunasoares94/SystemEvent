using AtividadeEvento;
using System;


class Program {
    static void Main(string[] args) {
        
            Pessoa p1 = new Pessoa("Bruna", "Rua Manoel", 28);
            Pessoa p2 = new Pessoa("Madu","Rua da Esperança", 22);
            Pessoa p3 = new Pessoa("Davi Lucca","Porto Patamares", 09);
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);


            Evento ev1 = new Evento();
            System.Console.WriteLine("Digite o nome do evento: ");
            ev1.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite o local do evento: ");
            ev1.Local = Console.ReadLine();
            ev1.verificarPagamento();
    
       
        
        }
    }

