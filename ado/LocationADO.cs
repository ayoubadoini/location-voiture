using location_voiture.entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace location_voiture.ado
{
    public class LocationADO
    {
        public void Inserer(Location l)
        {
            try
            {
                Connexion.Open();
                string req = "INSERT INTO Location (CIN_Client, Matricule, Date_Debut, Date_Fin, Prix_Total, Etat_Location) " +
                             "VALUES (@CIN, @Matricule, @DateDebut, @DateFin, @PrixTotal, @Etat)";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@CIN", l.CIN_Client);
                cmd.Parameters.AddWithValue("@Matricule", l.Matricule);
                cmd.Parameters.AddWithValue("@DateDebut", l.Date_Debut);
                cmd.Parameters.AddWithValue("@DateFin", l.Date_Fin);
                cmd.Parameters.AddWithValue("@PrixTotal", l.Prix_Total);
                cmd.Parameters.AddWithValue("@Etat", l.Etat_Location);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Modifier(Location l)
        {
            try
            {
                Connexion.Open();
                string req = "UPDATE Location SET CIN_Client=@CIN, Matricule=@Matricule, Date_Debut=@DateDebut, " +
                             "Date_Fin=@DateFin, Prix_Total=@PrixTotal, Etat_Location=@Etat WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@CIN", l.CIN_Client);
                cmd.Parameters.AddWithValue("@Matricule", l.Matricule);
                cmd.Parameters.AddWithValue("@DateDebut", l.Date_Debut);
                cmd.Parameters.AddWithValue("@DateFin", l.Date_Fin);
                cmd.Parameters.AddWithValue("@PrixTotal", l.Prix_Total);
                cmd.Parameters.AddWithValue("@Etat", l.Etat_Location);
                cmd.Parameters.AddWithValue("@Id", l.Id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Supprimer(int id)
        {
            try
            {
                Connexion.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Location WHERE ID_Location=@ID_Location", Connexion.cn);
                cmd.Parameters.AddWithValue("@ID_Location", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public static DataTable Liste_Locations()
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Location", Connexion.cn);
                da.Fill(dt);
            }
            finally
            {
                Connexion.Close();
            }
            return dt;
        }
    }
}
