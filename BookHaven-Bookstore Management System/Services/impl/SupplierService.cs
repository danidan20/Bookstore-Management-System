using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Repository.Interfaces;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.Services.impl
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return _supplierRepository.GetSupplierById(supplierId);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAllSuppliers();
        }

        public void AddSupplier(Supplier supplier)
        {
            _supplierRepository.AddSupplier(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _supplierRepository.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {
            _supplierRepository.DeleteSupplier(supplierId);
        }
    }
}
