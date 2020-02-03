using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class FlightReport
    {
        private string airlineID { get { return airlineID; } set { airlineID = value; } }
        private string originAirportID { get { return originAirportID; } set { originAirportID = value; } }
        private string originCity { get { return originCity; } set { originCity = value; } }
        private string originState { get { return originState; } set { originState = value; } }
        private string destAirportID { get { return destAirportID; } set { destAirportID = value; } }
        private string destCity { get { return destCity; } set { destCity = value; } }
        private string destState { get { return destState; } set { destState = value; } }
        private int apntdDep { get { return apntdDep; } set { apntdDep = value; } }
        private int actDep { get { return actDep; } set { actDep = value; } }
        private int depDelay { get { return depDelay; } set { depDelay = value; } }

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
