using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAssesment3.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(75)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Director { get; set; }

        [Required]        
        public DateTime ReleaseYear { get; set; }

        [Required]        
        public int Price { get; set; }
        

        public virtual ICollection<OrderRow> OrderRow { get; set; }
    }
}