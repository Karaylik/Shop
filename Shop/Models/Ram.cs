namespace Shop.Models
{
    public class Ram
    {
        public int RamId { get; set; }
        public string Model { get; set; }
        public int Frequency { get; set; }
        public int Size { get; set; }
        public string TypeOfRam { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
