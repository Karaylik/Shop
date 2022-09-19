namespace Shop.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
