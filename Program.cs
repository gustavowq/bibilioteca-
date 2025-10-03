// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Bibilioteca;

Livros livro = new Livros();
Pessoa pessoa = new Pessoa();

Console.WriteLine("Seja bem vindo ao sistema da Bibilioteca");

int opcao = 0;

while (opcao != 6)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar livros");
    Console.WriteLine("2 - Listar livros");
    Console.WriteLine("3 - Pegar livro emprestado");
    Console.WriteLine("4 - Devolver livro");
    Console.WriteLine("5 - cadastrar pessoa");
    Console.WriteLine("6 - para sair");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite o nome do livro que deseja cadastrar");
            string nomeLivroCadastro = Console.ReadLine();
            livro.CadastrarLivro(nomeLivroCadastro);
           
            Console.WriteLine("(Pressione qualque tecla para voltar ao menu)");
            Console.ReadKey();
           
            break;

        case "2":
            livro.ListarLivro();
            Console.WriteLine("(Pressione qualque tecla para voltar ao menu)");
            Console.ReadKey(); 
            break;

        case "3":
            Console.WriteLine("Digite seu nome de usuario");
            string nomeUsuario = Console.ReadLine();
            Pessoa pessoaEncontrada = Pessoa.Buscar(nomeUsuario);

            if (pessoaEncontrada == null)
            {
                Console.WriteLine("Nome de usuario não encontrado, faça seu cadastro");
            }
            else
            {
                Console.WriteLine("Qual livro deseja pegar emprestado?");
                string nomeLivro = Console.ReadLine();
                Livros livroEncontrado = Livros.PegarLivro(nomeLivro);

                if (livroEncontrado == null)
                {
                    Console.WriteLine("Esse livro não foi encontrado ou não está disponivel no momento");
                }
                else
                {
                    livroEncontrado.EmprestarLivro(pessoaEncontrada); // pessoa encontada é um objeto e está no parametro do metodo para associação da pessoa com o livro no emprestimo
                    Console.WriteLine($" O livro {livroEncontrado.Nome} foi emprestado para {pessoaEncontrada.Nome} ");
                }
            }
            Console.WriteLine("(Pressione qualque tecla para voltar ao menu)");
            Console.ReadKey();
            
            break;

        case "4":
            Console.WriteLine("Digite seu nome de usuario");
            string nomeUsuarioDevolver = Console.ReadLine();
            Pessoa pessoaEncontradaDevolver = Pessoa.Buscar(nomeUsuarioDevolver);

            if (pessoaEncontradaDevolver == null)
            {
                Console.WriteLine("Seu cadastro não foi encontrado");
            }
            else
            {
                Console.WriteLine("Qual livro deseja devolver?");
                string nomeLivroDevolver = Console.ReadLine();
                Livros livroEncontradoDevolver = Livros.BuscarLivro(nomeLivroDevolver);
                if (livroEncontradoDevolver == null)
                {
                    Console.WriteLine("Livro não encontrado no seu cadastro");
                }
                else
                {
                    livro.DevolverLivro(pessoaEncontradaDevolver, livroEncontradoDevolver);
                }
            }
            Console.WriteLine("(Pressione qualque tecla para voltar ao menu)");
            Console.ReadKey();
            
            break;

        case "5":
            Console.WriteLine("Digite seu nome de usuario");
            string nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            string email = Console.ReadLine();
            Pessoa.CadastraPessoa(nomePessoa, email);

            Console.WriteLine("(Pressione qualque tecla para voltar ao menu)");
            Console.ReadKey();
           
            break;

        case "6":
            opcao = 6;
            break;    
    }

}

Console.WriteLine("O programa se encerrou");

  