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
    public class Order
    {
        [Key]
        public int Order_Number { get; set; }
        public string? Order_date { get; set; }
        [Column("Id_Client")]
        public int ClientId { get; set; }
        public string? Cooking_time { get; set; }
        public int Cook_Id { get; set; }
        public int Courier_Id { get; set; }
        public int Manager_Id { get; set; }
        public string? Ready_Status { get; set; }
        public int Payment_method_Id { get; set; }
        public Client? Client { get; set; }
        /*public Order_tab? Order_tab { get; set; }*/
        /*public LinkedList<Client> Clients { get; set; }
        public LinkedList<Employee> Employees { get; set; }
        public LinkedList<Order_tab> Order_tabs { get; set; }
        public LinkedList<Payment> Payments { get; set; }*/

    }
}
