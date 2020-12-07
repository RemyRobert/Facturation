using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        void AddFacture(BusinessData business);

        public List<BusinessData> GetFacture();
    }
}