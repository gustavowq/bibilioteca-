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
            
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email)) //verifica espaços em branco e campos null
            {
                Console.WriteLine("Cadastro invalido, nome e email são campos obrigatorios");
                return null;
            }

            for (int i = 0; i != pessoas.Count; i++) //verifica se ja esxiste um cadastro com esse email para evitar duplicatas
            {
                if (pessoas[i].Email == email)
                {
                    Console.WriteLine("Ja existe um cadastro com esse email");
                    return null;
                }
            }    
            Pessoa novapessoa = new Pessoa();
            novapessoa.Nome = nome;
            novapessoa.Email = email;
            pessoas.Add(novapessoa);
            return novapessoa; 

        }

        public static Pessoa Buscar(string nomeUsuario) //aponta o parametro para o objeto, fazer laço de repetição para verificar presença na lista
        {
            if (string.IsNullOrWhiteSpace(nomeUsuario)) // verifica se recebeu um termo nullo
                return null;

            string nomeRefinado = nomeUsuario.Trim().ToLowerInvariant(); //transforma o parametro em nome minisculo e retira espaços desnecessarios para comparação mais certeira

            for (int i = 0; i != pessoas.Count; i++)
            {
                var p = pessoas[i];
                if (p == null || string.IsNullOrWhiteSpace(p.Nome))
                    continue;

                if (p.Nome.Trim().ToLowerInvariant() == nomeRefinado)
                    return p; // retorna o objeto para que possa manipular de forma mais simples, sem a necessidade de pegar os dados atraves da posição na lista

            }

            return null;
        }
    }
}


