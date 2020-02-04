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

        public string AirlineID { 
            get { return airlineID; } 
            set { airlineID = value; } 
        }

        public string OriginAirportID { 
            get { return originAirportID; } 
            set { originAirportID = value; } 
        }

        public string OriginCity { 
            get { return originCity; }
            set { originCity = value; } 
        }

        public string OriginState { 
            get { return originState; }
            set { originState = value; } 
        }

        public string DestAirportID { 
            get { return destAirportID; }
            set { destAirportID = value; }
        }

        public string DestCity {
            get { return destCity; } 
            set { destCity = value; } 
        }

        public string DestState {
            get { return destState; }
            set { destState = value; } 
        }

        public int ApntdDep { 
            get { return apntdDep; }
            set { apntdDep = value; }
        }

        public int ActDep {
            get { return actDep; }
            set { actDep = value; }
        }

        public int DepDelay
        {
            get { return depDelay; }
        }
    }
}
