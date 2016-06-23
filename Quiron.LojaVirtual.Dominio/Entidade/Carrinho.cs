using System.Collections.Generic;
using System.Linq;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class Carrinho
    {

        private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();


        // Adicionar

        public void AdicionarItem(Produto produto, int quantidade)
        {

            ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produto.produtoId == produto.produtoId);

            if (item == null)
            {

                _itemCarrinho.Add(new ItemCarrinho

                    {

                        Produto = produto,
                        Quantidade = quantidade

                    });
            }
            else
            {

                item.Quantidade += quantidade;

            }


        }


        //Remover

        public void RemoverItem(Produto produto)
        {

            _itemCarrinho.RemoveAll(l => l.Produto.produtoId == produto.produtoId);


        }


        //Obter valor total

        public decimal ObterValorTotal()
        {

            return _itemCarrinho.Sum(e => e.Produto.Preco*e.Quantidade);
        }


        //Limpar carrinho

        public void LimparCarrino()
        {

            _itemCarrinho.Clear();
        }

        //Itens do carrinho

        public IEnumerable<ItemCarrinho> ItensCarrinho
        {

            get { return _itemCarrinho; }
        }


    }


    public class ItemCarrinho
    {

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

    }



}
