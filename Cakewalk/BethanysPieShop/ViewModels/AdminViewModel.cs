﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<Pie> AllPies { get; set; }
    }
}