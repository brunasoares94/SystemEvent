using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeEvento
{
    public class Evento
    {
        public String Nome {get; set;}
        public String Local {get; set;}
        public Double Valor {get; set;}
        private List<Pessoa> pessoas;

        public List<Pessoa> Pessoas
        {
            get
            {
                return pessoas;
            }
            set
            {
                List<Pessoa> pessoas = value;
                if (pessoas.Count > 20)
                {
                    this.pessoas = pessoas;
                }
                else
                {
                    Console.WriteLine("Limite de pessoas por excedido!");
                }
            }
        }
        public void verificarPagamento(){
            System.Console.WriteLine("Evento será pago?");
            if(string.Equals("sim",Console.ReadLine(),StringComparison.OrdinalIgnoreCase)){
                System.Console.WriteLine("Qual o valor do Ingresso do evento");
                if(double.TryParse(Console.ReadLine(), out double valor)){
                    this.Valor = valor;
                    System.Console.WriteLine("O Valor do ingresso é {this.Valor}");
                }else{
                    System.Console.WriteLine("Valor inválido!");
                    verificarPagamento();
                }
            }else 
            if(string.Equals("nao",Console.ReadLine(),StringComparison.OrdinalIgnoreCase)||(string.Equals("não",Console.ReadLine(),StringComparison.OrdinalIgnoreCase))){
                this.Valor = 0;
            }else{
                System.Console.WriteLine("Opção Inválida");
            }
        }
        public void listarPessoas(){
            Console.WriteLine("Listando Convidados");
            
            foreach (var item in pessoas)
            {
                System.Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\nLocal: {this.Local}\nValor: {this.Valor}";
        }
        
    }
}