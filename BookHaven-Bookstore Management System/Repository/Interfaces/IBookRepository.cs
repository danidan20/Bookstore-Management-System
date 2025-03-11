using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Repository.Interfaces
{
    public interface IBookRepository
    {
        Book GetBookById(int bookId);
        void Update(Book book);
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
        IEnumerable<Book> SearchBooks(string searchTerm);
    }
}
