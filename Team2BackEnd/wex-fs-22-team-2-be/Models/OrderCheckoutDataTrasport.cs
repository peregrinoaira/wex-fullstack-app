namespace wex_fs_22_team_2_be.Models
{
    public class OrderCheckoutDataTrasport
    {
        public List<OrderDetail> OrderDetails { get; set; }
        public int UserId { get; set; }
        public float OrderTotal { get; set; }
    }
}
