using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            query = System.Uri.EscapeDataString(query);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id, System.DateTime selected_DateTime)
        {
            station = System.Uri.EscapeDataString(station);
            id = System.Uri.EscapeDataString(id);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id + "&datetime=" + selected_DateTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStation, System.DateTime selected_DateTime, int arr_dep, int later_conn)
        {
            fromStation = System.Uri.EscapeDataString(fromStation);
            toStation = System.Uri.EscapeDataString(toStation);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + 
                "&to=" + toStation + 
                "&date=" + selected_DateTime.Date + 
                "&time=" + selected_DateTime.TimeOfDay + 
                "&limit=" + later_conn + 
                "&isArrivalTime=" + arr_dep);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
