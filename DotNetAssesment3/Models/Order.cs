using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAssesment3.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]       
        public DateTime OrderDate { get; set; }

        [Required]        
        public int CustomerId { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderRow> OrderRow { get; set; }
    }
}