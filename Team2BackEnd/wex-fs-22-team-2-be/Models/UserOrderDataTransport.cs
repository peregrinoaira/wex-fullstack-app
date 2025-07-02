namespace wex_fs_22_team_2_be.Models
{
    public class UserOrderDataTransport
    {
        public List<OrderDetail> orderDetailsList { get;set;}
        public string orderNumId { get;set;}
        public float orderTotal { get;set;}
    }
}
