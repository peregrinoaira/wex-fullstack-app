namespace wex_fs_22_team_2_be.Models
{
    public class UserCreateDataTransport
    {
       public bool isAdmin { get; set; }
       public int localuserid { get; set; }
       public User userToCreate { get; set; }
    }
}
