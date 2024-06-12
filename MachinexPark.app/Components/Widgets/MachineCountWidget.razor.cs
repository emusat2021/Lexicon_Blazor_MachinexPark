using MachinexPark.app.Services;

namespace MachinexPark.app.Components.Widgets
{
    public partial class MachineCountWidget
    {
        public int MachineCounter { get; set; }
        protected override void OnInitialized()
        {
            MachineCounter = MockDataServices.Machines.Count;
        }

    }
}