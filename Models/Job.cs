using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace AmarilloMarble.Models
{
    public class Job
    {
        public int JobId {get; set;}
        public string CustFirstName {get; set;}
        public string CustLastName {get; set;}
        public string JobAddress {get; set;}
        public string JobBuilder {get; set;}
        public DateTime JobDate {get; set;}
        
    }
}