using System;
using System.Linq;

namespace projetocodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AppDBContext()) //Incluir instância
            {
                var listaProdutos = new System.Collections.Generic.List<Produto>
                {
                    new Produto {Nome = "Agenda" , Preço = 5.50M , Estoque = 10 },
                    new Produto {Nome = "Caneta" , Preço = 2.50m, Estoque = 20 },
                };
                contexto.Produtos.AddRange(listaProdutos); //Incluir aquela nova lista na tabela
                contexto.SaveChanges(); //Fazer com que essa alteração persista no BD
                ExibirProdutos(contexto); //chamar o método abaixo
            }
            Console.ReadLine();
        }

        private static void ExibirProdutos(AppDBContext db)
        { 
            //exibir produtos
            var Produtos = db.Produtos.ToList();
            foreach (var p in Produtos)
            {
                Console.WriteLine($"{p.Nome} {p.Preço.ToString("c")}");
            }
        }
    }
