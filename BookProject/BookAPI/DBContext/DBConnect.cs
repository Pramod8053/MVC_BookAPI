using System.Data.SqlClient;
using System.Configuration;

namespace BookAPI.DBContext
{
    public class DBConnect
    {
        public SqlConnection Connect()
        {
            string BookStr = ConfigurationManager.ConnectionStrings["BookStr"].ToString();
            SqlConnection Con = new SqlConnection(BookStr);
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Open();
            }
            else
                Con.Close();
            return Con;
        }
    }
}