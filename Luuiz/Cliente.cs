using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luuiz
{
    internal class Cliente
    {

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Senha { get; set; }

        public string Endereço { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"nome:{Nome}; CPF:{CPF}; Senha:{Senha}; Endereço:{Endereço};Email:{Email};";
        }

    }
}
