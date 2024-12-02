using Duvalin.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models
{
    public class Database : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Generation> Generations { get; set; } = null!;
        public DbSet<Mark> Marks { get; set; } = null!;
        public DbSet<ModelCar> ModelCars { get; set; } = null!;
        public DbSet<Pacage> Pacages { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;


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
                instance.Users.Load();


                if (exists)
                    instance.Pacages.AddRange(PacageData);
                    instance.Generations.AddRange(GenerationData);
                    instance.ModelCars.AddRange(ModelCarData);
                    instance.Marks.AddRange(MarkData);
                    instance.Cars.AddRange(CarData);
                    instance.Users.AddRange(UserData);
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
            new Pacage() {FuelType="бензин", EngineVolume="1.9", EnginePower = 118, KPPType="МКПП", DriveType="задний",CallType="Седан",CallColor="Черный", Rudder="левый",NamePacage="318iMT"},
            new Pacage() {FuelType="бензин", EngineVolume="2.2", EnginePower = 170, KPPType="АКПП", DriveType="задний",CallType="Седан",CallColor="Серебристый", Rudder="левый",NamePacage="320iAT"},
            new Pacage() {FuelType="бензин", EngineVolume="4.4", EnginePower = 560, KPPType="робот", DriveType="задний",CallType="Седан",CallColor="Синий", Rudder="левый",NamePacage="4.4 AMT"},
            new Pacage() {FuelType="дизель", EngineVolume="2.0", EnginePower = 190, KPPType="робот", DriveType="полный",CallType="Седан",CallColor="Красный", Rudder="левый",NamePacage="2.0 TDI"},
            new Pacage() {FuelType="бензин", EngineVolume="3.0", EnginePower = 225, KPPType="МКПП", DriveType="задний",CallType="Седан",CallColor="Серый", Rudder="Правый",NamePacage="3.0 SZ"}
        };

        static List<Generation> GenerationData = new()
        {
            new Generation() { NameGeneration = "1"},
            new Generation() { NameGeneration = "1 Рест"},
            new Generation() {NameGeneration = "2"},
            new Generation() {NameGeneration = "2 Рест"},
            new Generation() {NameGeneration = "3"},
            new Generation() {NameGeneration = "3 Рест"},
            new Generation() {NameGeneration = "4"},
            new Generation() {NameGeneration = "4 Рест"},
            new Generation() {NameGeneration = "5"},
            new Generation() {NameGeneration = "5 Рест"},

        };

        static List<ModelCar> ModelCarData = new()
        {
            new ModelCar() { NameModelCar="3-Series"},
            new ModelCar() {NameModelCar="M5"},
            new ModelCar() {NameModelCar="A5"},
            new ModelCar() {NameModelCar="Supra"},
        };  

        static List<Mark> MarkData = new()
        {
            new Mark() {NameMark="BMW" },
            new Mark() {NameMark="BMW"},
            new Mark() {NameMark="Audi"},
            new Mark() {NameMark="Toyota"},
        };

        static List<Car> CarData = new()
        {
            new Car() { Mark = MarkData[1], Mileage = 184000,Price=2030000,ReleaseYear=2009,Pacage=PacageData[1], Picture ="C:\\Users\\Александр\\Desktop\\Учеба\\Дувалин Курсач\\Пикчи\\3series_chorni.jpeg"},
            new Car() {Mark = MarkData[1], Mileage = 84000,Price=2500000,ReleaseYear=2012,Pacage=PacageData[2], Picture ="C:\\Users\\Александр\\Desktop\\Учеба\\Дувалин Курсач\\Пикчи\\3series_serai.jpg"},
            new Car() {Mark = MarkData[2], Mileage = 15000,Price=4000000,ReleaseYear=2019,Pacage=PacageData[3], Picture ="C:\\Users\\Александр\\Desktop\\Учеба\\Дувалин Курсач\\Пикчи\\a5.jpeg"},
            new Car() {Mark = MarkData[3], Mileage = 44000,Price=3420000,ReleaseYear=2016,Pacage=PacageData[4], Picture ="C:\\Users\\Александр\\Desktop\\Учеба\\Дувалин Курсач\\Пикчи\\m5.jpeg"},
            new Car() {Mark = MarkData[4], Mileage = 600000,Price=1500000,ReleaseYear=1996,Pacage=PacageData[5], Picture ="C:\\Users\\Александр\\Desktop\\Учеба\\Дувалин Курсач\\Пикчи\\supra.jpeg"},
        };

        static List<User> UserData = new()
        {
            new User() { Logins="admin",Pass="admin", Roles = "admin"},
            new User() { Logins="salfetka",Pass="228", Roles = "user"},
            new User() { Logins="pedro",Pass="1337", Roles = "user"},
        };
    }
}
