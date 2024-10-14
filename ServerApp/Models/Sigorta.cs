    namespace ServerApp.Models;
    public class RequestModel
    {
        public string? aracMarka { get; set; }

        public int? modelYil { get; set; }

        public string? model { get; set; }
        public string? aracPaketi { get; set; }
        public string? yakitTipi { get; set; }
        public string? sirketAdi { get; set; } 
        public decimal fiyat { get; set; }

    }