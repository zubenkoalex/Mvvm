using Mvvm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models
{
    public class Database : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Generation> Generations { get; set; } = null!;
		public DbSet<Mark> Marks { get; set; } = null!;
		public DbSet<ModelCar> ModelCars { get; set; } = null!;
		public DbSet<Pacage> Pacages { get; set; } = null!;





		private static Database? instance;
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
                instance.Database.EnsureDeleted();
                var exists = instance.Database.EnsureCreated();

                instance.Cars.Load();
                instance.Generations.Load();
				instance.Marks.Load();
                instance.ModelCars.Load();
				instance.Pacages.Load();

				if (exists)
                    instance.Cars.AddRange(FlightData);
				    instance.Generations.AddRange(JetTypeData);
				    instance.Marks.AddRange(RoleData);
				    instance.ModelCars.AddRange(UserData);
					instance.Pacages.AddRange(ComfortClasseData);
					

				instance.SaveChanges();
            }
            return instance;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=zubenkoag;Database=RPM;User=user1;Password=sa;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");
        }

        static List<JetType> JetTypeData = new()
        {
            new JetType() {Name = "ТУ", SeatCapacityBusiness = 30, SeatCapacityEconomy = 150 },
			new JetType() {Name = "ИЛ", SeatCapacityBusiness = 50, SeatCapacityEconomy = 180 },
			new JetType() {Name = "AIRBUS", SeatCapacityBusiness = 150, SeatCapacityEconomy = 235 }

		};

        static List<Flight> FlightData = new()
        {
            new Flight() {Arrival="MSK", Departure="NSK", ArrivalTime=new(2024,12,3), DepartureTime = new(2024,12,2,23,0,0), JetType=JetTypeData[0],Price=1060},
			 new Flight() {Arrival="SPB", Departure="NSK", ArrivalTime=new(2024,12,3), DepartureTime = new(2024,12,2,23,0,0), JetType=JetTypeData[1],Price=5000},
			  new Flight() {Arrival="LDN", Departure="NSK", ArrivalTime=new(2024,12,3), DepartureTime = new(2024,12,2,23,0,0), JetType=JetTypeData[2],Price=15600},
			   new Flight() {Arrival="SPB", Departure="MSK", ArrivalTime=new(2024,12,3), DepartureTime = new(2024,12,2,23,0,0), JetType=JetTypeData[0],Price=6000}
		};

		static List<Role> RoleData = new()
		{
			new Role() {Name="Admin"},
			new Role() {Name="User"},
		};


		static List<ComfortClass> ComfortClasseData = new()
		{
			new ComfortClass() {Name="Эконом", Price=3000},
			new ComfortClass() {Name="Бизнес", Price=8000},

		};

		static List<User> UserData = new()
		{
			new User() {FullName="Петров Пётр Иванович", DateBorn=new(1978, 12,5), Login="admin", Password="admin", PassportNumber=8134, PassportSeries = 233455, Role = RoleData[0]},
			new User() {FullName="Иванова Маргарита Ивановна", DateBorn=new(1978, 12,5), Login="user", Password="user", PassportNumber=2112, PassportSeries = 098734, Role = RoleData[1]}

		};

		static List<Ticket> TicketData = new()
		{
			new Ticket() {User = UserData[1], Flight=FlightData[0], ComfortClass =  ComfortClasseData[0]},
			new Ticket() {User = UserData[0], Flight=FlightData[2], ComfortClass =  ComfortClasseData[1]}
		};
	}
}
