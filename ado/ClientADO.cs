using location_voiture.entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace location_voiture.ado
{
    public class ClientADO
    {
        public void Inserer(Client C)
        {
            try
            {
                Connexion.Open();
                string req = "INSERT INTO Client (CIN, Nom, Prenom, Tel, Adresse) VALUES(@Cin, @Nom, @Pren, @Tel, @Adresse)";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@Cin", C.cin_cl);
                cmd.Parameters.AddWithValue("@Nom", C.nom_cl);
                cmd.Parameters.AddWithValue("@Pren", C.prenom_cl);
                cmd.Parameters.AddWithValue("@Tel", C.tel_cl);
                cmd.Parameters.AddWithValue("@Adresse", C.adresse_cl);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Modifier(Client C)
        {
            try
            {
                Connexion.Open();
                string req = "UPDATE Client SET Nom=@Nom, Prenom=@Pren, Tel=@Tel, Adresse=@Adresse WHERE CIN=@Cin";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@Nom", C.nom_cl);
                cmd.Parameters.AddWithValue("@Pren", C.prenom_cl);
                cmd.Parameters.AddWithValue("@Tel", C.tel_cl);
                cmd.Parameters.AddWithValue("@Adresse", C.adresse_cl);
                cmd.Parameters.AddWithValue("@Cin", C.cin_cl);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public void Supprimer(int cin)
        {
            try
            {
                Connexion.Open();
                string req = "DELETE FROM Client WHERE CIN=@Cin";
                SqlCommand cmd = new SqlCommand(req, Connexion.cn);
                cmd.Parameters.AddWithValue("@Cin", cin);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                Connexion.Close();
            }
        }

        public static bool Existe_Client(int cin)
        {
            try
            {
                Connexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE CIN=@Cin", Connexion.cn);
                cmd.Parameters.AddWithValue("@Cin", cin);
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

        public static DataTable Liste_Client()
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client", Connexion.cn);
                da.Fill(dt);
            }
            finally
            {
                Connexion.Close();
            }
            return dt;
        }

        public static DataTable Liste_Client(int cin)
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE CIN=@Cin", Connexion.cn);
                da.SelectCommand.Parameters.AddWithValue("@Cin", cin);
                da.Fill(dt);
            }
            finally
            {
                Connexion.Close();
            }
            return dt;
        }

        public static DataTable Liste_Client(string nom)
        {
            DataTable dt = new DataTable();
            try
            {
                Connexion.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Nom=@Nom", Connexion.cn);
                da.SelectCommand.Parameters.AddWithValue("@Nom", nom);
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
