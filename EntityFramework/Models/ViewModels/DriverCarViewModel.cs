namespace EntityFramework.Models.ViewModels
{
    public class DriverCarViewModel
    {
        public IEnumerable<Driver> Drivers { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
