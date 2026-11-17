using System;

namespace location_voiture.entities
{
    public class Location
    {
        public int Id { get; set; }
        public int CIN_Client { get; set; }
        public string Matricule { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }
        public double Prix_Total { get; set; }
        public string Etat_Location { get; set; }
    }
}
