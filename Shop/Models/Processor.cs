namespace Shop.Models
{
    public class Processor
    {
        public int ProcessorId { get; set; }
        public string Socket { get; set; }
        public string Model { get; set; }
        public int CountCores { get; set; }
        public int Frequency { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
