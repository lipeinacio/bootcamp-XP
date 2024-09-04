using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco,DateTime dataVenda )
        {
            DataVenda = dataVenda;
            Produto = produto;
            Preco = preco;
            Id = id;
        }
        
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}