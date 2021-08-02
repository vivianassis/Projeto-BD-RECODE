# Projeto-BD-RECODE
Projeto de banco de dados em C# com .NET e EF Core.

PS.: Estou com problema dando nessa parte:
//linha 23 do Program.cs

private static void ExibirProdutos(AppDBContext db)          //exibir produtos
        {
            var Produtos = db.Produtos.ToList();
            foreach (var p in produtos)
            {
                Console.WriteLine(p.Nome + "\t" + p.Preço.ToString{"c"});
            }
        }
        
        
Se alguém tiver uma luz, agradeço.        
