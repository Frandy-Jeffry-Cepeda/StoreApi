namespace StoreApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }  // Clave primaria
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // Clave foránea de Category
        public Category Category { get; set; }
        public int SupplierId { get; set; } // Clave foránea de Supplier
        public Supplier Supplier { get; set; }
    }
}
