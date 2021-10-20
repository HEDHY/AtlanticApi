using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Application.DTOs.External.Conversions
{
    public class ConversionDTO
    {
        public double Amount { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string,string> Rates { get; set; }
    }
}
