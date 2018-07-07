using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleManagementSystem.Models
{
    public class Car : Vehicle
    {
        public int Id { get; set; }    
        [Required]    
        public string Engine { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int NoOfDoors { get; set; }
        [Required]
        public string BodyType { get; set; }
    }
}