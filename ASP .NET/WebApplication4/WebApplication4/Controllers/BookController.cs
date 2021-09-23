using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BookController : ApiController
    {
        private static List<Book> bookList;

        public BookController()
        {
            bookList = new List<Book>() { new Book { Id = 1, Title = "Hello There", Author = "John", Price = 200 },
                                               new Book { Id = 2, Title = "Sherlock Holmes", Author = "John", Price = 800 },
                                               new Book { Id = 3, Title = "Alchemist", Author = "John", Price = 400 }};
        }
        [HttpGet]
        public List<Book> Get()
        {
            return bookList;
        }

        [HttpGet]
        public Book Get(int id)
        {
            Book book = bookList.FirstOrDefault(bk => bk.Id == id);
            return book;
        }

        [HttpPost]
        public Book Post(Book book)
        {
            book.Id = bookList.Count + 1;
            bookList.Add(book);
            return book;
        }

        [HttpPut]
        public Book Put(int id, Book book_update)
        {
            Book book = bookList.FirstOrDefault(bk => bk.Id == id);
            int index = bookList.IndexOf(book);
            bookList[index] = book_update;
            return book_update;
        }

        [HttpDelete]
        public Book Delete(int id)
        {
            Book book = bookList.FirstOrDefault(bk => bk.Id == id);
            bookList.Remove(book);
            return book;
        }
    }
}
