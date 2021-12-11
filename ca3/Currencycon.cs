using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ca3
{
    public class Currencycon
    {
        [Required]
        public string CoinName { get; set; }

        [Required]
        public string CoinAmount { get; set; }
        

    }
}
