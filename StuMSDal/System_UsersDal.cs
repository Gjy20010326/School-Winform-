using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StuMSModels;

namespace StuMSDal
{
    public class System_UsersDal
    {
        //查询是否有账号密码
        public int SelUsers(string ucode, string upwd)
        {
            string sql = "select * from System_Users where ucode='" + ucode + "' and upwd ='" + upwd + "'";
            SqlDataReader dr = null;
            var a = 0;
            try
            {
                dr = ADOTools.ExcuteReader(sql);
                if (dr.HasRows)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return a;
        }
        
        //public int UpdStudentPwd(string spwd,int sid)
        //{
        //    string sql = "UPDATE student SET spassword = '"+spwd+"' WHERE sid = "+sid+"";
        //    return ADOTools.ExcuteNoQuery(sql);
        //}


        
        
        
    }
}
