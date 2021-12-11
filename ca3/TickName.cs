using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ca3
{
    public class TickName
    {
        [Required]
        public string Tikr { get; set; }

        [Required]
        public string CurName { get; set; }
    }
}
