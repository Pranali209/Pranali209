using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalProject;

namespace DalProject
{
    public class DalLayer
    {
       public bool Check(BalLayer ba)
        {
            SqlConnection cn = new SqlConnection("server=desktop-7gh9mjq\\sqlexpress;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_AdminLogin]";
            SqlCommand cmd = new SqlCommand(s,cn);
            cmd.Parameters.AddWithValue("@aid",ba.AdminId); 
            cmd.Parameters.AddWithValue("@pswd",ba.AdminPassword);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(); 
            rdr.Read(); 
            bool ans = false; //array format //dr[0] if (Convert.ToInt32(rdr
            if (Convert.ToInt32(rdr[1]) == 1)
            {
                Console.WriteLine("u r welcome"); 
                ans = true; 
            }
            else 
            { 
                Console.WriteLine("bye"); 
                ans = false; 
            }
            cn.Close(); 
            cn.Dispose();
            return ans;
        }
        
    }
}
