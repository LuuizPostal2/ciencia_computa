using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luuiz
{
    public class Pedido
    {
        [Key]

        public int IdPedido { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime DataPedido { get; set; }

        public virtual ICollection<DetalheDoPedido> Preço { get; set; } = new List

        public decimal Total => Itens.Sum(i => i.Subtotal);

        public override string ToString()
        {
            return $"IdPedido: {IdPedido}, Data: {DataPedido:dd/mm/yy} 
    }
}




