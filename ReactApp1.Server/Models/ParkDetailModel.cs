namespace ReactApp1.Server.Models
{
    //https://api.ibb.gov.tr/ispark/ParkDetay?id=144
    public class ParkDetailModel
    {
        public string LocationName { get; set; }
        public int ParkID { get; set; }
        public string ParkName { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Capacity { get; set; }
        public int EmptyCapacity { get; set; }
        public DateTime UpdateDate { get; set; }
        public string WorkHours { get; set; }
        public string ParkType { get; set; }
        public int FreeTime { get; set; }
        public decimal MonthlyFee { get; set; }
        public string Tariff { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string AreaPolygon { get; set; }
    }

}
