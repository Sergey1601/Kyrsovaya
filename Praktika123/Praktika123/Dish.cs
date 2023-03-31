using System;
using EfCoreTest1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Praktika123;

namespace Praktika123
{
    public class Dish
    {
        [Column("Id")]
        [Key]
        public int Id_Dish { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public int Price { get; set; }
        /*public Order_tab? Order_tab { get; set; }*/
        public LinkedList<Order_tab> Order_Tab { get; set; } = new ();
    }
}
