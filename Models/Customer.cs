using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace AmarilloMarble.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        [Required]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string CustomerFirstName {get; set;}
        [Required]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string CustomerLastName {get; set;}
        public string CustomerFullName {get {return this.CustomerFirstName + " " + this.CustomerLastName;}}
        public List<Job> Jobs {get; set;}
    }
}