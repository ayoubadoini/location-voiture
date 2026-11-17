namespace location_voiture.entities
{
    public class Voiture
    {
        public string Matricule { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public string Carburant { get; set; }
        public int NbPlaces { get; set; }
        public double Kilometrage { get; set; }
        public double PrixParJour { get; set; }
        public string Etat { get; set; }       
    }
}
