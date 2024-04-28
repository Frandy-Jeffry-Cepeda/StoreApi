namespace StoreApi.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; } // Clave primaria
        public string Name { get; set; }
        public List<Product> Products { get; set; } // Relación uno a muchos
    }
}
