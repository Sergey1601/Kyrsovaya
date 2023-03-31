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
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string? Employees_last_name { get; set; }
        public DateTime? Date_of_employment { get; set; }
        public Order? Order { get; set; }
    }
}
