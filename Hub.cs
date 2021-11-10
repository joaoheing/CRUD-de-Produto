using System;
using System.Collections.Generic;
using MvcProduto.Models;

namespace MvcHub
{
    class Hub
    {
        Banco banco;

        public enum Inputs
        {
            Listar = 1,
            Inserir = 2,
            Editar = 3,
            Remover = 4,
            Sair = 5

        }
        public Hub()
        {
            banco = new Banco();
        }

        public void Listar()
        {
            List<Produto> produtos = banco.Listar();
            Console.WriteLine("\tID\tNome\tPreço");
            foreach (Produto p in produtos)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", p.ID, p.Nome,p.Preco);
            }
        }

        public void Inserir()
        {
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine());
            banco.Inserir(nome, preco);
        }

        public void Remover(){
            Console.WriteLine("Digite o id do produto que deseja excluir");
            int id = int.Parse(Console.ReadLine());
            banco.Remover(id);
        }

        public void Editar(){
            Console.WriteLine("Digite o id do produto que deseja editar");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o novo preço");
            double preco = Math.Round(double.Parse(Console.ReadLine()),2);
            banco.Editar(id,nome,preco);
        }

        public void ApresentarMenu()
        {
            bool apresentarMenu = true;
            
         while(apresentarMenu)
            {
                Console.WriteLine("Seja bem-vindo!!, o que você gostaria de fazer?");
                Console.WriteLine("1- Listar produtos");
                Console.WriteLine("2- Adicionar um produto");
                Console.WriteLine("3- Editar um produto");
                Console.WriteLine("4- Excluir um produto");
                Console.WriteLine("5- Sair");
                Console.WriteLine("\n");
                
                int InputUsuario ;

                try{
                    InputUsuario = int.Parse(Console.ReadLine());
                }catch{
                    InputUsuario = 0;
                }
                    

                switch (InputUsuario)
                {
                    case ((int)Inputs.Listar):
                        this.Listar();
                        break;
                    case ((int)Inputs.Inserir):
                        this.Inserir();
                        break;
                    case ((int)Inputs.Editar):
                        this.Editar();
                        break;
                    case ((int)Inputs.Remover):
                        this.Remover();
                        break;
                    case ((int)Inputs.Sair):
                        apresentarMenu = false;
                        break;
                    default:
                        Console.WriteLine("Por favor insira um número válido");
                        break;
                }
                Console.WriteLine("\n");
            }

        }
    }
}