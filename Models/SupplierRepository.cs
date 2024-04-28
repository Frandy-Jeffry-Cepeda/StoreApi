using Microsoft.EntityFrameworkCore;

namespace StoreApi.Models
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }

        public async Task<Supplier> AddAsync(Supplier Suppliers)
        {
            _context.Suppliers.Add(Suppliers);
            await _context.SaveChangesAsync();
            return Suppliers;
        }

        public async Task<Supplier> UpdateAsync(Supplier Suppliers)
        {
            _context.Entry(Suppliers).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Suppliers;
        }

        public async Task DeleteAsync(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();
            }
        }
    }
}
