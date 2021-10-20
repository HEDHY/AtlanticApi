using System;
using System.Collections.Generic;
using System.Text;

namespace Atlantico.Business.Model
{
    public class CardDDO
    {
        public string Pan { get; set; }
        public string Name { get; set; }
        public CardType Type { get; set; }
        public string ClientId { get; set; }

        public string PhoneNumber { get; set; }

        public Boolean IsValid()
        {
            return Pan != null && ClientId != null && Name != null;
        }
    }

    public enum CardType
    {
        DEBIT,
        CREDIT
    }


    

}
