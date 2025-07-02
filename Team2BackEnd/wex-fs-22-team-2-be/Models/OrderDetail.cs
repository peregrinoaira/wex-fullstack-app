namespace wex_fs_22_team_2_be.Models
{
    public class OrderDetail
    {
        public int? Id { get; set; }
        public string? OrderIdNum { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public float ProductPrice { get; set; }
        public int Quantity { get; set; }
        public float TotalPriceForProduct { get; set; }   
    }
}
