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
            Remover = 4

        }
        public Hub()
        {
            banco = new Banco();
        }

        public void Listar()
        {
            List<Produto> produtos = banco.Listar();
            foreach(Produto p in produtos) {
                Console.WriteLine("\t{0}\t{1}\t{2}", p.id, p.nome, p.preco);
            }
        }

        public void ApresentarMenu()
        {
            Console.WriteLine("Seja bem-vindo!!, o que você gostaria de fazer?");
            Console.WriteLine("1- Listar produtos");
            Console.WriteLine("2- Adicionar um produto");
            Console.WriteLine("3- Editar um produto");
            Console.WriteLine("4- Excluir um produto");

            int InputUsuario = Int32.Parse(Console.ReadLine());
            switch (InputUsuario)
            {
                case ((int)Inputs.Listar):
                    this.Listar();
                    break;
                case ((int)Inputs.Inserir):
                    break;
                case ((int)Inputs.Editar):
                    break;
                case ((int)Inputs.Remover):
                    break;
            }
        }
    }
}