namespace Shop.Models
{
    public class Videocard
    {
        public int VideocardId { get; set; }
        public int TypeVram { get; set; }
        public int SizeVram { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Frequency { get; set; }
        public int Count { get; set; }


        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
