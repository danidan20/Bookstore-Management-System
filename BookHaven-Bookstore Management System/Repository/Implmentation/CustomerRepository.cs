using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Utils;

namespace BookHaven_Bookstore_Management_System.Repository.Implmentation
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly BookHavenDbContext _context;

        public CustomerRepository(BookHavenDbContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Customer> SearchCustomers(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return GetAllCustomers(); // Return all if no search term
            }

            return _context.Customers.Where(c => c.FirstName.Contains(searchTerm) || c.LastName.Contains(searchTerm) || c.Email.Contains(searchTerm) || c.PhoneNumber.Contains(searchTerm)).ToList();
        }
    }
}
