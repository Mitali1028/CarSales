using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleManagementSystem.Models
{
    public class Vehicle
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
    }
}