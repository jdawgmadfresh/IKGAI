using Elfie.Serialization;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;
using Main.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Main.Models
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
        
        } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-ME7SMI3\\SQLEXPRESS;Database=mainDb ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

        public DbSet<Kategorite> Kategorite {  get; set; }
        public DbSet<Produktet> Produktet { get; set; }


    }
}
