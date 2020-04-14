using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDataAccessLayer
{

    public class BookStoreDataAccessClass : IBookStoreDataAccessClass

    {

        private SqlConnection connection;
        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
            connection = new SqlConnection(constr);
        }
        public void Insert(BookMenu obj)
        {
            sqlconnection();
            string query = "insert into BookDetails values('" + obj.BookTitle + "','" + obj.Author + "','" + obj.Location + "','" + obj.Category + "'," + obj.Price + ",'" + obj.Tags + "')";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

        }
        public List<BookMenu> Display()
        {
            sqlconnection();
            List<BookMenu> nameOfBooks = new List<BookMenu>();
            string query = "select * from BookDetails";
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader datareader = cmd.ExecuteReader();
                if (!datareader.HasRows)
                {
                    connection.Close();
                }
                else
                {
                    while (datareader.Read())
                    {
                        BookMenu bookData = new BookMenu();
                        bookData.BookTitle = (string)datareader["BookTitle"];
                        bookData.Author = (string)datareader["Author"];
                        bookData.Location = (string)datareader["Location"];
                        bookData.Category = (string)datareader["Category"];
                        bookData.Price = (int)datareader["Price"];
                        bookData.Tags = (string)datareader["Tags"];

                        nameOfBooks.Add(bookData);
                    }
                    connection.Close();
                }
                return nameOfBooks;

            }
        }
        public void DeleteData(BookMenu obj)
        {
            sqlconnection();
            string query = "Delete from BookDetails values('" + obj.BookTitle + "','" + obj.Author + "','" + obj.Category + "','" + obj.Location + "'," + obj.Price + ",'" + obj.Tags + "')";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

        }

    }
}