using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_Project
{
    internal class CashierOrderData
    {

        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");

        public int ID { set; get; }
        public int CID { set; get; }
        //public int ProdID { set; get; }
        public string ProdName { set; get; }
        public string ProdType { set; get; }
        public int Qty { set; get; }
        public int Price { set; get; }

        public List<CashierOrderData> ordersListData()
        {
            List<CashierOrderData> listData = new List<CashierOrderData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand getCustData = new SqlCommand(selectCustData, connect))
                    {
                        object result = getCustData.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectOrders = "SELECT * FROM orders WHERE customer_id = @customerID";

                    using (SqlCommand cmd = new SqlCommand(selectOrders, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderData coData = new CashierOrderData();

                            coData.ID = (int)reader["id"];
                            coData.CID = (int)reader["customer_id"];
                            //coData.ProdID = (int)reader["food_id"];
                            coData.ProdName = reader["food_name"].ToString();
                            coData.ProdType = reader["food_type"].ToString();
                            coData.Qty = (int)reader["order_people"];
                            coData.Price = (int)reader["total_cost"];


                                Console.WriteLine("Bağlantı Hatası : ");

                            listData.Add(coData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bağlantı Hatası : " + ex);
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
