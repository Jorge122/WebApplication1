﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Customer
    {
        public int ID { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }
    }
}