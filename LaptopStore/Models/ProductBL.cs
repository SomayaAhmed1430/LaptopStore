using System.Security.Cryptography.X509Certificates;

namespace LaptopStore.Models
{
    public class ProductBL
    {
        // DB
        List<Product> products;
        public ProductBL()
        {
            products = new()
            {
                new Product() {Id = 1, Name = "Dell", Price = 10500, Img = "4.jpg"},
                new Product() {Id = 2, Name = "Hp", Price = 15900, Img = "2.jpg"},
                new Product() {Id = 3, Name = "Lenovo", Price = 25400, Img = "3.jpg"},
                new Product() {Id = 4, Name = "ThinkPad", Price = 17500, Img = "4.jpg"},
                new Product() {Id = 5, Name = "MacBook", Price = 36500, Img = "5.jpg"},
                new Product() {Id = 6, Name = "Asuc ", Price = 10000, Img = "6.jpg"},
            };
        }
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.FirstOrDefault(p=>p.Id == id);
        }
    }
}
