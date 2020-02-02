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
        public const string PATH = "..\\Gmapsapp\\Resources\\On_Time_On_Time_Performance_2017_1.csv";
        private List<FlightReport> flights;
        public void loadData() {
            flights = new List<FlightReport>();

            StreamReader sr = new StreamReader("D:\\OneDrive\\OneDrive - Universidad Icesi\\Icesi\\Quinto semestre\\integrador\\Trabajos\\On_Time_On_Time_Performance_2017_1.csv");

            string line = sr.ReadLine(); //skip header
            while ((line = sr.ReadLine()) != null)
            {
                string[] args = line.Split(',');

                string airlineID = args[7].Replace("\"", "");
                string originAirportID = args[11].Replace("\"", "");
                string originCity = args[15].Replace("\"", "");
                string originState = args[18].Replace("\"", "");
                string destAirportID = args[20].Replace("\"", "");
                string destCity = args[24].Replace("\"", "");
                string destState = args[27].Replace("\"", "");
                int apntdDep = 1;
                int actDep = 2;
                int depDelay = 3;
                try
                {
                    apntdDep = Convert.ToInt32(args[29].Replace("\"", "")); ;
                    actDep = Convert.ToInt32(args[30].Replace("\"", ""));
                    depDelay = Convert.ToInt32(args[31].Replace("\"", ""));
                }
                catch (Exception) { 
                    
                }

                flights.Add(new FlightReport(airlineID, originAirportID, originCity, originState, destAirportID, destCity, destState, apntdDep, actDep, depDelay));
            }

            sr.Close();
        }
    }
}
