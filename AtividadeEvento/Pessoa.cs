using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeEvento
{
    public class Pessoa
    {
        
        public string Nome { get; set ;}
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Pessoa(string Nome, string Endereco, int Idade) 
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Idade = Idade;
        }

        public Pessoa()
        {

        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\nLocal: {this.Endereco}\nIdade: {this.Idade}";
        }
    }
}