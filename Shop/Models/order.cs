namespace Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? Login { get; set; }
        public int MotherboardId { get; set; }
        public int ProcessorId { get; set; }
        public int RamId { get; set; }
        public int DiskId { get; set; }
        public int VideocardId { get; set; }
        public int PowerSupplyId { get; set; }
        public int CaseId { get; set; }
        public int CoolerId { get; set; }
        public int Cost { get; set; }

        public List<Videocard> Videocards { get; set; }
        public List<Motherboard> Motherboards { get; set; }
        public List<Processor> Processors { get; set; }
        public List<Ram> Rams { get; set; }
        public List<Disk> Disks { get; set; }
        public List<PowerSupply> PowerSupplys { get; set; }
        public List<Case> Cases { get; set; }
        public List<Cooler> Coolers { get; set; }
        public List<User> Users { get; set; }

    }
}
