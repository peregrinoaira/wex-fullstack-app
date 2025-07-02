namespace wex_fs_22_team_2_be.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public float ProductPrice { get; set; }
        public float MinumunPrice { get; set; }
        public bool Discontinued { get; set; } 
        public DateTime DiscontinuedDate { get; set; }
        public  string? OnSaleId { get; set; }
        //need to convert back to an int array
        public string? CouponId { get; set; }
        //need to convert back to an int array
        public bool OnSale { get; set; } = false;
        public bool Coupon { get; set; } = false;
        public int  ProductCategoryId { get; set; }
        public int TotalInventoryCount { get; set; }
    }
}