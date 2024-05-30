using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_Project
{
    internal class MenuData
    {
       
        public int ID { set; get; }
        public string İSİM { set; get; }
        public string TÜR { set; get; }
        public int FİYAT { set; get; }
        public string İÇERİK { set; get; }
        public string FOTOĞRAF { set; get; }
        




        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public List<MenuData> menuListData()
        {
            List<MenuData> listdata = new List<MenuData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();


                    string selectData = "SELECT * FROM food";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            MenuData md = new MenuData
                            {
                                ID = (int)reader["food_id"],
                                İSİM = reader["food_name"].ToString(),
                                TÜR = reader["food_type"].ToString(),
                                FİYAT = (int)reader["food_price"],
                                İÇERİK = reader["food_description"].ToString(),
                                FOTOĞRAF = reader["food_image"].ToString()
                            };


                            listdata.Add(md);
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
