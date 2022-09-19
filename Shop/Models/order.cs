namespace Shop.Models
{
    public class order
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
    }
}
