using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AEB_demo.Models
{
    public class CalculatorModel
    {
        [Required]
        public decimal SalesPricePerKg { get; set; }

        [Required]
        public decimal TotalKgSold { get; set; }

        [Required]
        public decimal FloorArea { get; set; }

        [Required]
        public decimal ElectricityCost { get; set; }

        [Required]
        public decimal LabourCost { get; set; }

        public decimal Revenue => SalesPricePerKg * TotalKgSold;

        public decimal Profit => Revenue - (ElectricityCost + LabourCost);
    }
}