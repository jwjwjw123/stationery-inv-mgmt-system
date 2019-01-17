﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Team7ADProject.Entities;

namespace Team7ADProject.ViewModels
{
    public class RaiseRequestViewModel
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        
        [RegularExpression(@"^\d+", ErrorMessage = "Please enter a valid quantity.")]
        public int Quantity { get; set; }

        public string UnitOfMeasure { get; set; }
        public  List<RaiseRequestViewModel> Models { get; set; }

        public RaiseRequestViewModel(RaiseRequestViewModel other)
        {
            Category = other.Category;
            Description = other.Description;
            Quantity = other.Quantity;
            UnitOfMeasure = other.UnitOfMeasure;
        }

        public RaiseRequestViewModel()
        {
            Category = null;
            Description = null;
            Quantity = 0;
            UnitOfMeasure = null;
            Models = new List<RaiseRequestViewModel>();
        }
    }
}