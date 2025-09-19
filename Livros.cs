using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Bibilioteca
{


    public class Livros
    {
        public string Nome{ get; private set; }
        public int Id{ get; private set; }
        public bool disponivel = true; 
        public Pessoa pessoa = new Pessoa();
        

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
        public void CadastrarLivro() 
        {
            Livros novolivro = new Livros();
            Console.WriteLine("Digite o nome do livro que deseja cadastrar");
            novolivro.Nome = Console.ReadLine();

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

        public void PegarLivro() // 
        {
            Console.WriteLine("digite seu nome");
            string verificarNome = Console.ReadLine();
            bool pessoaEncontrada = false;
            string NomeLivro;
            
            for (int i = 0; i != Pessoa.pessoas.Count; i++) //
            {

                if (Pessoa.pessoas[i].Nome == verificarNome)
                {

                    pessoaEncontrada = true;
                    Console.WriteLine("Digite o nome do livro que deseja");
                    NomeLivro = Console.ReadLine();

                }

                if (pessoaEncontrada)
                {
                    bool livroEmprestado = false;
                    for (int z = 0; z != livro.Count; z++) //condição que veerifica se o livro existe/está deiponivel e empresta ele
                    {
                        if (livro[z].Nome == NomeLivro & livro[z].disponivel == true)
                        {
                            livro[z].pessoa = Pessoa.pessoas[i];
                            livro[z].disponivel = false;
                            livroEmprestado = true;
                            break;
                        }
                    }
                    if (livroEmprestado == false)
                    {
                        Console.WriteLine("Livro indisponivel");
                    }
                }
                else //caso não tenha encontrado a pessoa no cadastro, o metodo de cadastro é chamado
                {
                    Console.WriteLine("Seu nome não foi encontrado nos registro, porfavor faça o seu cadastro");
                    CadastraPessoa();
                }
            }
           
          
 

        }

        public void DevolverLivro()
        {

        }

        public void CadastraPessoa()
        {

        }
        
        

    }
}