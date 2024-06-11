namespace MachinexPark.app.Model
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; } = string.Empty;
        public bool MachineStatus { get; set; } = false;
        public DateTime LatestDateFromMachine { get; set; }
    }
}
