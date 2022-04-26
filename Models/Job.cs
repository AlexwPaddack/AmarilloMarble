using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace AmarilloMarble.Models
{
    public class Job
    {
        public int JobId {get; set;}
        public string JobAddress {get; set;}
        public string JobBuilder {get; set;}
        public DateTime JobDate {get; set;}

        [Display(Name = "Customer")]
        [Required]
        public int CustomerId {get; set;} // Foreign Key linking Job to Customer
        public Customer Customer {get; set;}


        
    }
}