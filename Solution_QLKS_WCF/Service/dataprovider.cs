using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class dataprovider
    {
        //static bool start = false;
        private static SqlConnection connection = null;
        private static dataprovider data;
        internal static dataprovider Dataprovider 
        { 
            get 
            { 
                if (data == null) 
                    data = new dataprovider(); 
                if(connection == null)
                {
                    connection = new SqlConnection(@"Data Source=DESKTOP-6PFP726;Initial Catalog=QLKS;Integrated Security=True");
                    connection.Open();
                }    
                return data; 
            } 
        }

        //private static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6PFP726;Initial Catalog=QLKS;Integrated Security=True");
        //private static SqlConnection connection = new SqlConnection(@"Data Source=demo-wcf.cjgg21zib0dc.ap-southeast-1.rds.amazonaws.com;Initial Catalog=QLKS;Persist Security Info=True;User ID=admin;Password=admin12345");

        private dataprovider() { }
        public DataTable cautv(String ten, object[] para)
        {
            DataTable dt = new DataTable();
            /*if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                start = true;
            }    
            if(!start)
                connection.Open();*/
            String query = "exec ";
            query += ten;
            query += " ";
            for (int i = 0; i < para.Length; i++)
            {
                query += "N'";
                query += para[i];
                query += "'";
                if (i != para.Length - 1)
                {
                    query += ",";
                }
            }
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);
            /*try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            catch(Exception)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }*/
            /*if (connection.State == ConnectionState.Open)
                connection.Close();*/
            return dt;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
