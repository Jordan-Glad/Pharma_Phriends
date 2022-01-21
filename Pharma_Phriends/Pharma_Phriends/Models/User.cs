namespace Pharma_Phriends.Models
{
    public class User
    {
        public int User_Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Zipcode { get; set; }
        public string[] SavedDrugs { get; set; }
    }
}
