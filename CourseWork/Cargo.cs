using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Cargo
    {
        public string Name { get; }
        public int Cost { get; }
        public int Weight { get; }
        public int Volume { get; }
        public string UploadDate { get; }
        public string TrailerType { get; }
        public string Status { get; }
        public string DownloadLocation { get; }
        public string PlaceOfDischarge { get; }
        public int Distance { get; }

        public Cargo(string name, int cost, int weight, int volume, string uploadDate, string trailerType, 
            string status, string downloadLocation, string placeOfDischarge, int distance)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
            Volume = volume;
            UploadDate = uploadDate;
            TrailerType = trailerType;
            Status = status;
            DownloadLocation = downloadLocation;
            PlaceOfDischarge = placeOfDischarge;
            Distance = distance;
        }
    }
}
