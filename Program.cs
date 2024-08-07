using Gerador_solar;

var estoque = new Estoque();
{
    estoque.AdicionarProduto(new Produto("Painel Solar", 1001, 500, "Marca A", "Painel Alpha", "Painel Solar 500W Marca A"));
    estoque.AdicionarProduto(new Produto("Painel Solar", 1002, 500, "Marca B", "Painel Omega", "Painel Solar 500W Marca B"));
    estoque.AdicionarProduto(new Produto("Painel Solar", 1003, 500, "Marca C", "Painel Beta", "Painel Solar 500W Marca C"));
    estoque.AdicionarProduto(new Produto("Controlador de Carga", 2001, 500, "Marca E", "Controlado Alpha", "Controlador de Carga 30A Marca E"));
    estoque.AdicionarProduto(new Produto("Controlador de Carga", 2002, 750, "Marca E", "Controlodor Omega", "Controlador de Carga 50A Marca E"));
    estoque.AdicionarProduto(new Produto("Controlador de Carga", 2003, 1000, "Marca D", "Controlador Beta", "Controlador de Carga 40A Marca D"));
    estoque.AdicionarProduto(new Produto("Inversor", 3001, 500, "Marca D", "Inversor Alpha", "Inversor 500W Marca D"));
    estoque.AdicionarProduto(new Produto("Inversor", 3002, 1000, "Marca D", "Inversor Omega", "Inversor 1000W Marca D"));
};

// criando csv estoque
var estoque_csv = estoque.Produtos.Select(produto => (string)produto.CsvString());
File.WriteAllLines(@"C:\Users\gabco\Gerador_solar\Gerador_solar\estoque.csv", estoque_csv);

//criando csv dos geradores construídos a partir do estoque
var componetes = new CriarGerador();
var geradores = componetes.CriarGeradores(estoque);

string caminho_arquivos = @"C:\Users\gabco\Gerador_solar\Gerador_solar\geradores.csv";
using (StreamWriter writer = new StreamWriter(caminho_arquivos))
{
    writer.WriteLine("ID do Gerador,Potência,IDs dos Produtos,Nomes dos Produtos,Quantidades dos Produtos");
    foreach (var item in geradores)
    {
        writer.WriteLine($"{item.Id_gerador},{item.Potencia_gerador},{string.Join(";", item.Id_produto)},{string.Join(";", item.Nome_produto)},{string.Join(";", item.Quantidade_produto)}");
    }
}
