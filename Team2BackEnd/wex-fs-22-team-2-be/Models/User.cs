namespace wex_fs_22_team_2_be.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool IsShopKeeper { get; set; } = false;
        public bool IsCustomer { get; set; } = true;
        public int Token { get; set; }
        public bool IsLoggedIn { get; set; } = false;
    }
}
