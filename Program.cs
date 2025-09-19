// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Bibilioteca;

Livros livro = new Livros(nome);

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
            livro.CadastrarLivro();   
            break;

        case "2":
            
            break;

        case "3":

            break;

        case "4":

            break;

        case "5":

            break;


    }

}

Console.WriteLine("O programa se encerrou");

  