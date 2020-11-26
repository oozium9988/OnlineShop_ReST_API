using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using OnlineShop_ReST_API.Models;

namespace OnlineShop_ReST_API.Controllers
{
    [EnableCors("*","*","*")]
    public class ItemController : ApiController
    {
        public List<Item> GetAll()
        {
            List<Item> itemList = new List<Item>
            {
                new Item{Id=1, Name="Paper", Price=2, Tagline="Good for writing" },
                new Item{Id=2, Name="Beer", Price=4.50, Tagline="Mmmmm beeer" },
                new Item{Id=3, Name="Pen", Price=0.10, Tagline="Essential for writing" },
                new Item{Id=4, Name="Bus", Price=20000, Tagline="Not great for writing" },
                new Item{Id=5, Name="Car", Price=5000, Tagline="Good for driving" },
                new Item{Id=6, Name="Aeroplane", Price=80000000, Tagline="Good for driving (through the sky)" },
                new Item{Id=7, Name="Wine", Price=10, Tagline="Mmmmm wiiine" },
                new Item{Id=8, Name="House", Price=300000, Tagline="Good for living in"},
                new Item{Id=9, Name="Apple", Price=0.30, Tagline="Delicious fruit"},
                new Item{Id=10, Name="Burger", Price=3.50, Tagline="Good for eating"},
                new Item{Id=11, Name="Train Ticket", Price=20, Tagline="Essential for getting on trains"},
                new Item{Id=12, Name="Games Console", Price=300, Tagline="Good for playing games on 60FPS"},
                new Item{Id=13, Name="PC", Price=1000, Tagline="Good for playing games on 240FPS"},
                new Item{Id=14, Name="Book", Price=5, Tagline="Good for reading" },
                new Item{Id=15, Name="Glasses", Price=30, Tagline="Good for seeing" }
            };

            return itemList;
        }
    }
}
