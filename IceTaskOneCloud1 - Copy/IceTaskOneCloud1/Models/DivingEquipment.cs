﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceTaskOneCloud1.Models
{
    using System.ComponentModel.DataAnnotations;

    public class DivingEquipment
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal RentalPrice { get; set; }
    }
}