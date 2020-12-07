using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public string ClientName { get; }
        public string Number { get; }
        public DateTime EmissionDate { get; }
        public DateTime ReglementeDate { get; set; }
        public double ToPay { get; }
        public double Paid { get; set; }

        private List<BusinessData> _factures = new List<BusinessData>();

        public BusinessData()
        {
        }

        public BusinessData(string clientName, double toPay, DateTime reglementDate = default(DateTime), double paid = 0)
        {
            ClientName = clientName;
            Number = new Random().Next(1000000) + "FR";
            EmissionDate = DateTime.Now;
            ReglementeDate = reglementDate;
            ToPay = toPay;
            Paid = paid;
        }

        public void AddFacture(BusinessData business)
        {
            _factures.Add(business);
        }

        public List<BusinessData> GetFacture()
        {
            return _factures;
        }
    }
}