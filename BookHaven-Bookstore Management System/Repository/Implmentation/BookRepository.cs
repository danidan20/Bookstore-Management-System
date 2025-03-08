using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain; // Assuming your Book model is in this namespace
using BookHaven_Bookstore_Management_System.Repository.Interfaces; // Assuming your IBookRepository is in this namespace
using BookHaven_Bookstore_Management_System.Utils; // Assuming your BookHavenDbContext is in this namespace

namespace BookHaven_Bookstore_Management_System.Repository.Implmentation
{
    public class BookRepository : IBookRepository
    {
        private readonly BookHavenDbContext _context;

        public BookRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public Book GetBookById(int bookId)
        {
            return _context.Books.Find(bookId);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            try
            {
                return _context.Books.ToList();
            }
            catch (SqlNullValueException ex)
            {
                Console.WriteLine($"SqlNullValueException retrieving books: {ex.Message}");
                return new List<Book>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General exception retrieving books: {ex.Message}");
                return new List<Book>();
            }
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.Books.Find(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Book> SearchBooks(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return GetAllBooks();
            }

            return _context.Books
                .Where(b => b.Title.Contains(searchTerm) || b.Author.Contains(searchTerm) || b.ISBN.Contains(searchTerm))
                .ToList();
        }
    }
}