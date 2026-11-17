using location_voiture.entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace location_voiture.ado
{
    public class VoitureADO
    {
        public void Inserer(Voiture v)
        {
            try
            {
                Connexion.Open();
                string req = "INSERT INTO Voiture (Matricule, Marque, Modele, Couleur, Carburant, NbPlaces, Kilometrage, PrixParJour, Etat) " +
                             "VALUES (@Matricule, @Marque, @Modele, @Couleur, @Carburant, @NbPlaces, @Kilometrage, @PrixParJour, @Etat)";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@Matricule", v.Matricule);
                cmd.Parameters.AddWithValue("@Marque", v.Marque);
                cmd.Parameters.AddWithValue("@Modele", v.Modele);
                cmd.Parameters.AddWithValue("@Couleur", v.Couleur);
                cmd.Parameters.AddWithValue("@Carburant", v.Carburant);
                cmd.Parameters.AddWithValue("@NbPlaces", v.NbPlaces);
                cmd.Parameters.AddWithValue("@Kilometrage", v.Kilometrage);
                cmd.Parameters.AddWithValue("@PrixParJour", v.PrixParJour);
                cmd.Parameters.AddWithValue("@Etat", v.Etat);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Modifier(Voiture v)
        {
            try
            {
                Connexion.Open();
                string req = "UPDATE Voiture SET Marque=@Marque, Modele=@Modele, Couleur=@Couleur, Carburant=@Carburant, " +
                             "NbPlaces=@NbPlaces, Kilometrage=@Kilometrage, PrixParJour=@PrixParJour, Etat=@Etat " +
                             "WHERE Matricule=@Matricule";

                using (SqlCommand cmd = new SqlCommand(req, Connexion.cn))
                {
                    cmd.Parameters.AddWithValue("@Marque", v.Marque);
                    cmd.Parameters.AddWithValue("@Modele", v.Modele);
                    cmd.Parameters.AddWithValue("@Couleur", v.Couleur);
                    cmd.Parameters.AddWithValue("@Carburant", v.Carburant);
                    cmd.Parameters.AddWithValue("@NbPlaces", v.NbPlaces);
                    cmd.Parameters.AddWithValue("@Kilometrage", v.Kilometrage);
                    cmd.Parameters.AddWithValue("@PrixParJour", v.PrixParJour);
                    cmd.Parameters.AddWithValue("@Etat", v.Etat);
                    cmd.Parameters.AddWithValue("@Matricule", v.Matricule);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        MessageBox.Show("Aucune voiture trouvée avec ce matricule !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Supprimer(string matricule)
        {
            try
            {
                Connexion.Open();
                string req = "DELETE FROM Voiture WHERE Matricule=@Matricule";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@Matricule", matricule);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public static bool Existe_Voiture(string matricule)
        {
            try
            {
                Connexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Voiture WHERE Matricule=@Matricule", Connexion.cn);
                cmd.Parameters.AddWithValue("@Matricule", matricule);
                SqlDataReader dr = cmd.ExecuteReader();
                bool exists = dr.HasRows;
                dr.Close();
                return exists;
            }
            finally
            {
                Connexion.Close();
            }
        }

        public static DataTable Liste_Voitures()
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Voiture", Connexion.cn);
                da.Fill(dt);
            }
            finally
            {
                Connexion.Close();
            }
            return dt;
        }

        public static DataTable Liste_Voitures(string matricule)
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Voiture WHERE Matricule=@Matricule", Connexion.cn);
                da.SelectCommand.Parameters.AddWithValue("@Matricule", matricule);
                da.Fill(dt);
            }
            finally
            {
                Connexion.Close();
            }
            return dt;
        }

        public static DataTable Liste_VoituresByModele(string modele)
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Voiture WHERE Modele=@Modele", Connexion.cn);
                da.SelectCommand.Parameters.AddWithValue("@Modele", modele);
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
