using Atlantico.Business.Model;
using AtlanticoAPI.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Application.DTOs.Payments
{
    public class PaymentDTO : IMapFrom<Payment>
    {
        public string Currency { get; set; }
        public double Amount { get; set; }
        public string Entity { get; set; }
    }
}
