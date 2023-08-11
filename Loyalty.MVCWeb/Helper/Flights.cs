using System.Collections.Generic;

namespace Loyalty.MVCWeb.Helper
{
    public class Flights :IFlight, Iuser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Flights> GetFlightDetails()
        {
            var result = new List<Flights> {
                new Flights { Id= 1,Name="AirBus", Model="A380"},
                new Flights { Id = 2, Name = "Boing", Model = "777" }
                };
           return result;
        }
        public List<Flights> GetUserDetails()
        {
            var result = new List<Flights> {
                new Flights { Id= 1,Name="AirBus", Model="A380"},
                new Flights { Id = 2, Name = "Boing", Model = "777" }
                };
            return result;
        }
    }
}
