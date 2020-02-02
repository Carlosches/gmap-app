using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class FlightReport
    {
        private string airlineID;
        private string originAirportID;
        private string originCity;
        private string originState;
        private string destAirportID;
        private string destCity;
        private string destState;
        private int apntdDep;
        private int actDep;
        private int depDelay;

        public FlightReport(string airlineID, string originAirportID, string originCity, string originState, string destAirportID, string destCity, string destState, int apntdDep, int actDep, int depDelay)
        {
            this.airlineID = airlineID;
            this.originAirportID = originAirportID;
            this.originCity = originCity;
            this.originState = originState;
            this.destAirportID = destAirportID;
            this.destCity = destCity;
            this.destState = destState;
            this.apntdDep = apntdDep;
            this.actDep = actDep;
            this.depDelay = depDelay;
        }
    }
}
