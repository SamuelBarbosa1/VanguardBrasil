using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVanguardBrasil
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            Usuario usuario = new Usuario ();
            usuario.CadastrarUsuario ();

            OperacoesBancarias operacoes = new OperacoesBancarias ();

            while ( true )
            {
                Console.WriteLine ("\nOpções:");
                Console.WriteLine ("1 - Realizar depósito");
                Console.WriteLine ("2 - Realizar saque");
                Console.WriteLine ("3 - Transferir saldo para outra conta");
                Console.WriteLine ("4 - Pagar conta pendente");
                Console.WriteLine ("5 - Guardar dinheiro (render juros)");
                Console.WriteLine ("6 - Sair da conta");

                Console.Write ("Escolha uma opção: ");
                int opcao = Convert.ToInt32 (Console.ReadLine ());
                Console.Clear ();

                switch ( opcao )
                {
                    case 1:
                        operacoes.RealizarDeposito (usuario);
                        break;
                    case 2:
                        operacoes.RealizarSaque (usuario);
                        break;
                    case 3:
                        // Implemente a transferência para outra conta aqui
                        break;
                    case 4:
                        operacoes.PagarConta (usuario);
                        break;
                    case 5:
                        operacoes.RenderJuros (usuario);
                        break;
                    case 6:
                        Console.WriteLine ("Saindo da conta. Obrigado!");
                        return;
                    default:
                        Console.WriteLine ("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine ($"Saldo atual: R$ {usuario.Saldo}");
            }
        }
    }
}
