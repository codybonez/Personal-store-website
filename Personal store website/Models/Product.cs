namespace Personal_store_website.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductWidth { get; set; }

        public float ProductHeight { get; set; }

        public double ProductWeight { get; set; }

        public int ProductInStock { get; set; }
       
    }
}
