namespace wex_fs_22_team_2_be.Models
{
    public class Inventory
    {
        public int? Id { get; set; }
        public int ProductId { get; set; }
        public int PriceIn { get; set; }
        public int ShipmentQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
