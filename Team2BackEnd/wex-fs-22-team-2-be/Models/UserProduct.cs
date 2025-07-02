namespace wex_fs_22_team_2_be.Models
{
    public class UserProduct
    {
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public float ProductPrice { get; set; }
        public float MinimiumPrice { get; set; }
    }
}
// abstract model just for user to send data back and forth