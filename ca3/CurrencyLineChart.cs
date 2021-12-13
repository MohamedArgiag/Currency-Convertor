using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ca3
{
    public class CurrencyLineChart
    {
        [Required]
        public DateTime Period { get; set; }

        [Required]
        public double Currency { get; set; }
    }
}
