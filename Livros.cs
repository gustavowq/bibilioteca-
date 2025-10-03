using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Bibilioteca
{

//associar emprestimo por id do livro e proucurar outros possiveis bugs

    public class Livros
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public bool disponivel = true;
        public Pessoa pessoa { get; private set; }



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
        public void CadastrarLivro(string nomeLivro) //verificar espaços em branco e valores null
        {

            if (string.IsNullOrWhiteSpace(nomeLivro))
            {
                Console.WriteLine("Cadastro inválido");
            }
            else
            {
                Livros novolivro = new Livros();

                novolivro.Nome = nomeLivro;

                novolivro.Id = contador++;
                livro.Add(novolivro);
                Console.WriteLine("O livro foi cadastrado");
            }
        }

        public void ListarLivro()  //Faz uma verificação  se o livro está disponivel antes de mostrar na tela
        {
            Console.WriteLine($"Os livros disponiveis são:");
            for (int i = 0; i != livro.Count; i++)
            {

                if (livro[i].disponivel == true)
                {
                    Console.WriteLine($" {livro[i].Nome}");
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


        public void DevolverLivro(Pessoa nomePessoa, Livros nomeLivro) //verificar se o objeto pessoa tem um livro associado e comparar se o esse livro bate com o parammetro nomeLivro 
        {

            if (nomeLivro.pessoa == nomePessoa)
            {
                nomeLivro.disponivel = true;
                nomeLivro.pessoa = null;
                Console.WriteLine("O livro foi devolvido");
            }

        }

        public static Livros BuscarLivro(string nomeLivroBuscar)
        {
            if (string.IsNullOrWhiteSpace(nomeLivroBuscar)) // verifica se recebeu um termo nullo
                return null;

            string nomeRefinado = nomeLivroBuscar.Trim().ToLowerInvariant(); //transforma o parametro em nome minisculo e retira espaços desnecessarios para comparação mais certeira

            for (int i = 0; i != livro.Count; i++)
            {
                var p = livro[i];
                if (p == null || string.IsNullOrWhiteSpace(p.Nome))
                    continue;

                if (p.Nome.Trim().ToLowerInvariant() == nomeRefinado)
                    return p; // retorna o objeto para que possa manipular de forma mais simples, sem a necessidade de pegar os dados atraves da posição na lista

            }

            return null;
        }






    }
}