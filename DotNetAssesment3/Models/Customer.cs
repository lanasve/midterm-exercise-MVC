using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAssesment3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string BillingAddress { get; set; }

        [Required]        
        public int BillingZip { get; set; }

        [Required]
        [MaxLength(25)]
        public string BillingCity { get; set; }

        [Required]
        [MaxLength(50)]
        public string DelieveryAddress { get; set; }

        [Required]        
        public int DelieveryZip { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string DelieveryCity { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNo { get; set; }


        public virtual ICollection<Order> Order { get; set; }
    }
}