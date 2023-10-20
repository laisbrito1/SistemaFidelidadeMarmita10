using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace UserCRUD
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Pontos { get; set; }
    }

    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Cadastrar novo usuário");
                Console.WriteLine("2. Inserir código");
                Console.WriteLine("3. Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarUsuario();
                        break;
                    case "2":
                        InserirCodigo();
                        break;
                    case "3":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarUsuario()
        {
            Usuario novoUsuario = new Usuario();

            Console.WriteLine("Digite o login: ");
            novoUsuario.Login = Console.ReadLine();

            Console.WriteLine("Digite o nome: ");
            novoUsuario.Nome = Console.ReadLine();

            Console.WriteLine("Digite o email: ");
            novoUsuario.Email = Console.ReadLine();

            novoUsuario.Pontos = 0;

            usuarios.Add(novoUsuario);

            Console.WriteLine("Usuário cadastrado com sucesso.");
        }

        static void InserirCodigo()
        {
            Console.WriteLine("Digite o login: ");
            string login = Console.ReadLine();

            Usuario usuario = usuarios.Find(u => u.Login == login);

            if (usuario == null)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
            else
            {
                Console.WriteLine("Insira o código: ");
                string codigo = Console.ReadLine();

                if (codigo == "marmita10")
                {
                    usuario.Pontos++;
                    if (usuario.Pontos >= 10)
                    {
                        Console.WriteLine("Você ganhou um prêmio!");
                        usuario.Pontos = 0; // Reinicia os pontos do usuário
                    }
                    else
                    {
                        Console.WriteLine("Você ganhou um ponto de fidelidade!");
                    }
                }
                else
                {
                    Console.WriteLine("Código inválido.");
                }
            }
        }
    }
}
