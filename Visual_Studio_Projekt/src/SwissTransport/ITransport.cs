namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id, System.DateTime selected_DateTime);
        Connections GetConnections(string fromStation, string toStattion, System.DateTime selected_DateTime, int arr_dep, int later_conn);
    }
}