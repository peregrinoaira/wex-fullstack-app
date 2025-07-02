namespace wex_fs_22_team_2_be.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public string OrderIdNum { get; set; }
        //going to concatenate a string
        //format is DDMMXXYY
        //XX= Order type 2 digits IO = initilized order LO = live order TO = test order
        //unless manually testing or initilizing all orders will be LO
        //YY= Order incrementor resets daily (Can be linked daily to a table in DB or running counter comparing from existing orders
        //in context file
        public int UserId { get; set; }
        public float OrderTotal { get; set; }
    }

}

