using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVanguardBrasil
{
     class Usuario
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public double Saldo { get; set; }

        public void CadastrarUsuario ()
        {
            Console.WriteLine ("                           Sejam Bem vindos ao Banco Vanguard Brasil");
            Console.WriteLine ("Cadastro de Usuário");
            Console.Write ("Nome completo: ");
            NomeCompleto = Console.ReadLine ();

            Console.Write ("CPF: ");
            CPF = Console.ReadLine ();

            Console.Write ("Data de nascimento (dd/mm/aaaa): ");
            DataNascimento = Console.ReadLine ();
            Console.Clear ();
        }
    }
}
