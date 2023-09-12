namespace Day1.Models
{
    public class sampleProducts
    {
        List<Product> products = new List<Product>()
        {
            new Product(1,"p1",100,"desc1","img (1).jpeg"),
            new Product(2,"p2",200,"desc2","img (2).jpeg"),
            new Product(3,"p3",300,"desc3","img (3).jpeg"),
            new Product(4,"p4",400,"desc4","img (4).png")
        };

        public List<Product> getAllProducts()
        {
            return products;
        }
    }
}
