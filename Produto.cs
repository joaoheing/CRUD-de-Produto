

namespace MvcProduto.Models
{
    class Produto
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

    }
}
