using System;
using System.Collections.Generic;
using System.Text;

namespace Atlantico.Business.Model
{
    public class Payment
    {
        public string Currency { get; set; }
        public string Amount { get; set; }
        public string Entity { get; set; }
    }
}
