using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class DbInitializer
    {
        public static void Initialize(DrivingDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Drivers.Any())
            {
                return;   // DB has been seeded
            }

            var drivers = new Driver[]
            {
            new Driver{FirstName="Carson",LastName="Alexander",License=License.G},
            new Driver{FirstName="Meredith",LastName="Alonso",License=License.G},
            new Driver{FirstName="Arturo",LastName="Anand",License=License.G1},
            new Driver{FirstName="Gytis",LastName="Barzdukas",License=License.G},
            };
            foreach (Driver s in drivers)
            {
                context.Drivers.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
            {
            new Car{ID="A1",Make="Jeep",Price=300,DriverID=1},
            new Car{ID="B1",Make="Honda",Price=130,DriverID=1},
            new Car{ID="J1",Make="Mazda",Price=390,DriverID=2},
            new Car{ID="C1",Make="Fiat",Price=390,DriverID=2},
            new Car{ID="D1",Make="Subaru",Price=390,DriverID=2},
            new Car{ID="E1",Make="Toyota",Price=390,DriverID=2},
            new Car{ID="F1",Make="Mitsubishi",Price=390,DriverID=2},
            new Car{ID="G1",Make="BMW",Price=390,DriverID=2},
            new Car{ID="H1",Make="VW",Price=390,DriverID=2},
            new Car{ID="I1",Make="Dodge",Price=390,DriverID=2},
            };
            foreach (Car c in cars)
            {
                context.Cars.Add(c);
            }
            context.SaveChanges();
        }
    }
}
