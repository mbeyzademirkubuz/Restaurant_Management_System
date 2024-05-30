using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_Project
{

    //TABLO GÖRÜNÜMÜNDE VERİLERİ EŞLEŞTİRMEK İÇİN AŞAĞIDAKİ İŞLEMLER GERÇEKLEŞTİRİLMİŞTİR.
    internal class CrewData
    {

        public int ID { set; get; }
        public string İSİM { set; get; }
        public string SOYİSİM { set; get; }
        public string DEPARTMAN { set; get; }
        public string EMAİL { set; get; }
        public string TELEFON { set; get; }
        public string SHIFT { set; get; }
        public string GİRİŞ_TARİHİ { set; get; }
        public int MAAŞ { set; get; }
        //public string FOTOĞRAF { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");

        public List<CrewData> crewListData()
        {
            List<CrewData> listdata = new List<CrewData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();


                    string selectData = "SELECT * FROM employees";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CrewData cd = new CrewData();
                            cd.ID = (int)reader["employee_id"];
                            cd.İSİM = reader["first_name"].ToString();
                            cd.SOYİSİM = reader["last_name"].ToString();
                            cd.DEPARTMAN = reader["department_name"].ToString();
                            cd.EMAİL = reader["email"].ToString();
                            cd.TELEFON = reader["phone"].ToString();
                            cd.SHIFT = reader["shift"].ToString();
                            cd.GİRİŞ_TARİHİ = reader["hire_date"].ToString();
                            cd.MAAŞ = (int)reader["salary"];
                            //cd.FOTOĞRAF = reader["image"].ToString();


                            listdata.Add(cd);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("HATA! : " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;

        }
    }
}
