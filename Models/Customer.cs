using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace AmarilloMarble.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        [Required]
        [StringLength(60)]
        public string CustomerFirstName {get; set;}
        public string CustomerLastName {get; set;}
    }
}