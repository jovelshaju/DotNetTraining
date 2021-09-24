using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;
using System.Web.Http.Cors;
using System.Data.SqlClient;

namespace WebApplication4.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class BookController : ApiController
    {
        //Model variables
        private static List<Book> bookList = new List<Book>();
        private static Book book = new Book();
        public int Count { get; set; }

        //Sql variables
        private static string connectionString = @"server=IND365; database=BookDB;trusted_connection=yes";
        private static SqlConnection conn = new SqlConnection(connectionString);

        //Getting total count of items in table
        public BookController()
        {
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "select COUNT(*) from Book";
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            Count = dr.GetInt32(0);
            dr.Close();
            conn.Close();
        }
        

        [HttpGet]
        public List<Book> Get()
        {
            bookList.Clear();
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from Book";
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Book book = new Book();
                    book.Id = dr.GetInt32(0);
                    book.Title = dr.GetString(1);
                    book.Author = dr.GetString(2);
                    book.Price = dr.GetInt32(3);
                    bookList.Add(book);
                }
                
            }
            else
            {
                Console.WriteLine("No rows found");
                Console.ReadLine();
            }
            dr.Close();
            conn.Close();
            return bookList;
        }

        [HttpGet]
        public Book Get(int id)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from Book where ID="+id+"";
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    book.Id = dr.GetInt32(0);
                    book.Title = dr.GetString(1);
                    book.Author = dr.GetString(2);
                    book.Price = dr.GetInt32(3);
                }

            }
            else
            {
                Console.WriteLine("No rows found");
                Console.ReadLine();
            }
            dr.Close();
            conn.Close();
            return book;
        }

        [HttpPost]
        public Book Post(Book book)
        {
            book.Id = ++Count;
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into Book (ID, Title, Author, Price) values (" + book.Id + ",'" + book.Title + "', '" + book.Author + "', "+book.Price+") ";
            int rows = comm.ExecuteNonQuery();
            conn.Close();
            return book;
        }

        [HttpPut]
        public Book Put(int id, Book book_update)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "update Book set Title='"+book_update.Title+"', Author='"+ book_update.Author+"', Price="+ book_update.Price+" where ID="+id+" ";
            int rows = comm.ExecuteNonQuery();
            conn.Close();
            return book_update;
        }

        [HttpDelete]
        public string Delete(int id)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = "delete from Book where ID=" + id + " ";
            int rows = comm.ExecuteNonQuery();
            conn.Close();
            return "Data Deleted";
        }
    }
}
