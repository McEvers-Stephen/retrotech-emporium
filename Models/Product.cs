namespace RetrotechEmporium.Models
{
    public class Product
    {
        public int productId { get; set; }

        public string productName { get; set; } = string.Empty;
        public string productDescription { get; set; } = string.Empty;
        public decimal productPrice { get; set; }
        public string productImage { get; set; } = string.Empty;
        public int yearReleased { get; set; }
        public int quantityInStock { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; } = null;

    }
}
