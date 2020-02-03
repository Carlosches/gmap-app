using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DataManager
    {
        private List<FlightReport> flights { get { return flights; } set { flights = value; } };

        public void loadData(string path) {
            flights = new List<FlightReport>();

            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine(); //skip header
            while ((line = sr.ReadLine()) != null)
            {
                string[] args = line.Split(',');

                string airlineID = args[7].Replace("\"", "");
                string originAirportID = args[11].Replace("\"", "");
                string originCity = args[15].Replace("\"", "");
                string originState = args[19].Replace("\"", "");
                string destAirportID = args[21].Replace("\"", "");
                string destCity = args[25].Replace("\"", "");
                string destState = args[29].Replace("\"", "");
                int apntdDep = Convert.ToInt32(args[31].Replace("\"", ""));
                string rrr = args[32].Substring(1);
                rrr = rrr.Substring(0, rrr.Length - 1);
                int actDep = Convert.ToInt32(rrr.Length == 0 ? "0" : rrr);
                int depDelay = actDep-apntdDep;

                flights.Add(new FlightReport(airlineID, originAirportID, originCity, originState, destAirportID, destCity, destState, apntdDep, actDep, depDelay));
            }

            sr.Close();
        }
    }
}
