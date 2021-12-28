using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClinicMS
{
    internal class Operations
    {
       
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-63TK96G\\SQLEXPRESS;Initial Catalog=DB_Clinic;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public DataTable DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select patientID,nom,prenom,heureRDV,motif  from Patient,RDV where Patient.ID=RDV.patientID", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable DisplayPrescription()
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select *  from Ordonnance", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable DisplayMedicament()
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select  medicamentid,medicament from medicament", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable SearchAttentebyid(int a)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select patientID,nom,prenom,heureRDV,motif  from Patient,RDV where Patient.ID=RDV.patientID and '"+a+"'=Patient.ID", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable SearchAttentebyNom(String a)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select patientID,nom,prenom,heureRDV,motif  from Patient,RDV where Patient.ID=RDV.patientID and Patient.nom Like '%" + a + "%'", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable SearchAttentebyPrenom(String a)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select patientID,nom,prenom,heureRDV,motif  from Patient,RDV where Patient.ID=RDV.patientID and Patient.prenom Like '%" + a + "%'", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable SearchAttentebymotif(String a)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select patientID,nom,prenom,heureRDV,motif  from Patient,RDV where Patient.ID=RDV.patientID and RDV.motif Like '%" + a + "%'", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }
        public void SupprimerPatientAbsente(int id)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "delete from RDV where patientID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                cn.Close();
               
            }
            catch (Exception ex)
            {
                cn.Close();
            }
        }
        public bool validervisite(int id, String interrogatoire, String conclusion, String examen , String traitement, int montant, String estPayer)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "ValiderVisite";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pid", id);
                cmd.Parameters.AddWithValue("@interrogatoire", interrogatoire);
                cmd.Parameters.AddWithValue("@conclusion", conclusion);
                cmd.Parameters.AddWithValue("@examen", examen);
                cmd.Parameters.AddWithValue("@traitement", traitement);
                cmd.Parameters.AddWithValue("@montant", montant);
                cmd.Parameters.AddWithValue("@estPayer", estPayer);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

        }
        public bool Prescrit(int medicamentid, String prise, String periode, String nbparjours, String quand, String remarque)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
           
                cmd.CommandText = "prescrit ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@medicamentid", medicamentid);
                cmd.Parameters.AddWithValue("@prise", prise);
                cmd.Parameters.AddWithValue("@periode", periode);
                cmd.Parameters.AddWithValue("@nbparjours", nbparjours);
                cmd.Parameters.AddWithValue("@quand", quand);
                cmd.Parameters.AddWithValue("@remarque", remarque);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

        }
        public DataTable SearchAttentebyMedicament(String a)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select medicamentid,medicament from medicament where medicament Like '%" + a + "%'", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }

        /* 
        public DataSet1.dataGridView1 GetMember()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Membres";
            DataSet1.MembersDataTable dt = new DataSet1.MembersDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }
        // --------------------- Les Operation de table Member ---------------------------
        //  Get All memebers from tha table to display them
       public DataSet1.MembersDataTable GetMember()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Membres";
            DataSet1.MembersDataTable dt = new DataSet1.MembersDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

       
        //Add Memebers to the database 
        public bool AjouterMember(string nom, string prenom, string cin, string telephone, string email, string adresse, DateTime Date_naissance, DateTime Date_inscription)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "insert into Membres values(@nom,@pnom,@cin,@tel,@mail,@addr,@DateN,@Dateinsc)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nom", nom);
                cmd.Parameters.AddWithValue("pnom", prenom);
                cmd.Parameters.AddWithValue("cin", cin);
                cmd.Parameters.AddWithValue("tel", telephone);
                cmd.Parameters.AddWithValue("mail", email);
                cmd.Parameters.AddWithValue("addr", adresse);
                cmd.Parameters.AddWithValue("DateN", Date_naissance);
                cmd.Parameters.AddWithValue("Dateinsc", Date_inscription);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

        }
        //Modifie Memebers 
        public bool ModificationMember(int id, string nom, string prenom, string cin, string telephone, string email, string adresse, DateTime Date_naissance, DateTime Date_inscription)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "update Membres set Nom=@nom, Prenom=@pnom, CIN=@cin, Telephone=@tel, Email=@mail, Adresse=@addr, Date_naissance=@DateN, Date_inscription=@Dateinsc where member_id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nom", nom);
                cmd.Parameters.AddWithValue("pnom", prenom);
                cmd.Parameters.AddWithValue("cin", cin);
                cmd.Parameters.AddWithValue("tel", telephone);
                cmd.Parameters.AddWithValue("mail", email);
                cmd.Parameters.AddWithValue("addr", adresse);
                cmd.Parameters.AddWithValue("DateN", Date_naissance);
                cmd.Parameters.AddWithValue("Dateinsc", Date_inscription);
                cmd.ExecuteNonQuery();
                cn.Close();
                DisplayData();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cn.Close();
                return false;
            }

        }

        //Delet Memebrs
        

        //Override the first Methode GetMember adding an argument to it for Search TextBox
        public DataSet1.MembersDataTable GetMember(string pNom)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Membres where Nom like '%'+@nom+'%'";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("nom", pNom);
            DataSet1.MembersDataTable dt = new DataSet1.MembersDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }


        // --------------------- Les Operation de table Entrineur ---------------------------
        //Get Trainers From the database
        public DataSet1.EntraineurDataTable GetEntrinnneur()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Entraineur";
            DataSet1.EntraineurDataTable dt = new DataSet1.EntraineurDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        //Add Trainers to the database
        public bool AjouterEntrinnneur(string nom, string prenom, string Cin, string phone, string email, string adresse, int salaire)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "insert into Entraineur values(@lname,@fname,@cin,@tele,@email,@adress,@salaire)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("fname", prenom);
                cmd.Parameters.AddWithValue("lname", nom);
                cmd.Parameters.AddWithValue("adress", adresse);
                cmd.Parameters.AddWithValue("cin", Cin);
                cmd.Parameters.AddWithValue("tele", phone);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("salaire", salaire);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
            cn.Close();
                return false;
            }

        }

        //Modification
        public bool ModifierEntrinnneur(int id, string nom, string prenom, string Cin, string phone, string email, string adresse, int salaire)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "update Entraineur set Nom=@lname, Prenom=@fname, CIN=@cin, Phone=@tele, Email=@email, Adresse=@adress, Salaire=@salaire where entraineur_id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("fname", prenom);
                cmd.Parameters.AddWithValue("lname", nom);
                cmd.Parameters.AddWithValue("adress", adresse);
                cmd.Parameters.AddWithValue("cin", Cin);
                cmd.Parameters.AddWithValue("tele", phone);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("salaire", salaire);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
            }

        }

        //Delete
        public bool SupprimerEntraineur(int id)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "delete from Entraineur where entraineur_id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                cn.Close();
                DisplayData();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cn.Close();
                return false;
            }
        }

        //Overide the first getEntrinur methode to use for search
        public DataSet1.EntraineurDataTable GetEntrinnneur(string pNom)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Entraineur where Nom like '%'+@nom+'%'";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("nom", pNom);
            DataSet1.EntraineurDataTable dt = new DataSet1.EntraineurDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }
        // --------------------- Les Operation de table Paiment ---------------------------
        public DataSet1.PaiementDataTable GetPaiment()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Paiement";
            DataSet1.PaiementDataTable dt = new DataSet1.PaiementDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        public bool AjouterPaiment(int montant, DateTime dPaiment, int id_member)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "insert into Paiement values(@mt,@paiment,@idMember)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("mt", montant);
                cmd.Parameters.AddWithValue("paiment", dPaiment);
                cmd.Parameters.AddWithValue("idMember", id_member);
                cmd.ExecuteNonQuery();

                cn.Close();
                DisplayData();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cn.Close();
                return false;
            }

        }

        // This function to get the Cin Assicited to every Member id to use it in comboBox
        public DataSet1.ID_MemberWith_CinDataTable getCin()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select member_id,CIN from Membres";
            DataSet1.ID_MemberWith_CinDataTable dt = new DataSet1.ID_MemberWith_CinDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        public string getMemberId(int id)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select CIN from Membres where member_id like @lib";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@lib", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string cin = dr[0].ToString();
            cn.Close();
            return cin;
        }

        // *********************************


        public bool ModiferPaiment(int id, int montant, DateTime dPaiment, int id_member)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "Update Paiement set montant=@mt, Date_paiement=@paiment, member_id=@idMember Where paiement_id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("mt", montant);
                cmd.Parameters.AddWithValue("paiment", dPaiment);
                cmd.Parameters.AddWithValue("idMember", id_member);
                cmd.ExecuteNonQuery();

                cn.Close();
                DisplayData();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cn.Close();
                return false;
            }

        }


        public bool SupprimerPaiment(int id)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "delete from Paiement where paiement_id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                cn.Close();
                return false;
        }

        }*/

    }

}

