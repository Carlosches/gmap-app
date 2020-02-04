using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace model
{
    public class DataManager
    {
        
        private List<FlightReport> flights;
       

        public void loadData(string path) {
            flights = new List<FlightReport>();

            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine(); //skip header
            int p = 0;
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
                if (p<10)
                {
                   // Console.WriteLine(depDelay);
                    p++;
                }
                flights.Add(new FlightReport(airlineID, originAirportID, originCity, originState, destAirportID, destCity, destState, apntdDep, actDep, depDelay));
            }
           
            sr.Close();
        }


        public double probability(string originCity, string destCity, int minutes)
        {
           
            double total = 0;
            double have = 0;
            double proba = 0;
            for (int i = 0; i < flights.Count; i++)
            {
                FlightReport flreport = flights[i];
                string origin = flreport.OriginCity;
                string dest = flreport.DestCity;
                if (originCity.Equals(origin) && destCity.Equals(dest))
                {
                    total++;
                    Console.WriteLine("depDelay: " + flreport.DepDelay);
                    if(flreport.DepDelay<=minutes && flreport.DepDelay > 0)
                    {
                        have++;
                    }
                   
                }
            }
            proba = (have / total)*100;
            proba = Math.Round(proba, 2);
                Console.WriteLine("total : " + total  + " proba: "+ proba);
            return proba;
        }

        public List<FlightReport> Flights {
            get { return flights; } 
            set { flights = value; }
        }
    }
}
