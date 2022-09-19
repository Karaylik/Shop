namespace Shop.Models
{
    public class Cooler
    {
        public int CoolreId { get; set; }
        public int Power { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
       
        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
