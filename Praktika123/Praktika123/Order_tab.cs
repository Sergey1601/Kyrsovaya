using System;
using EfCoreTest1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations;
using Praktika123;

namespace Praktika123
{
    public class Order_tab
    {
        public int Number { get; set; }
        public int Id { get; set; }
        [Key]
        public int DishId { get; set; }
        public int Quantity { get; set; }
        /*public Order? Order { get; set; }*/
        /*public LinkedList<Order> Order { get; set; }*/
        /*public LinkedList<Dish> Dish { get; set; }*/
        public Dish? Dish { get; set; }
    }
}
