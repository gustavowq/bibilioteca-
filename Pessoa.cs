using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public static List<Pessoa> pessoas = new List<Pessoa>();


        public Pessoa() // construtor sem parâmetros
        {
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void CadastraPessoa()
        {
            Pessoa novapessoa = new Pessoa();
            Console.WriteLine(" Digite seu nome para o cadastro");
            novapessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu email");
            novapessoa.Email = Console.ReadLine();

            pessoas.Add(novapessoa);
        }


    }
}