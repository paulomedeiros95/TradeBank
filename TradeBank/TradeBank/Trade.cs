using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeBank.Interfaces;

namespace TradeBank
{
    public class Trade : ITrade

    {
        #region Properties
        public double Value { get; set; }

        public string ClientSector { get; set; }
        #endregion

        #region Constructor
        public Trade(double value, string clientSector)

        {
            Value = value;

            ClientSector = clientSector;
        }
        #endregion

    }
}
