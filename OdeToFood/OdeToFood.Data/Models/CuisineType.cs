﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    //public enum CuisineType
    //{
    //    None,
    //    Italian,
    //    Indian,
    //    French
    //}

    public class CuisineType
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }




}
