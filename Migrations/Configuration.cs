namespace BikeRental.Migrations
{
    using BikeRental.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BikeRental>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BikeRental context)
        {
            Bikes Bike1 = new Bikes()
            {
                Brand = "Cortina",
                Model = "U4 Transport 3v 2021",
                Gender = GenderOptions.Male,
                Price = 499.99
            };
            Bikes Bike2 = new Bikes()
            {
                Brand = "Batavus",
                Model = "Fonk 3v 2021",
                Gender = GenderOptions.Female,
                Price = 579.99
            };
            Bikes Bike3 = new Bikes()
            {
                Brand = "Cortina",
                Model = "Common Basic 3v 2021",
                Gender = GenderOptions.Male,
                Price = 509.09
            };
            Bikes Bike4 = new Bikes()
            {
                Brand = "Batavus",
                Model = "Mambo 7v 2021",
                Gender = GenderOptions.Female,
                Price = 719.09
            };
            Bikes Bike5 = new Bikes()
            {
                Brand = "Gazelle",
                Model = "Esprit C3 2021",
                Gender = GenderOptions.Male,
                Price = 539.99
            };
            Bikes Bike6 = new Bikes()
            {
                Brand = "Stevens",
                Model = "Boulevard Luxe 2021",
                Gender = GenderOptions.Male,
                Price = 1199.99
            };

            /*
            context.Bikes.AddOrUpdate(Bike1);
            context.Bikes.AddOrUpdate(Bike2);
            context.Bikes.AddOrUpdate(Bike3);
            context.Bikes.AddOrUpdate(Bike4);
            context.Bikes.AddOrUpdate(Bike5);
            context.Bikes.AddOrUpdate(Bike6);
            */

            context.Stores.AddOrUpdate(
                store => store.Address,
                new Stores()
                {
                    Address = "Stationsplein 95",
                    Place = "Nieuwerkerk aan den IJssel",
                    Capacity = 10,
                    Staff = 5,
                    AvailableBikes = new List<Bikes>() { Bike1, Bike2 }
                },
                new Stores()
                {
                    Address = "Heemskerkstraat 20",
                    Place = "Groenlo",
                    Capacity = 100,
                    Staff = 50,
                    AvailableBikes = new List<Bikes>() { Bike3, Bike4 }
                },
                new Stores()
                {
                    Address = "Lijsterbeslaan 43",
                    Place = "Loosdrecht",
                    Capacity = 20,
                    Staff = 10,
                    AvailableBikes = new List<Bikes>() { Bike5, Bike6 }
                }
            );
        }
    }
}
