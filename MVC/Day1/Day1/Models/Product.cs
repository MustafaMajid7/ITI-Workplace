namespace Day1.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string desc { get; set; }
        public string imgURL { get; set; }

        public Product(int id,string name,int price, string desc,string imgURL)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.desc = desc;
            this.imgURL = imgURL;
        }
    }
}
