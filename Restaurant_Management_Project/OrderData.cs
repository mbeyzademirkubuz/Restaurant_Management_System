using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant_Management_Project
{


    //TABLO GÖRÜNÜMÜNDE VERİLERİ EŞLEŞTİRMEK İÇİN AŞAĞIDAKİ İŞLEMLER GERÇEKLEŞTİRİLMİŞTİR.
    internal class OrderData
    {

        public int ID { set; get; }

        public string Sipariş_Adı { set; get; }

        public string Masa {  set; get; }

        public string Sipariş_Durumu { set; get; }

        public int Kişi_Sayısı { set; get; }

        public int Toplam_Tutar {  set; get; }

        public string Sipariş_Tarihi { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public List<OrderData> orderListData()
        {
            List<OrderData> listdata = new List<OrderData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();


                    string selectData = "SELECT * FROM orders";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrderData od = new OrderData();
                            od.ID = (int)reader["order_id"];
                            od.Sipariş_Adı = reader["order_name"].ToString();
                            od.Masa = reader["order_table"].ToString();
                            od.Sipariş_Durumu = reader["order_situation"].ToString();
                            od.Kişi_Sayısı = (int)reader["order_people"];
                            od.Toplam_Tutar = (int)reader["total_cost"];
                            od.Sipariş_Tarihi = reader["order_date"].ToString();


                            listdata.Add(od);
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

        public List<OrderData> availableProductsData()
        {
            List<OrderData> listData = new List<OrderData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM orders WHERE status = @stats";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Aktif");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrderData apd = new OrderData();

                            apd.ID = (int)reader["order_id"];
                            apd.Sipariş_Adı = reader["order_name"].ToString();
                            apd.Masa = reader["order_table"].ToString();
                            apd.Sipariş_Durumu = reader["order_situation"].ToString();
                            apd.Kişi_Sayısı = (int)reader["order_people"];
                            apd.Toplam_Tutar = (int)reader["total_cost"];
                            apd.Sipariş_Tarihi = reader["order_date"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }


    }
}
