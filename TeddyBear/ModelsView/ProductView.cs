namespace TeddyBear.ModelsView
{
    public class ProductView
    {
        public int IdProduct { get; set; }
        public string? Title { get; set; }
        public int? IdCategory { get; set; }
        public string? TitleCate { get; set; }
        public int IdSize { get; set; }
        public int Length { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public decimal SalePrice { get; set; }    
    }
}
