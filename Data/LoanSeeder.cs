using LoanWebApp.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp.Data
{
    public class LoanSeeder
    {
        private readonly LoanContext _ctx;
        private readonly IHostEnvironment _hosting;

        public LoanSeeder(LoanContext ctx, IHostEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            if (!_ctx.Products.Any())
            {   
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/rent.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);
                var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                if (order !=null)
                {
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    };
                }
                _ctx.SaveChanges();
            }
        }
    }
}
