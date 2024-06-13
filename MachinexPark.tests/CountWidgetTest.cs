using MachinexPark.app.Model;
using MachinexPark.app.Services;

namespace MachinexPark.tests
{
    public class CountWidgetTest
    {
        [Fact]
        public void Should_return_correct_total_number_machines()
        {

            //arrange
            int expectedTotalNrMachine = 4;
            //public List<Machine> Machines { get; set; } = default!;

            var mockDataListMachines = MockDataServices.Machines;

            //act
            var actual = mockDataListMachines.Count;

            //assert
            Assert.Equal(expectedTotalNrMachine, actual);
        }
    }
}