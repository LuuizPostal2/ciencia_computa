using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Produtos
    {
        public string ID { get; set; }

        public string Nome { get; set; }

        public string Entrada { get; set; }

        public string Categoria { get; set; }

        public string Preço { get; set; }

        public override string ToString()
        {
            return $"nome:{ID}; CPF:{Nome}; Senha:{Entrada}; Endereço:{Categoria};Email:{Preço};";
        }
    }
}
