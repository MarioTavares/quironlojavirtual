using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Unittest
{
    public class TesteCarrinhoCompras
    {


        [TestMethod]

        public void AdicionaItensCarrinho()
        {

            Produto produto1 = new Produto
            {

                produtoId = 1,
                Nome = "Teste1"
            };

            Produto produto2 = new Produto
            {

                produtoId = 2,
                Nome = "Teste2"
            };

            Produto produto3 = new Produto
            {

                produtoId = 3,
                Nome = "Teste3"
            };

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 2);
            carrinho.AdicionarItem(produto2, 3);
            carrinho.AdicionarItem(produto3, 3);

            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            Assert.AreEqual(itens[0].Produto, produto1);

            Assert.AreEqual(itens[1].Produto, produto2);



        }


        [TestMethod]

        public void AdicionarProdutosExistentesCarrinho()
        {

            Produto produto1 = new Produto
            {

                produtoId = 1,
                Nome = "Teste1"
            };

            Produto produto2 = new Produto
            {

                produtoId = 2,
                Nome = "Teste2"
            };


            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);

            carrinho.AdicionarItem(produto2, 1);

            carrinho.AdicionarItem(produto1, 10);

            ItemCarrinho[] resultado = carrinho.ItensCarrinho
                .OrderBy(c => c.Produto.produtoId).ToArray();

            Assert.AreEqual(resultado.Length, 2);

            Assert.AreEqual(resultado[0].Quantidade, 11);

            Assert.AreEqual(resultado[1].Quantidade, 1);



        }

        [TestMethod]

        public void RemoverItensCarrinho()
        {


            Produto produto1 = new Produto
            {

                produtoId = 1,
                Nome = "Teste1"
            };

            Produto produto2 = new Produto
            {

                produtoId = 2,
                Nome = "Teste2"
            };

            Produto produto3 = new Produto
            {

                produtoId = 3,
                Nome = "Teste3"
            };


            Carrinho carrinho = new Carrinho();


            carrinho.AdicionarItem(produto1, 1);

            carrinho.AdicionarItem(produto2, 3);

            carrinho.AdicionarItem(produto3, 5);
            //
            carrinho.AdicionarItem(produto2, 1);

            carrinho.RemoverItem(produto2);

            Assert.AreEqual(carrinho.ItensCarrinho.Where(c => c.Produto == produto2).Count(), 0);

            Assert.AreEqual(carrinho.ItensCarrinho.Count(), 0);



        }

        [TestMethod]

        public void CalcularValorTotal()
        {

            Produto produto1 = new Produto
            {
                produtoId = 1,
                Nome = "Teste 1",
                Preco = 100M

            };

            Produto produto2 = new Produto
            {
                produtoId = 2,
                Nome = "Teste 2",
                Preco = 50M
            };


            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.AdicionarItem(produto1, 3);

            decimal resultado = carrinho.ObterValorTotal();

            Assert.AreEqual(resultado, 450M);



        }

        [TestMethod]
        public void LimparItensCarrinho()
        {

            Produto produto1 = new Produto
            {
                produtoId = 1,
                Nome = "Teste 1",
                Preco = 100M

            };

            Produto produto2 = new Produto
            {
                produtoId = 2,
                Nome = "Teste 2",
                Preco = 50M
            };


            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);


            carrinho.LimparCarrino();

            Assert.AreEqual(carrinho.ItensCarrinho.Count(), 0);


        }





    }
}
