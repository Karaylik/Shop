namespace Shop.Models
{
    public class Disk
    {
        public int DiskId { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
