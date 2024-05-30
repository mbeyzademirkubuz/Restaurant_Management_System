using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_Project
{
    internal class CashierOrderFormProdData
    {


        public int ID { set; get; }

        public string AD { set; get; }

        public string MASA { set; get; }

        public string DURUM { set; get; }

        public int KİŞİ { set; get; }

        public string TUTAR { set; get; }

        public string TARİH { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public List<CashierOrderFormProdData> availableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM orders WHERE order_situation = @stats";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Aktif");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderFormProdData apd = new CashierOrderFormProdData();

                            apd.ID = (int)reader["order_id"];
                            apd.AD = reader["order_name"].ToString();
                            apd.MASA = reader["order_table"].ToString();
                            apd.DURUM = reader["order_situation"].ToString();
                            apd.KİŞİ = (int)reader["order_people"];
                            apd.TUTAR = reader["total_cost"].ToString();
                            apd.TARİH = reader["order_date"].ToString();

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
