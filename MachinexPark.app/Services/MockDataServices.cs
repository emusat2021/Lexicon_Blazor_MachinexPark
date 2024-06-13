
using MachinexPark.app.Model;

namespace MachinexPark.app.Services
{
    public class MockDataServices
    {
        private static List<Machine> _machines = default!;

        public static List<Machine> Machines
        {
            get
            {
                _machines ??= InitializeMockMachines();
                return _machines;
            }
        }

        private static List<Machine> InitializeMockMachines()
        {
            var m1 = new Machine
            {
                MachineId = 1,
                MachineName = "HydraPress 3000",
                MachineStatus = false,
                LatestDateFromMachine = new DateTime(2024, 6, 11),
            };
            var m2 = new Machine
            {
                MachineId = 2,
                MachineName = "AutoCNC MillPro",
                MachineStatus = false,
                LatestDateFromMachine = new DateTime(2024, 6, 11),
            };
            var m3 = new Machine
            {
                MachineId = 3,
                MachineName = "RoboWeld XR7",
                MachineStatus = false,
                LatestDateFromMachine = new DateTime(2024, 6, 11),
            };
            var m4 = new Machine
            {
                MachineId = 4,
                MachineName = "Industrial Robotic Arm",
                MachineStatus = false,
                LatestDateFromMachine = new DateTime(2024, 6, 11),
            };
            return new List<Machine> { m1, m2, m3, m4 };
        }
    }
}
