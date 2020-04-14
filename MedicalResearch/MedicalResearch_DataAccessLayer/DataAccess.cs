using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch_DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        // static SqlConnection sqlConnection = new SqlConnection("data source=.;database='Hospital';integrated security=true");

        private SqlConnection connection;
        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
            connection = new SqlConnection(constr);
        }

        public void AddDisease(Diseases diseases)
        {
            try
            {
                sqlconnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("AddDisease", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Disease_Name", diseases.Disease_Name);
                cmd.Parameters.AddWithValue("@Disease_Severity_Id", diseases.Disease_Severity_Id.Severity_Id);
                cmd.Parameters.AddWithValue("@Disease_Cause_Id", diseases.Disease_Cause_Id.Cause_ID);
                cmd.Parameters.AddWithValue("@Disease_Description", diseases.Disease_Description);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException e)
            {
                throw new InvalidData("You have entered invalid data", e);
            }

        }
        public List<Severity> DisplaySeverity()
        {
            sqlconnection();
            List<Severity> severities = new List<Severity>();
            SqlCommand cmd = new SqlCommand("sp_DisplaySeverity", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Severity severity = new Severity();
                severity.Severity_Id = (int)rd["Severity_Id"];
                severity.Severity_Name = (string)rd["Severity_Name"];
                severities.Add(severity);
            }
            connection.Close();
            return severities;
        }
        public List<Cause> DisplayCause()
        {
            sqlconnection();
            List<Cause> causes = new List<Cause>();
            SqlCommand cmd = new SqlCommand("sp_DisplayCause", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Cause cause = new Cause();
                cause.Cause_ID = (int)rd["Cause_ID"];
                cause.Cause_Name = (string)rd["Cause_Name"];
                causes.Add(cause);
            }
            connection.Close();
            return causes;
        }
        public List<Diseases> DisplayDiseases()
        {
            sqlconnection();
            List<Diseases> diseases = new List<Diseases>();
            SqlCommand cmd = new SqlCommand("sp_DisplayDiseases", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Diseases disease = new Diseases();
                disease.Disease_Id = (int)rd["Disease_Id"];
                disease.Disease_Name = (string)rd["Disease_Name"];
                diseases.Add(disease);
            }
            connection.Close();
            return diseases;
        }
        public List<Diseases> DisplayDisease()
        {
            sqlconnection();
            List<Diseases> diseases = new List<Diseases>();
            SqlCommand cmd = new SqlCommand("sp_DisplayDiseases", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Diseases disease = new Diseases();               
                disease.Disease_Name = (string)rd["Disease_Name"];
                diseases.Add(disease);
            }
            connection.Close();
            return diseases;
        }
        public List<Symptom> DisplaySymptom()
        {
            sqlconnection();
            List<Symptom> symptoms = new List<Symptom>();
            SqlCommand cmd = new SqlCommand("sp_DisplaySymptoms", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Symptom symptom = new Symptom();              
                symptom.Symptom_Name = (string)rd["Symptom_Name"];
                symptoms.Add(symptom);
            }
            connection.Close();
            return symptoms;
        }
        public List<Symptom> DisplaySymptoms()
        {
            sqlconnection();
            List<Symptom> symptoms = new List<Symptom>();
            SqlCommand cmd = new SqlCommand("sp_DisplaySymptoms", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Symptom symptom = new Symptom();
                symptom.Symptom_Id = (int)rd["Symptom_Id"];
                symptom.Symptom_Name = (string)rd["Symptom_Name"];
                symptoms.Add(symptom);
            }
            connection.Close();
            return symptoms;
        }
        public void AddDiseaseWithSymptom(DiseaseWithSymptom diseaseWithSymptom)
        {
            sqlconnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("AddDiseaseWithSymptom", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DsDisease_Id", diseaseWithSymptom.DsDisease_Id.Disease_Id);
            cmd.Parameters.AddWithValue("@DsSymptom_Id", diseaseWithSymptom.DsSymptom_Id.Symptom_Id);
            cmd.Parameters.AddWithValue("@DiseaseSymptom_Description", diseaseWithSymptom.DiseaseSymptom_Description);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<DiseaseWithSymptom> DisplayDiagnose(string name ,int id1, int id2)
        {
            sqlconnection();            
            List<DiseaseWithSymptom> diseaseWithSymptoms = new List<DiseaseWithSymptom>();
            SqlCommand cmd = new SqlCommand("DisplayDiagnose1", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID1", id1);
            cmd.Parameters.AddWithValue("@ID2", id2);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DiseaseWithSymptom diseaseWithSymptom = new DiseaseWithSymptom();
                diseaseWithSymptom.DsDisease_Id = new Diseases();
                diseaseWithSymptom.DsDisease_Id.Disease_Name = (string)sdr["Disease_Name"];
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id = new Severity();
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id.Severity_Name = (string)sdr["Severity_Name"];
                diseaseWithSymptom.DsSymptom_Id = new Symptom();
                diseaseWithSymptom.DsSymptom_Id.Symptom_Name = (string)sdr["Symptom_Name"];
                diseaseWithSymptoms.Add(diseaseWithSymptom);
            }
            connection.Close();
            return diseaseWithSymptoms;
        }
        //DisplayDiagnosewithSymptom1
        public List<DiseaseWithSymptom> DisplayDiagnose(string name, int id1)
        {
            sqlconnection();
            List<DiseaseWithSymptom> diseaseWithSymptoms = new List<DiseaseWithSymptom>();
            SqlCommand cmd = new SqlCommand("DisplayDiagnosewithSymptom1", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID1", id1);           
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DiseaseWithSymptom diseaseWithSymptom = new DiseaseWithSymptom();
                diseaseWithSymptom.DsDisease_Id = new Diseases();
                diseaseWithSymptom.DsDisease_Id.Disease_Name = (string)sdr["Disease_Name"];
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id = new Severity();
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id.Severity_Name = (string)sdr["Severity_Name"];
                diseaseWithSymptom.DsSymptom_Id = new Symptom();
                diseaseWithSymptom.DsSymptom_Id.Symptom_Name = (string)sdr["Symptom_Name"];
                diseaseWithSymptoms.Add(diseaseWithSymptom);
            }
            connection.Close();
            return diseaseWithSymptoms;
        }
        public List<DiseaseWithSymptom> DisplayDiagnoseWithSecondSymptom(string name, int id2)
        {
            sqlconnection();
            List<DiseaseWithSymptom> diseaseWithSymptoms = new List<DiseaseWithSymptom>();
            SqlCommand cmd = new SqlCommand("DisplayDiagnosewithSymptom1", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID1", id2);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DiseaseWithSymptom diseaseWithSymptom = new DiseaseWithSymptom();
                diseaseWithSymptom.DsDisease_Id = new Diseases();
                diseaseWithSymptom.DsDisease_Id.Disease_Name = (string)sdr["Disease_Name"];
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id = new Severity();
                diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id.Severity_Name = (string)sdr["Severity_Name"];
                diseaseWithSymptom.DsSymptom_Id = new Symptom();
                diseaseWithSymptom.DsSymptom_Id.Symptom_Name = (string)sdr["Symptom_Name"];
                diseaseWithSymptoms.Add(diseaseWithSymptom);
            }
            connection.Close();
            return diseaseWithSymptoms;
        }
        public List<int> SymptomCount(int diseaseid)
        {
            sqlconnection();
            List<int> symptomcount = new List<int>();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select DsDisease_Id from DiseaseWithSymptom where DsDisease_Id = @id", connection);
            sqlCommand.Parameters.AddWithValue("@id", diseaseid);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int count = sqlDataReader.GetInt32(0);
                symptomcount.Add(count);
            }
            connection.Close();
            return symptomcount;
        }
        public void ExportToTextFile(List<DiseaseWithSymptom> diseaseWithSymptoms, string name)
        {
            string filepath = $@"D:Hospital\{name}.txt";
            using (StreamWriter streamWriter = File.AppendText(filepath))
            {
                streamWriter.WriteLine("Patient details:");
                foreach(DiseaseWithSymptom diseaseWithSymptom in diseaseWithSymptoms)
                {
                    streamWriter.WriteLine($"{diseaseWithSymptom.DsDisease_Id.Disease_Name}"+"\n"+$"{diseaseWithSymptom.DsDisease_Id.Disease_Severity_Id.Severity_Name}"+"\n"+$"{diseaseWithSymptom.DsSymptom_Id.Symptom_Name}");
                }
            }
        }
    }
}


















     