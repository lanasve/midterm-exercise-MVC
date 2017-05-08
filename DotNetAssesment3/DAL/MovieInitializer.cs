using DotNetAssesment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAssesment3.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var movies = new List<Movie>
            {
                new Movie{Title="Interstellar", Director="Christopher Nolan", ReleaseYear=DateTime.Parse("2014"), Price=179 },
                new Movie{Title="Hobbit:Battle of the five armies", Director="Peter Jackson", ReleaseYear=DateTime.Parse("2014"), Price=179  },
                new Movie{Title="The Wolf Of Wall Street", Director="Martin Scorcese", ReleaseYear=DateTime.Parse("2013"), Price=119   },
                new Movie{Title="Pulp Fiction", Director="Quentin Tarantino", ReleaseYear=DateTime.Parse("1994"), Price=49  },
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();


            var customers = new List<Customer>
            {
                new Customer{FirstName="Jonas", LastName="Grey", BillingAddress="23 Green Corner Street", BillingZip=56743 , BillingCity="Birmingham", DelieveryAddress="23 Green Corner Street", DelieveryZip=56743 , DelieveryCity="Birmingham", EmailAddress="jonas.gray@hotmail.com", PhoneNo="0708123456" },
                new Customer{FirstName="Jane", LastName="Harolds", BillingAddress="10 West Street", BillingZip=43213 , BillingCity="London", DelieveryAddress="10 West Street", DelieveryZip=43213 , DelieveryCity="London", EmailAddress="jane_h77@gmail.com", PhoneNo="0701245512" },
                new Customer{FirstName="Peter", LastName="Birro", BillingAddress="12 Fox Street", BillingZip= 45681, BillingCity="New York", DelieveryAddress="89 Moose Plaza", DelieveryZip=45321 , DelieveryCity="Seattle", EmailAddress="peter_the_great@hotmail.com", PhoneNo="0739484322" },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order {OrderDate=DateTime.Parse("2015-01-01"), CustomerId=1 },
                new Order {OrderDate=DateTime.Parse("2015-01-15"), CustomerId=3 },
                new Order {OrderDate=DateTime.Parse("2014-12-20"), CustomerId=1 },
            };

            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();


            var orderRows = new List<OrderRow>
            {
                new OrderRow {OrderId=1 , MovieId=1 , Price=179 },
                new OrderRow {OrderId=1 , MovieId=4 , Price=49 },
                new OrderRow {OrderId=2 , MovieId=3 , Price=119 },
                new OrderRow {OrderId=2 , MovieId=3 , Price=119 },
                new OrderRow {OrderId=3 , MovieId=3 , Price=119 },
            };

            orderRows.ForEach(s => context.OrderRows.Add(s));
            context.SaveChanges();







        }        
    }
}