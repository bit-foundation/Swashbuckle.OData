using Microsoft.AspNet.OData.Builder;
using System.Collections.Generic;

namespace Containment
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }

        [Contained]
        public IList<PaymentInstrument> PayinPIs { get; set; }

        [Contained]
        public PaymentInstrument PayoutPI { get; set; }
    }

    public class PaymentInstrument
    {
        public int PaymentInstrumentID { get; set; }
        public string FriendlyName { get; set; }
    }
}