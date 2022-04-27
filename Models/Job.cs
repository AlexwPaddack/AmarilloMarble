using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace AmarilloMarble.Models
{
    public class Job
    {
        public int JobId {get; set;}
        [Required]
        [Display(Name = "Address")]
        public string JobAddress {get; set;}
        [Display(Name = "Builder")]
        public string JobBuilder {get; set;}
        [Required]
        [Display(Name = "Date")]
        public DateTime JobDate {get; set;}

        [Display(Name = "Customer")]
        [Required]
        public int CustomerId {get; set;} // Foreign Key linking Job to Customer
        public Customer Customer {get; set;}


        
    }
}