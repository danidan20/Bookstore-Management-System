using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain; // Assuming your Book model is in this namespace
using BookHaven_Bookstore_Management_System.Repository.Interfaces; // Assuming your IBookRepository is in this namespace
using BookHaven_Bookstore_Management_System.Services.interfaces; // Assuming your IBookService is in this namespace

namespace BookHaven_Bookstore_Management_System.Services.impl
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetBookById(int bookId)
        {
            return _bookRepository.GetBookById(bookId);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public void AddBook(Book book)
        {  
            _bookRepository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(int bookId)
        {
            _bookRepository.DeleteBook(bookId);
        }

        public IEnumerable<Book> SearchBooks(string searchTerm)
        {
            return _bookRepository.SearchBooks(searchTerm);
        }
    }
}