namespace StoreApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // Clave primaria
        public string Name { get; set; }
        public List<Product> Products { get; set; } // Relación uno a muchos
    }
}
