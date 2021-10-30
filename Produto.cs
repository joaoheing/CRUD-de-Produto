

namespace MvcProduto.Models
{
    class Produto
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public double Preco {get; set;}

        public Produto(int id, string nome, double preco)
        {
            this.ID = id;
            this.Nome = nome;
            this.Preco = preco;
        }
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

    }
}
