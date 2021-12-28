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
        public SqlConnection cn = new SqlConnection("Data Source=KAITO;Initial Catalog=DB_CLINIC;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public int patient;
        // --------------------- Les Operation de table Member ---------------------------
        //  Get All memebers from tha table to display them
        public DataSet1.MedicamentsDataTable GetMedicament()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select medicaments from Medicaments";
            DataSet1.MedicamentsDataTable dt = new DataSet1.MedicamentsDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        //Add Memebers to the database 
        public bool AjouterPatient(string nom, string prenom, string cin, string sexe, DateTime datenaissance, string telephone, string situation, string mutuelle, string adresse, DateTime datedecreation, int docteurid)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "AjouterPatient";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NomPatient", nom);
                cmd.Parameters.AddWithValue("@PrenomPatient", prenom);
                cmd.Parameters.AddWithValue("@CINPatient", cin);
                cmd.Parameters.AddWithValue("@SexePatient", sexe);
                cmd.Parameters.AddWithValue("@DateNaissance", datenaissance);
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@situationfamiliale", situation);
                cmd.Parameters.AddWithValue("@mutuelle", mutuelle);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@datedecreation", datedecreation);
                cmd.Parameters.AddWithValue("@docteurID", docteurid);
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
        public DataSet1.PatientDataTable GetDocteur()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Docteur";
            DataSet1.PatientDataTable dt = new DataSet1.PatientDataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            cn.Close();
            return dt;
        }

        public DataTable DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Patient", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable DisplayData(string pcin)
        {
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Patient where cin LIKE '" + pcin + "%'", cn);
            adapt.Fill(dt);
            cn.Close();
            return dt;
        }

        public bool AjouterLANT (int pid, string typeant, string ant, string com)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "ajouterLANT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@typeant", typeant);
                cmd.Parameters.AddWithValue("@ant", ant);
                cmd.Parameters.AddWithValue("@Com", com);
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

        public bool reglerRDV(string pid, DateTime daterdv, String heure, string motif)
        {


            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "reglerRDV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@daterdv", daterdv);
                cmd.Parameters.AddWithValue("@heure", TimeSpan.Parse(heure));
                cmd.Parameters.AddWithValue("@motif", motif);
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

        public bool ModifierPatient(string nom, string prenom, string cin, string sexe, string datenaissance, string telephone, string situation, string mutuelle, string adresse, int patientid)
        {
            cn.Open();
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "ModifierPatient";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NomPatient", nom);
                cmd.Parameters.AddWithValue("@PrenomPatient", prenom);
                cmd.Parameters.AddWithValue("@CINPatient", cin);
                cmd.Parameters.AddWithValue("@SexePatient", sexe);
                cmd.Parameters.AddWithValue("@DateNaissance", Convert.ToDateTime(datenaissance));
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@situationfamiliale", situation);
                cmd.Parameters.AddWithValue("@mutuelle", mutuelle);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@patientid", patientid);

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


    }

}