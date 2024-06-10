namespace MachinexPark.app.Components.Model
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineStatus { get; set; }
        public DateTime LatestDateFromMachine { get; set; }
    }
}
