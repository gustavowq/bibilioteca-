using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Bibilioteca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        private static List<Pessoa> pessoas = new List<Pessoa>();


        public Pessoa() // construtor sem parâmetros
        {
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public static Pessoa CadastraPessoa(string nome, string email)
        {
            Pessoa novapessoa = new Pessoa();
            novapessoa.Nome = nome;
            novapessoa.Email = email;
            pessoas.Add(novapessoa);
            return novapessoa;
            
        }

        public static Pessoa Buscar(string nome) //descobrir qual a meneira correta de constuir uma logica funcional para o metodo
        {
            Pessoa buscar = new Pessoa();
            buscar.Nome = nome;
            if
            
        }
    }
}