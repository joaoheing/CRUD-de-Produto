using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using MvcProduto.Models;

class Banco
{
    string connectionString = @"Data Source=DESKTOP-TB6PQLH\SQLEXPRESS;Initial Catalog=TesteIBID;Integrated Security=True";
    public List<Produto> Listar()
    {
        List<Produto> produtos = new List<Produto>();
        string queryString = "SELECT id, nome, preco FROM produto";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(new Produto((int)reader[0],(string)reader[1],(double)reader[2]));
                }
                reader.Close();
                return produtos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Produto>();
            }
        }
    }

    public void Inserir(string nomeProduto, double precoProduto)
    {
        string queryString = "INSERT INTO produto(nome,preco) VALUES(@nome,@preco)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@nome", nomeProduto);
            command.Parameters.AddWithValue("@preco", precoProduto);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public void Editar(int id, string nomeProduto, double precoProduto)
    {
        string queryString = "UPDATE produto SET nome = @nome, preco = @preco WHERE id = @id";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@nome", nomeProduto);
            command.Parameters.AddWithValue("@preco", precoProduto);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public void Remover(int id)
    {
        string queryString = "DELETE produto WHERE id = @id";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}