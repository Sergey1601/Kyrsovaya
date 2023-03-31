using System;
using EfCoreTest1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections;
using Praktika123;

internal class Program
{
    private static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
         {

             var users = from u in db.Clients.ToArray()
                         join
                          c in db.Orders.ToArray() on u.Id_Client equals c.ClientId
                         select new { Client = u.Clients_full_name, Ready = c.Ready_Status };

             foreach (var p in users)
             {
                 Console.WriteLine(p.Client + " " + p.Ready);
             }
         }
        /*using (ApplicationContext db = new ApplicationContext())
        {
            var prices = from i in db.Dishs.ToArray()
                           where i.Price > 100
                           where i.Price < 500
                           select i;
            foreach (var i in prices)
            {
                Console.WriteLine(i.Title + "-" + i.Price);
            }
            Console.WriteLine();
        }*/

        /*using (ApplicationContext db = new ApplicationContext())
        {
            var dishs = db.Dishs.ToArray();
            Console.WriteLine("Список объектов");
            foreach( Dish u in dishs)
            {
                Console.WriteLine(u.Title + " - " + u.Price);
            }
        }*/
         /*using (ApplicationContext db = new ApplicationContext())
         {
             Dish? upddish = (from dish in db.Dishs where dish.Id_Dish == 3 select dish).First();
             if (upddish != null)
             {
                 upddish.Price = upddish.Price * 2;
                 db.SaveChanges();
             }
             var dishs = db.Dishs.ToArray();
             Console.WriteLine("Список объектов");
             foreach (Dish u in dishs)
             {
                 Console.WriteLine(u.Id_Dish + " - " + u.Price);
             }

         }*/
        /* using (ApplicationContext db = new ApplicationContext())
         {
             Dish test = new Dish { Id_Dish = 12, Title = "Кола", Category = "Напиток", Price = 100 };
             db.Dishs.Add(test);
             db.SaveChanges();
             var dishs = db.Dishs.ToArray();
             Console.WriteLine("Список объектов");
             foreach (Dish u in dishs)
             {
                 Console.WriteLine(u.Title + " - " + u.Price);
             }
         }*/
        /*using (ApplicationContext db = new ApplicationContext())
        {
            var test = from t in db.Orders.ToArray()
                       where t.Ready_Status == "Готов"
                       where t.Payment_method_Id == 2
                       select t;
            foreach (var t in test)
            {
                Console.WriteLine(t.Order_Number);
            }
            Console.WriteLine();
        }*/

    }

}
