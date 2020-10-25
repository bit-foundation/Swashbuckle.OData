using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwashbuckleODataSample.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }

        public string OrderName { get; set; }

        public double UnitPrice { get; set; }

       [ForeignKey("Customer")]
        public int CustomerId { get; set; }

       public virtual Customer Customer { get; set; }
    }
}