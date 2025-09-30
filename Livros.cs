using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Bibilioteca
{


    public class Livros
    {
        public string Nome{ get; private set; }
        public int Id{ get; private set; }
        public bool disponivel = true;
        public Pessoa pessoa{ get; private set; }
        
        

        static private List<Livros> livro = new List<Livros>();

        public Livros() // construtor sem parâmetros
        {
        }

        public Livros(string nome, int id)
        {
            Nome = nome;
            Id = id;

        } 
        

        static int contador = 1;
        public void CadastrarLivro(string nomeLivro) 
        {
            Livros novolivro = new Livros();

            novolivro.Nome = nomeLivro;
           
            novolivro.Id = contador++;
            livro.Add(novolivro);
        }

        public void ListarLivro()  //Faz uma verificação  se o livro está disponivel antes de mostrar na tela
        {

            for (int i = 0; i != livro.Count; i++)
            {
                if (livro[i].disponivel == true)
                {
                    Console.WriteLine(livro[i].Nome); 
                }
            }
        }

        public static Livros PegarLivro(string nomeLivro) // guarda dentro do objeto o nome da pessoa encontrada
        {
            // verificar disponibilidade do livro 
            if (string.IsNullOrWhiteSpace(nomeLivro))
                return null;

            string nomeLivroRefinado = nomeLivro.Trim().ToLowerInvariant();

            for (int i = 0; i != livro.Count; i++)
            {
                var L = livro[i];
                if (nomeLivroRefinado == L.Nome.Trim().ToLowerInvariant() && L.disponivel == true)
              
                    return L;      
            }

            return null;
        }

        public void EmprestarLivro(Pessoa nomePessoa)
        {
            this.disponivel = false; //o "this" referencia o objeto da class
            this.pessoa = nomePessoa; // associa a proprieda pessoa da class Livros com a class Pessoa
        }


        public void DevolverLivro()
        {

        }

    
        
        

    }
}