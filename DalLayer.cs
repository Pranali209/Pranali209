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
            SqlConnection cn = new SqlConnection("Data Source=desktop-7gh9mjq\\sqlexpress;Integrated Security=true;database=OnlineShopping");
            string s = "Select[dbo].[AdminLoginFunction](@p_aid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s,cn);
            cmd.Parameters.AddWithValue("@p_aid",ba.AdminId); 
            cmd.Parameters.AddWithValue("@p_pwd",ba.AdminPassword);
            
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(); 
            rdr.Read(); 
            bool ans = false; 
            if (Convert.ToInt32(rdr[0]) == 1)
            {
                //Console.WriteLine("u r welcome"); 
                ans = true; 
            }
            else 
            { 
                //Console.WriteLine("bye"); 
                ans = false; 
            }
            cn.Close(); 
            cn.Dispose();
            return ans;
        }
       
        
    }
}
