using System.Text.Json.Serialization;

namespace ReactApp1.Server.Models
{
    //https://api.ibb.gov.tr/ispark/Park
    public class ParkListModel
    {
        public int ParkID { get; set; }
        public string ParkName { get; set; }

        [JsonConverter(typeof(StrToDbl))]
        public double Lat { get; set; }
        [JsonConverter(typeof(StrToDbl))]
        public double Lng { get; set; }
        public int Capacity { get; set; }
        public int EmptyCapacity { get; set; }
        public string WorkHours { get; set; }
        public string ParkType { get; set; }
        public int FreeTime { get; set; }
        public string District { get; set; }
        public bool IsOpen { get; set; }
    }

}
