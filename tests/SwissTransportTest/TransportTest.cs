using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            DateTime date = DateTime.Now;
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007", date);

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            DateTime date = DateTime.Now;
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", date, 0, 6);

            Assert.IsNotNull(connections);
        }
    }
}
