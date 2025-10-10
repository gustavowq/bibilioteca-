# 📚 Sistema de Biblioteca em C# (.NET)

Um projeto de console desenvolvido em **C# (.NET 8)** que simula o funcionamento de uma biblioteca, com **cadastro de usuários**, **gerenciamento de livros** e **controle de empréstimos e devoluções**.  
O objetivo é praticar **Programação Orientada a Objetos (POO)**, **organização de classes** e **operações de gerenciamento de dados**.

---

## 🚀 Funcionalidades

- 👤 **Gerenciamento de Pessoas**  
  - Cadastro de usuários com validação de nome e e-mail.  
  - Busca e verificação de usuários existentes.  

- 📘 **Gerenciamento de Livros**  
  - Cadastro e listagem de livros disponíveis.  
  - Busca de livros por nome.  
  - Controle de disponibilidade (livros emprestados ou devolvidos).  

- 🔄 **Empréstimos e Devoluções**  
  - Associação direta entre o objeto **Pessoa** e o objeto **Livro**.  
  - Bloqueio de empréstimo para livros já emprestados.  
  - Devolução com atualização automática do status do livro.  

---

## 🧠 Conceitos Aplicados

- **Programação Orientada a Objetos (POO)**  
  - Uso de classes, objetos, métodos e encapsulamento.  
- **Operações de Gerenciamento (Create, Read, Update)**  
  - Criação, busca e atualização de registros.  
- **Validação de dados** e controle de fluxo.  
- **Listas genéricas (`List<T>`)** para armazenamento dinâmico.  
- **Métodos estáticos e de instância** para modularização de funções.  
- **Boas práticas de separação de responsabilidades e estrutura de código.**

---

## 🧩 Estrutura do Projeto

```
📦 Biblioteca
 ┣ 📜 Program.cs          → Menu principal e fluxo da aplicação
 ┣ 📜 Pessoa.cs           → Classe responsável pelo cadastro e busca de pessoas
 ┣ 📜 Livros.cs           → Classe responsável pelo controle de livros e empréstimos
 ┣ 📜 Biblioteca.csproj   → Configurações do projeto .NET
 ┗ 📜 README.md           → Documentação do projeto
```

---

## 💻 Tecnologias Utilizadas

- **C# (.NET 8)**  
- **Paradigma de POO**  
- **Console Application**  
- **Git & GitHub**  

---

## 🧪 Como Executar o Projeto

1. Clone este repositório:  
   ```bash
   git clone https://github.com/gustavowq/bibilioteca-
   ```
2. Acesse o diretório:  
   ```bash
   cd bibilioteca-
   ```
3. Execute o projeto:  
   ```bash
   dotnet run
   ```

---

## 🧾 Observações

Este projeto foi desenvolvido com fins **educacionais e de prática** em **C# e Programação Orientada a Objetos**, como parte do aprendizado pessoal de desenvolvimento backend.

---

## 👨‍💻 Autor

**Gustavo Henrique Santil dos Santos**  
📧 [gustavohenriquesantil@gmail.com](mailto:gustavohenriquesantil@gmail.com)  
🔗 [Repositório no GitHub](https://github.com/gustavowq/bibilioteca-)
