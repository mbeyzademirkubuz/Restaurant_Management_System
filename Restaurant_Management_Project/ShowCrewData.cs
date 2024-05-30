using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_Project
{
    internal class ShowCrewData
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

        public List<ShowCrewData> showCrewListData()
        {
            List<ShowCrewData> listdata = new List<ShowCrewData>();

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
                            ShowCrewData scd = new ShowCrewData();
                            scd.ID = (int)reader["employee_id"];
                            scd.İSİM = reader["first_name"].ToString();
                            scd.SOYİSİM = reader["last_name"].ToString();
                            scd.DEPARTMAN = reader["department_name"].ToString();
                            scd.EMAİL = reader["email"].ToString();
                            scd.TELEFON = reader["phone"].ToString();
                            scd.SHIFT = reader["shift"].ToString();
                            scd.GİRİŞ_TARİHİ = reader["hire_date"].ToString();
                            scd.MAAŞ = (int)reader["salary"];
                            //scd.FOTOĞRAF = reader["image"].ToString();


                            listdata.Add(scd);
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
