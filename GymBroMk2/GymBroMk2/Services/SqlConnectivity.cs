using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace GymBroMk2.Services
{
    class SqlConnectivity
    {
        public static SqlConnection con;
        public SqlConnectivity()
        {

        }
        private void trying()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("insert SQL string here"))
                {
                    //open connection
                    connection.Open();
                    
                    connection.Close();
               
                       
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
