using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;

namespace BookHaven_Bookstore_Management_System.Services.interfaces
{
    public interface ISupplierService
    {
        Supplier GetSupplierById(int supplierId);
        List<Supplier> GetAllSuppliers();
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int supplierId);
    }
}
