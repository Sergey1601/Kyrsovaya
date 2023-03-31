using System.ComponentModel.DataAnnotations;

namespace Praktika123
{
    public class Client
    {
        [Key]
        public int Id_Client { get; set; }
        public string? Clients_full_name { get; set; }
        public string? Delivery_Address { get; set; }
        public string? Phone_number { get; set; }
        public LinkedList<Order> Order { get; set; }
        /*public Order? Order { get; set; }*/
    }
}
