using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KentuckyVibeMVC.Models;

namespace KentuckyVibeMVC.Data
{
    public class KentuckyVibeMVCContext : DbContext
    {
        public KentuckyVibeMVCContext (DbContextOptions<KentuckyVibeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<KentuckyVibeMVC.Models.Customer> Customers { get; set; }
        public DbSet<KentuckyVibeMVC.Models.Drink> Drinks { get; set; }
    }
}
