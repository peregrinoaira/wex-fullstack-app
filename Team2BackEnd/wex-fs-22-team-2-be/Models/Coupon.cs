namespace wex_fs_22_team_2_be.Models
{
    public class Coupon
    {
        public int? Id { get; set; }
        public string Name { get; set; }    
        public float AmountDiscounted { get; set; }
        public DateTime CouponStart { get; set; }
        public DateTime CouponEnd {get; set ;}
    }
}
