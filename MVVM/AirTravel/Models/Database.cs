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

        public DbSet<Role> Roles { get; set; } = null!;


		private static Database? instance;
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
                instance.Database.EnsureDeleted();
                var exists = instance.Database.EnsureCreated();

                instance.Pacages.Load();
                instance.Generations.Load();
                instance.ModelCars.Load();
                instance.Marks.Load();
                instance.Cars.Load();
                instance.Roles.Load();


                if (exists)
                    instance.Pacages.AddRange(PacageData);
                    instance.Generations.AddRange(GenerationData);
                    instance.ModelCars.AddRange(ModelCarData);
                    instance.Marks.AddRange(MarkData);
                    instance.Cars.AddRange(CarData);
                    instance.Roles.AddRange(RoleData);
				instance.SaveChanges();
            }
            return instance;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=zubenkoag;Database=MVVM;User=user1;Password=sa;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");
        }

        static List<Pacage> PacageData = new()
        {
            new Pacage() {Id=1, FuelType="бензин", EngineVolume="1.9", EnginePower = 118, KPPType="МКПП", DriveType="задний",CallType="Седан",CallColor="Черный", Rudder="левый",NamePacage="318iMT"},
             new Pacage() {Id=2, FuelType="бензин", EngineVolume="2.2", EnginePower = 170, KPPType="АКПП", DriveType="задний",CallType="Седан",CallColor="Серебристый", Rudder="левый",NamePacage="320iAT"},
              new Pacage() {Id=3, FuelType="бензин", EngineVolume="4.4", EnginePower = 560, KPPType="робот", DriveType="задний",CallType="Седан",CallColor="Синий", Rudder="левый",NamePacage="4.4 AMT"},
               new Pacage() {Id=4, FuelType="дизель", EngineVolume="2.0", EnginePower = 190, KPPType="робот", DriveType="полный",CallType="Седан",CallColor="Красный", Rudder="левый",NamePacage="2.0 TDI"},
               new Pacage() {Id=5, FuelType="бензин", EngineVolume="3.0", EnginePower = 225, KPPType="МКПП", DriveType="задний",CallType="Седан",CallColor="Серый", Rudder="Правый",NamePacage="3.0 SZ"}
        };

        static List<Generation> GenerationData = new()
        {
            new Generation() {Id=1, NameGeneration = "1"},
            new Generation() {Id=2, NameGeneration = "1 Рест"},
            new Generation() {Id=3, NameGeneration = "2"},
            new Generation() {Id=4, NameGeneration = "2 Рест"},
            new Generation() {Id=5, NameGeneration = "3"},
            new Generation() {Id=6, NameGeneration = "3 Рест"},
            new Generation() {Id=7, NameGeneration = "4"},
            new Generation() {Id=8, NameGeneration = "4 Рест"},
            new Generation() {Id=9, NameGeneration = "5"},
            new Generation() {Id=10, NameGeneration = "5 Рест"},

        };

        static List<ModelCar> ModelCarData = new()
        {
            new ModelCar() {Id=1, NameModelCar="3-Series", GenID = GenerationData[1]},
            new ModelCar() {Id=2, NameModelCar="M5", GenID = GenerationData[10]},
            new ModelCar() {Id=3, NameModelCar="A5", GenID = GenerationData[9]},
            new ModelCar() {Id=4, NameModelCar="Supra", GenID = GenerationData[4]},
        };

        static List<Mark> MarkData = new()
        {
            new Mark() {Id=1, NameMark="BMW", ModelID = ModelCarData[1]},
            new Mark() {Id=2, NameMark="BMW", ModelID = ModelCarData[2]},
            new Mark() {Id=3, NameMark="Audi", ModelID = ModelCarData[3]},
            new Mark() {Id=4, NameMark="Toyota", ModelID = ModelCarData[4]},
        };

        static List<Car> CarData = new()
        {
            new Car() {Id = 1, MarkID = MarkData[1], Mileage = 184000,Price=2030000,ReleaseYear=2009,PacID=PacageData[1], Picture ="" },
			new Car() {Id = 2, MarkID = MarkData[1], Mileage = 84000,Price=2500000,ReleaseYear=2012,PacID=PacageData[2], Picture ="" },
            new Car() {Id = 3, MarkID = MarkData[2], Mileage = 15000,Price=4000000,ReleaseYear=2019,PacID=PacageData[3], Picture ="" },
            new Car() {Id = 4, MarkID = MarkData[3], Mileage = 44000,Price=3420000,ReleaseYear=2016,PacID=PacageData[4], Picture ="" },
            new Car() {Id = 5, MarkID = MarkData[4], Mileage = 600000,Price=1500000,ReleaseYear=1996,PacID=PacageData[5], Picture ="" },
        };

        static List<Role> RoleData = new()
        {
            new Role() {Id=1, Logins="admin",Pass="admin", Roles = "admin"},
            new Role() {Id=2, Logins="salfetka",Pass="228", Roles = "user"},
            new Role() {Id=3, Logins="pedro",Pass="1337", Roles = "user"},
        };

	
	}
}
